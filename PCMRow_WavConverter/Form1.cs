using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Windows.Media;

namespace PCMRow_WavConverter
{
    public partial class Form1 : Form
    {

        #region [전역 변수]

        int _channelType = 0;        

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region [PCM to WAV]

        // WAV 파일 헤더를 작성하는 메서드
        private byte[] GetWavHeader(long dataLength, int sampleRate = 8000, int bitsPerSample = 16, int channels = 1)
        {
            long fileSize = dataLength + 36; // 오디오 데이터 크기 + 헤더 크기(36바이트)
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
                writer.Write((short)channels);
                writer.Write(sampleRate);
                writer.Write(sampleRate * channels * bitsPerSample / 8); // 바이트 레이트
                writer.Write((short)(channels * bitsPerSample / 8)); // 블록 정렬
                writer.Write((short)bitsPerSample);

                // data 청크
                writer.Write(Encoding.UTF8.GetBytes("data"));
                writer.Write((uint)dataLength); // 데이터 길이를 uint로 캐스팅하여 쓰기
            }

            return header;
        }
        // PCM 파일을 WAV 파일로 변환하는 메서드
        private void ConvertPcmToWav(string pcmFilePath, string wavFilePath, int channels = 1)
        {
            using (var pcmStream = new FileStream(pcmFilePath, FileMode.Open, FileAccess.Read))
            using (var wavStream = new FileStream(wavFilePath, FileMode.Create, FileAccess.Write))
            {
                var dataLength = pcmStream.Length;
                var header = GetWavHeader(dataLength, Convert.ToInt32(SamplingRate.Text), Convert.ToInt32(Bit.Text), _channelType);

                wavStream.Write(header, 0, header.Length);

                pcmStream.CopyTo(wavStream);
            }
        }
        private void FileUpload_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // 파일 대화 상자 설정
            openFileDialog.Title = "파일 선택"; // 대화 상자 제목
            openFileDialog.Filter = "PCM 파일|*.pcm"; // 파일 필터
            openFileDialog.FilterIndex = 1; // 기본으로 선택될 필터 인덱스
            openFileDialog.RestoreDirectory = true; // 마지막 디렉토리 기억

            if (openFileDialog.ShowDialog() == DialogResult.OK)  //다이얼로그 창 뜨고 선택
            {
                // 변환하고자 하는 파일
                FileUploadPath_TextBox.Text = openFileDialog.FileName;
            }
        }

        private void ExportPath_Button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // 변환한 파일을 위치할 곳
                ExportPath_TextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }     

        private void RunConvert_Button_Click(object sender, EventArgs e)
        {
            string pcmFilePath = FileUploadPath_TextBox.Text;
            string wavFilePath = Path.Combine(ExportPath_TextBox.Text, "output.wav");
            ConvertPcmToWav(pcmFilePath, wavFilePath);            

            MessageBox.Show("Wav 형태로 변환을 완료하였습니다.");
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (StereoButton.Checked)
            {
                _channelType = 2;
            }
            else if (MonoButton.Checked)
            {
                _channelType = 1;
            }
            #endregion
        }
    }
}
