using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioConverter
{
    class WavToPcmRowFormat
    {
        /// <summary>
        /// WAV 파일의 헤더를 생성
        /// </summary>
        /// <param name="dataLength"></param>
        /// <param name="sampleRate"></param>
        /// <param name="bitsPerSample"></param>
        /// <param name="channel"></param>
        /// <returns></returns>
        private byte[] ExceptWavHeader(long dataLength)
        {
            // 파일 크기 = 오디오 데이터 크기 + 헤더 크기(36바이트)
            long fileSize = dataLength - 36;
            byte[] header = new byte[44];

            using (var memoryStream = new MemoryStream(header))
            using (var writer = new BinaryWriter(memoryStream))
            {
                // RIFF 헤더
                writer.Write(Encoding.UTF8.GetBytes("RIFF"));
                writer.Write((uint)fileSize); // 파일 크기를 uint로 캐스팅하여 쓰기
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

        private List<int> GetWavHeaderInfo()
        {

        }
        /// <summary>        
        /// PCM 에서 WAV로 변환
        /// </summary>
        /// <param name="pcmFilePath"></param>
        /// <param name="wavFilePath"></param>
        public void ConvertPcmToWav(string wavFilePath, string pcmFilePath)
        {
            using (var wavStream = new FileStream(wavFilePath, FileMode.Open, FileAccess.Read))
            using (var pcmStream = new FileStream(pcmFilePath, FileMode.Create, FileAccess.Write))
            {
                var dataLength = wavStream.Length;
                var pcmFile = ExceptWavHeader(dataLength);

                pcmStream.Write(pcmFile, 0, pcmFile.Length);

                wavStream.CopyTo(pcmStream);
            }
        }
    }
}
