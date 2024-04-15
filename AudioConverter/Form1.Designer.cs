
namespace AudioConverter
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RunConvert_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExportFileName1_TextBox = new System.Windows.Forms.TextBox();
            this.ExportPath_TextBox = new System.Windows.Forms.TextBox();
            this.ExportPath_Button = new System.Windows.Forms.Button();
            this.ConvertFile_Label = new System.Windows.Forms.Label();
            this.FileUpload_Panel = new System.Windows.Forms.Panel();
            this.Bit = new System.Windows.Forms.TextBox();
            this.SamplingRate = new System.Windows.Forms.TextBox();
            this.StereoButton = new System.Windows.Forms.RadioButton();
            this.MonoButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FileUploadPath_TextBox = new System.Windows.Forms.TextBox();
            this.FileUpload_Button = new System.Windows.Forms.Button();
            this.FileUpload_Label = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PCMtoWAV = new System.Windows.Forms.TabPage();
            this.WAVtoPCM = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.ExportChannel_textbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ExportBitRate_TextBox = new System.Windows.Forms.TextBox();
            this.ExportSamplingRate_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RunConvert2_Button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ExportFileName2_TextBox = new System.Windows.Forms.TextBox();
            this.ExportPath2_TextBox = new System.Windows.Forms.TextBox();
            this.ExportPath2_Button = new System.Windows.Forms.Button();
            this.ConvertFile2_Label = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.FileUploadPath2_TextBox = new System.Windows.Forms.TextBox();
            this.FileUpload2_Button = new System.Windows.Forms.Button();
            this.FileUpload2_Label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.FileUpload_Panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.PCMtoWAV.SuspendLayout();
            this.WAVtoPCM.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY헤드라인M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lucis Audio Converter";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.RunConvert_Button);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ConvertFile_Label);
            this.panel1.Controls.Add(this.FileUpload_Panel);
            this.panel1.Controls.Add(this.FileUpload_Label);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 225);
            this.panel1.TabIndex = 9;
            // 
            // RunConvert_Button
            // 
            this.RunConvert_Button.BackColor = System.Drawing.Color.LightCoral;
            this.RunConvert_Button.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RunConvert_Button.Location = new System.Drawing.Point(250, 181);
            this.RunConvert_Button.Name = "RunConvert_Button";
            this.RunConvert_Button.Size = new System.Drawing.Size(99, 37);
            this.RunConvert_Button.TabIndex = 13;
            this.RunConvert_Button.Text = "Convert";
            this.RunConvert_Button.UseVisualStyleBackColor = false;
            this.RunConvert_Button.Click += new System.EventHandler(this.RunConvert_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Image = global::AudioConverter.Properties.Resources.pngtree_vector_down_arrow_icon_png_image_9272051;
            this.pictureBox1.InitialImage = global::AudioConverter.Properties.Resources.pngtree_vector_down_arrow_icon_png_image_9272051;
            this.pictureBox1.Location = new System.Drawing.Point(279, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.ExportFileName1_TextBox);
            this.panel2.Controls.Add(this.ExportPath_TextBox);
            this.panel2.Controls.Add(this.ExportPath_Button);
            this.panel2.Location = new System.Drawing.Point(12, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 44);
            this.panel2.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(418, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = ".wav";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "\\";
            // 
            // ExportFileName1_TextBox
            // 
            this.ExportFileName1_TextBox.Location = new System.Drawing.Point(341, 11);
            this.ExportFileName1_TextBox.Name = "ExportFileName1_TextBox";
            this.ExportFileName1_TextBox.Size = new System.Drawing.Size(71, 21);
            this.ExportFileName1_TextBox.TabIndex = 11;
            // 
            // ExportPath_TextBox
            // 
            this.ExportPath_TextBox.Location = new System.Drawing.Point(19, 11);
            this.ExportPath_TextBox.Name = "ExportPath_TextBox";
            this.ExportPath_TextBox.ReadOnly = true;
            this.ExportPath_TextBox.Size = new System.Drawing.Size(296, 21);
            this.ExportPath_TextBox.TabIndex = 4;
            // 
            // ExportPath_Button
            // 
            this.ExportPath_Button.Location = new System.Drawing.Point(460, 9);
            this.ExportPath_Button.Name = "ExportPath_Button";
            this.ExportPath_Button.Size = new System.Drawing.Size(99, 23);
            this.ExportPath_Button.TabIndex = 3;
            this.ExportPath_Button.Text = "Export Path";
            this.ExportPath_Button.UseVisualStyleBackColor = true;
            this.ExportPath_Button.Click += new System.EventHandler(this.ExportPath_Button_Click);
            // 
            // ConvertFile_Label
            // 
            this.ConvertFile_Label.AutoSize = true;
            this.ConvertFile_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConvertFile_Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ConvertFile_Label.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertFile_Label.Location = new System.Drawing.Point(12, 115);
            this.ConvertFile_Label.Name = "ConvertFile_Label";
            this.ConvertFile_Label.Size = new System.Drawing.Size(38, 13);
            this.ConvertFile_Label.TabIndex = 10;
            this.ConvertFile_Label.Text = "WAV";
            // 
            // FileUpload_Panel
            // 
            this.FileUpload_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FileUpload_Panel.Controls.Add(this.Bit);
            this.FileUpload_Panel.Controls.Add(this.SamplingRate);
            this.FileUpload_Panel.Controls.Add(this.StereoButton);
            this.FileUpload_Panel.Controls.Add(this.MonoButton);
            this.FileUpload_Panel.Controls.Add(this.label4);
            this.FileUpload_Panel.Controls.Add(this.label3);
            this.FileUpload_Panel.Controls.Add(this.label2);
            this.FileUpload_Panel.Controls.Add(this.FileUploadPath_TextBox);
            this.FileUpload_Panel.Controls.Add(this.FileUpload_Button);
            this.FileUpload_Panel.Location = new System.Drawing.Point(12, 23);
            this.FileUpload_Panel.Name = "FileUpload_Panel";
            this.FileUpload_Panel.Size = new System.Drawing.Size(580, 67);
            this.FileUpload_Panel.TabIndex = 9;
            // 
            // Bit
            // 
            this.Bit.Location = new System.Drawing.Point(77, 38);
            this.Bit.Name = "Bit";
            this.Bit.Size = new System.Drawing.Size(60, 21);
            this.Bit.TabIndex = 21;
            // 
            // SamplingRate
            // 
            this.SamplingRate.Location = new System.Drawing.Point(255, 38);
            this.SamplingRate.Name = "SamplingRate";
            this.SamplingRate.Size = new System.Drawing.Size(60, 21);
            this.SamplingRate.TabIndex = 20;
            // 
            // StereoButton
            // 
            this.StereoButton.AutoSize = true;
            this.StereoButton.Location = new System.Drawing.Point(325, 41);
            this.StereoButton.Name = "StereoButton";
            this.StereoButton.Size = new System.Drawing.Size(59, 16);
            this.StereoButton.TabIndex = 19;
            this.StereoButton.Text = "Stereo";
            this.StereoButton.UseVisualStyleBackColor = true;
            this.StereoButton.CheckedChanged += new System.EventHandler(this.StereoButton_CheckedChanged);
            // 
            // MonoButton
            // 
            this.MonoButton.AutoSize = true;
            this.MonoButton.Location = new System.Drawing.Point(390, 41);
            this.MonoButton.Name = "MonoButton";
            this.MonoButton.Size = new System.Drawing.Size(55, 16);
            this.MonoButton.TabIndex = 14;
            this.MonoButton.Text = "Mono";
            this.MonoButton.UseVisualStyleBackColor = true;
            this.MonoButton.CheckedChanged += new System.EventHandler(this.MonoButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "&&";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sampling Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "Bit";
            // 
            // FileUploadPath_TextBox
            // 
            this.FileUploadPath_TextBox.Location = new System.Drawing.Point(19, 11);
            this.FileUploadPath_TextBox.Name = "FileUploadPath_TextBox";
            this.FileUploadPath_TextBox.ReadOnly = true;
            this.FileUploadPath_TextBox.Size = new System.Drawing.Size(426, 21);
            this.FileUploadPath_TextBox.TabIndex = 4;
            // 
            // FileUpload_Button
            // 
            this.FileUpload_Button.Location = new System.Drawing.Point(460, 9);
            this.FileUpload_Button.Name = "FileUpload_Button";
            this.FileUpload_Button.Size = new System.Drawing.Size(99, 23);
            this.FileUpload_Button.TabIndex = 3;
            this.FileUpload_Button.Text = "File Upload";
            this.FileUpload_Button.UseVisualStyleBackColor = true;
            this.FileUpload_Button.Click += new System.EventHandler(this.FileUpload_Button_Click);
            // 
            // FileUpload_Label
            // 
            this.FileUpload_Label.AutoSize = true;
            this.FileUpload_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FileUpload_Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FileUpload_Label.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FileUpload_Label.Location = new System.Drawing.Point(12, 5);
            this.FileUpload_Label.Name = "FileUpload_Label";
            this.FileUpload_Label.Size = new System.Drawing.Size(127, 13);
            this.FileUpload_Label.TabIndex = 5;
            this.FileUpload_Label.Text = "PCM Row Format";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PCMtoWAV);
            this.tabControl1.Controls.Add(this.WAVtoPCM);
            this.tabControl1.Location = new System.Drawing.Point(11, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(627, 265);
            this.tabControl1.TabIndex = 10;
            // 
            // PCMtoWAV
            // 
            this.PCMtoWAV.Controls.Add(this.panel1);
            this.PCMtoWAV.Location = new System.Drawing.Point(4, 22);
            this.PCMtoWAV.Name = "PCMtoWAV";
            this.PCMtoWAV.Padding = new System.Windows.Forms.Padding(3);
            this.PCMtoWAV.Size = new System.Drawing.Size(619, 239);
            this.PCMtoWAV.TabIndex = 0;
            this.PCMtoWAV.Text = "PCM Row to WAV";
            this.PCMtoWAV.UseVisualStyleBackColor = true;
            // 
            // WAVtoPCM
            // 
            this.WAVtoPCM.Controls.Add(this.panel3);
            this.WAVtoPCM.Location = new System.Drawing.Point(4, 22);
            this.WAVtoPCM.Name = "WAVtoPCM";
            this.WAVtoPCM.Padding = new System.Windows.Forms.Padding(3);
            this.WAVtoPCM.Size = new System.Drawing.Size(619, 239);
            this.WAVtoPCM.TabIndex = 1;
            this.WAVtoPCM.Text = "WAV to PCM Row";
            this.WAVtoPCM.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.ExportChannel_textbox);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.ExportBitRate_TextBox);
            this.panel3.Controls.Add(this.ExportSamplingRate_textbox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.RunConvert2_Button);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.ConvertFile2_Label);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.FileUpload2_Label);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 225);
            this.panel3.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(401, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 12);
            this.label11.TabIndex = 37;
            this.label11.Text = "&&";
            // 
            // ExportChannel_textbox
            // 
            this.ExportChannel_textbox.Location = new System.Drawing.Point(513, 179);
            this.ExportChannel_textbox.Name = "ExportChannel_textbox";
            this.ExportChannel_textbox.ReadOnly = true;
            this.ExportChannel_textbox.Size = new System.Drawing.Size(60, 21);
            this.ExportChannel_textbox.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(420, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 12);
            this.label10.TabIndex = 35;
            this.label10.Text = "Channel Type";
            // 
            // ExportBitRate_TextBox
            // 
            this.ExportBitRate_TextBox.Location = new System.Drawing.Point(157, 179);
            this.ExportBitRate_TextBox.Name = "ExportBitRate_TextBox";
            this.ExportBitRate_TextBox.ReadOnly = true;
            this.ExportBitRate_TextBox.Size = new System.Drawing.Size(60, 21);
            this.ExportBitRate_TextBox.TabIndex = 34;
            // 
            // ExportSamplingRate_textbox
            // 
            this.ExportSamplingRate_textbox.Location = new System.Drawing.Point(335, 179);
            this.ExportSamplingRate_textbox.Name = "ExportSamplingRate_textbox";
            this.ExportSamplingRate_textbox.ReadOnly = true;
            this.ExportSamplingRate_textbox.Size = new System.Drawing.Size(60, 21);
            this.ExportSamplingRate_textbox.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 12);
            this.label6.TabIndex = 32;
            this.label6.Text = "&&";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 12);
            this.label7.TabIndex = 31;
            this.label7.Text = "Sampling Rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 12);
            this.label8.TabIndex = 30;
            this.label8.Text = "Bit";
            // 
            // RunConvert2_Button
            // 
            this.RunConvert2_Button.BackColor = System.Drawing.Color.LightCoral;
            this.RunConvert2_Button.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RunConvert2_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RunConvert2_Button.Location = new System.Drawing.Point(15, 168);
            this.RunConvert2_Button.Name = "RunConvert2_Button";
            this.RunConvert2_Button.Size = new System.Drawing.Size(99, 37);
            this.RunConvert2_Button.TabIndex = 13;
            this.RunConvert2_Button.Text = "Convert";
            this.RunConvert2_Button.UseVisualStyleBackColor = false;
            this.RunConvert2_Button.Click += new System.EventHandler(this.RunConvert2_Button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox2.Image = global::AudioConverter.Properties.Resources.pngtree_vector_down_arrow_icon_png_image_9272051;
            this.pictureBox2.InitialImage = global::AudioConverter.Properties.Resources.pngtree_vector_down_arrow_icon_png_image_9272051;
            this.pictureBox2.Location = new System.Drawing.Point(276, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.ExportFileName2_TextBox);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.ExportPath2_TextBox);
            this.panel4.Controls.Add(this.ExportPath2_Button);
            this.panel4.Location = new System.Drawing.Point(12, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(580, 44);
            this.panel4.TabIndex = 11;
            // 
            // ExportFileName2_TextBox
            // 
            this.ExportFileName2_TextBox.Location = new System.Drawing.Point(341, 11);
            this.ExportFileName2_TextBox.Name = "ExportFileName2_TextBox";
            this.ExportFileName2_TextBox.Size = new System.Drawing.Size(71, 21);
            this.ExportFileName2_TextBox.TabIndex = 5;
            // 
            // ExportPath2_TextBox
            // 
            this.ExportPath2_TextBox.Location = new System.Drawing.Point(19, 11);
            this.ExportPath2_TextBox.Name = "ExportPath2_TextBox";
            this.ExportPath2_TextBox.ReadOnly = true;
            this.ExportPath2_TextBox.Size = new System.Drawing.Size(294, 21);
            this.ExportPath2_TextBox.TabIndex = 4;
            // 
            // ExportPath2_Button
            // 
            this.ExportPath2_Button.Location = new System.Drawing.Point(460, 9);
            this.ExportPath2_Button.Name = "ExportPath2_Button";
            this.ExportPath2_Button.Size = new System.Drawing.Size(99, 23);
            this.ExportPath2_Button.TabIndex = 3;
            this.ExportPath2_Button.Text = "Export Path";
            this.ExportPath2_Button.UseVisualStyleBackColor = true;
            this.ExportPath2_Button.Click += new System.EventHandler(this.ExportPath2_Button_Click);
            // 
            // ConvertFile2_Label
            // 
            this.ConvertFile2_Label.AutoSize = true;
            this.ConvertFile2_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConvertFile2_Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ConvertFile2_Label.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertFile2_Label.Location = new System.Drawing.Point(12, 91);
            this.ConvertFile2_Label.Name = "ConvertFile2_Label";
            this.ConvertFile2_Label.Size = new System.Drawing.Size(127, 13);
            this.ConvertFile2_Label.TabIndex = 10;
            this.ConvertFile2_Label.Text = "PCM Row Format";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.FileUploadPath2_TextBox);
            this.panel5.Controls.Add(this.FileUpload2_Button);
            this.panel5.Location = new System.Drawing.Point(12, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(580, 46);
            this.panel5.TabIndex = 9;
            // 
            // FileUploadPath2_TextBox
            // 
            this.FileUploadPath2_TextBox.Location = new System.Drawing.Point(19, 11);
            this.FileUploadPath2_TextBox.Name = "FileUploadPath2_TextBox";
            this.FileUploadPath2_TextBox.ReadOnly = true;
            this.FileUploadPath2_TextBox.Size = new System.Drawing.Size(426, 21);
            this.FileUploadPath2_TextBox.TabIndex = 4;
            // 
            // FileUpload2_Button
            // 
            this.FileUpload2_Button.Location = new System.Drawing.Point(460, 9);
            this.FileUpload2_Button.Name = "FileUpload2_Button";
            this.FileUpload2_Button.Size = new System.Drawing.Size(99, 23);
            this.FileUpload2_Button.TabIndex = 3;
            this.FileUpload2_Button.Text = "File Upload";
            this.FileUpload2_Button.UseVisualStyleBackColor = true;
            this.FileUpload2_Button.Click += new System.EventHandler(this.FileUpload2_Button_Click);
            // 
            // FileUpload2_Label
            // 
            this.FileUpload2_Label.AutoSize = true;
            this.FileUpload2_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FileUpload2_Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FileUpload2_Label.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FileUpload2_Label.Location = new System.Drawing.Point(12, 5);
            this.FileUpload2_Label.Name = "FileUpload2_Label";
            this.FileUpload2_Label.Size = new System.Drawing.Size(38, 13);
            this.FileUpload2_Label.TabIndex = 5;
            this.FileUpload2_Label.Text = "WAV";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(418, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 12);
            this.label12.TabIndex = 15;
            this.label12.Text = ".pcm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(319, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 316);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.FileUpload_Panel.ResumeLayout(false);
            this.FileUpload_Panel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.PCMtoWAV.ResumeLayout(false);
            this.WAVtoPCM.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ExportPath_TextBox;
        private System.Windows.Forms.Button ExportPath_Button;
        private System.Windows.Forms.Label ConvertFile_Label;
        private System.Windows.Forms.Panel FileUpload_Panel;
        private System.Windows.Forms.TextBox FileUploadPath_TextBox;
        private System.Windows.Forms.Button FileUpload_Button;
        private System.Windows.Forms.Label FileUpload_Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RunConvert_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton StereoButton;
        private System.Windows.Forms.RadioButton MonoButton;
        private System.Windows.Forms.TextBox Bit;
        private System.Windows.Forms.TextBox SamplingRate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PCMtoWAV;
        private System.Windows.Forms.TabPage WAVtoPCM;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button RunConvert2_Button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox ExportPath2_TextBox;
        private System.Windows.Forms.Button ExportPath2_Button;
        private System.Windows.Forms.Label ConvertFile2_Label;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox FileUploadPath2_TextBox;
        private System.Windows.Forms.Button FileUpload2_Button;
        private System.Windows.Forms.Label FileUpload2_Label;
        private System.Windows.Forms.TextBox ExportFileName2_TextBox;
        private System.Windows.Forms.TextBox ExportFileName1_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ExportChannel_textbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ExportBitRate_TextBox;
        private System.Windows.Forms.TextBox ExportSamplingRate_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

