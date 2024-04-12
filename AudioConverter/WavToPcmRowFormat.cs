using System;
using System.IO;
using System.Text;

namespace AudioConverter
{
    class WavToPcmRowFormat
    {
        public uint _bitsPerSample = 0;
        public uint _sampleRate = 0;
        public uint _channel = 0;

        /// <summary>
        /// WAV 파일의 헤더 정보를 읽어옵니다.
        /// </summary>
        /// <param name="wavStream">WAV 파일의 스트림</param>
        private void GetHeaderInfo(Stream wavStream)
        {
            using (var reader = new BinaryReader(wavStream, Encoding.UTF8, true))
            {
                // RIFF 헤더 넘기기
                reader.ReadBytes(12);

                // fmt 청크 찾기
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    var chunkId = new string(reader.ReadChars(4));
                    var chunkSize = reader.ReadUInt32();

                    if (chunkId == "fmt ")
                    {
                        reader.ReadUInt16(); // 오디오 포맷
                        _channel = reader.ReadUInt16(); // 채널 수
                        _sampleRate = reader.ReadUInt32(); // 샘플 레이트
                        reader.ReadUInt32(); // 바이트 레이트
                        reader.ReadUInt16(); // 블록 정렬
                        _bitsPerSample = reader.ReadUInt16(); // 비트 깊이
                        break;
                    }
                    else
                    {
                        reader.BaseStream.Seek(chunkSize, SeekOrigin.Current);
                    }
                }
            }
        }

        /// <summary>        
        /// WAV에서 PCM으로 변환
        /// </summary>
        /// <param name="wavFilePath">WAV 파일 경로</param>
        /// <param name="pcmFilePath">변환될 PCM 파일 경로</param>
        public void ConvertWavToPCMRow(string wavFilePath, string pcmFilePath)
        {
            using (var wavStream = new FileStream(wavFilePath, FileMode.Open, FileAccess.Read))
            using (var pcmStream = new FileStream(pcmFilePath, FileMode.Create, FileAccess.Write))
            {
                // WAV 파일에서 헤더 정보 읽기
                GetHeaderInfo(wavStream);

                // 헤더 정보를 제외한 PCM 데이터만 복사
                long pcmDataSize = wavStream.Length - wavStream.Position;
                byte[] buffer = new byte[pcmDataSize];
                wavStream.Read(buffer, 0, buffer.Length);
                pcmStream.Write(buffer, 0, buffer.Length);
            }
        }

        public uint GetBitPerSample()
        {
            return _bitsPerSample;
        }
        public uint GetChannel()
        {
            return _channel;

        }
        public uint GetSampleRate()
        {
            return _sampleRate;
        }
    }
}
