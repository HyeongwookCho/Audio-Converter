using System;
using System.IO;
using System.Windows.Forms;

namespace AudioConverter
{
    public partial class Form1 : Form
    {

        #region [전역 변수]

        int _channelType = 0;
        PcmRowFormatToWav _pcmRowFormatToWav;
        WavToPcmRowFormat _wavToPcmRowFormat;
        #endregion

        public Form1()
        {
            InitializeComponent();
            _pcmRowFormatToWav = new PcmRowFormatToWav();
            _wavToPcmRowFormat = new WavToPcmRowFormat();
        }

        #region [PCM To WAV Setting & Click Button]
        
        /// <summary>
        /// 변환 할 파일 경로 설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 변환 후 저장 파일 경로 설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportPath_Button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // 변환한 파일을 위치할 곳
                ExportPath_TextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }     

        /// <summary>
        /// PCM Row Format to Wav 변환 버튼 클릭 시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RunConvert_Button_Click(object sender, EventArgs e)
        {
            string pcmFilePath = FileUploadPath_TextBox.Text;
            string FileName = $"{ExportFileName1_TextBox.Text}.wav";
            string wavFilePath = Path.Combine(ExportPath_TextBox.Text, FileName);
            _pcmRowFormatToWav.ConvertPcmToWav(pcmFilePath, wavFilePath, SamplingRate.Text, Bit.Text, _channelType);            

            MessageBox.Show("WAV 형태로 변환을 완료하였습니다.");
        }

        /// <summary>
        /// Stereo 타입 설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StereoButton_CheckedChanged(object sender, EventArgs e)
        {
            this._channelType = 2;
        }
        /// <summary>
        /// Mono 타입 설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MonoButton_CheckedChanged(object sender, EventArgs e)
        {
            this._channelType = 1;
        }
        #endregion        

        #region [WAV To PCM Setting & Click Button]

        private void FileUpload2_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // 파일 대화 상자 설정
            openFileDialog.Title = "파일 선택"; // 대화 상자 제목
            openFileDialog.Filter = "WAV 파일|*.wav"; // 파일 필터
            openFileDialog.FilterIndex = 1; // 기본으로 선택될 필터 인덱스
            openFileDialog.RestoreDirectory = true; // 마지막 디렉토리 기억

            if (openFileDialog.ShowDialog() == DialogResult.OK)  //다이얼로그 창 뜨고 선택
            {
                // 변환하고자 하는 파일
                FileUploadPath2_TextBox.Text = openFileDialog.FileName;
            }
        }

        private void ExportPath2_Button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // 변환한 파일을 위치할 곳
                ExportPath2_TextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }
        private void RunConvert2_Button_Click(object sender, EventArgs e)
        {
            string wavFilePath = FileUploadPath2_TextBox.Text;
            string FileName = $"{ExportFileName2_TextBox.Text}.pcm";
            string pcmFilePath = Path.Combine(ExportPath2_TextBox.Text, FileName);
            _wavToPcmRowFormat.ConvertWavToPCMRow(wavFilePath, pcmFilePath);

            MessageBox.Show("PCM Row 형태로 변환을 완료하였습니다.");

            ExportBitRate_TextBox.Text = Convert.ToString(_wavToPcmRowFormat.GetBitPerSample());
            ExportSamplingRate_textbox.Text = Convert.ToString(_wavToPcmRowFormat.GetSampleRate());
            ExportChannel_textbox.Text = Convert.ToString(_wavToPcmRowFormat.GetChannel());
        }
        #endregion


    }
}
