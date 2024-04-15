using System;
using System.IO;
using System.Text;

namespace AudioConverter
{
    class PcmRowFormatToWav
    {
        /// <summary>
        /// WAV 파일의 헤더를 생성
        /// </summary>
        /// <param name="dataLength"></param>
        /// <param name="sampleRate"></param>
        /// <param name="bitsPerSample"></param>
        /// <param name="channel"></param>
        /// <returns></returns>
        private byte[] GetWavHeader(long dataLength, int sampleRate, int bitsPerSample, int channel)
        {
            // 파일 크기 = 오디오 데이터 크기 +  ( 헤더 크기(44바이트) - 'RIFF'와 파일 크기 필드의 크기(8바이트) )
            long fileSize = dataLength + 36;
            byte[] header = new byte[44];

            using (var memoryStream = new MemoryStream(header))
            using (var writer = new BinaryWriter(memoryStream))
            {
                // RIFF 헤더
                writer.Write(Encoding.UTF8.GetBytes("RIFF"));
                writer.Write((uint)fileSize);
                writer.Write(Encoding.UTF8.GetBytes("WAVE"));

                // fmt 청크
                writer.Write(Encoding.UTF8.GetBytes("fmt "));
                writer.Write(16); // fmt 청크의 크기
                writer.Write((short)1); // 오디오 포맷 (1은 PCM)
                writer.Write((short)channel);
                writer.Write(sampleRate);
                writer.Write(sampleRate * channel * bitsPerSample / 8); // 바이트 레이트
                writer.Write((short)(channel * bitsPerSample / 8)); // 블록 정렬
                writer.Write((short)bitsPerSample);

                // data 청크
                writer.Write(Encoding.UTF8.GetBytes("data"));
                writer.Write((uint)dataLength);
            }

            return header;
        }
        /// <summary>        
        /// PCM 에서 WAV로 변환
        /// </summary>
        /// <param name="pcmFilePath"></param>
        /// <param name="wavFilePath"></param>
        public void ConvertPcmToWav(string pcmFilePath, string wavFilePath, string SamplingRate, string Bit, int channel)
        {
            using (var pcmStream = new FileStream(pcmFilePath, FileMode.Open, FileAccess.Read))
            using (var wavStream = new FileStream(wavFilePath, FileMode.Create, FileAccess.Write))
            {
                var dataLength = pcmStream.Length;
                var header = GetWavHeader(dataLength, Convert.ToInt32(SamplingRate), Convert.ToInt32(Bit), channel);

                wavStream.Write(header, 0, header.Length);

                pcmStream.CopyTo(wavStream);
            }
        }
    }
}
