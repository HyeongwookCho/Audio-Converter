
namespace PCMRow_WavConverter
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
            this.ExportPath_TextBox = new System.Windows.Forms.TextBox();
            this.ExportPath_Button = new System.Windows.Forms.Button();
            this.ConvertFile_Label = new System.Windows.Forms.Label();
            this.FileUpload_Panel = new System.Windows.Forms.Panel();
            this.StereoButton = new System.Windows.Forms.RadioButton();
            this.MonoButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FileUploadPath_TextBox = new System.Windows.Forms.TextBox();
            this.FileUpload_Button = new System.Windows.Forms.Button();
            this.FileUpload_Label = new System.Windows.Forms.Label();
            this.SamplingRate = new System.Windows.Forms.TextBox();
            this.Bit = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.FileUpload_Panel.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(264, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lucis PCM to Wav Converter";
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
            this.panel1.Location = new System.Drawing.Point(11, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 225);
            this.panel1.TabIndex = 9;
            // 
            // RunConvert_Button
            // 
            this.RunConvert_Button.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RunConvert_Button.Location = new System.Drawing.Point(246, 181);
            this.RunConvert_Button.Name = "RunConvert_Button";
            this.RunConvert_Button.Size = new System.Drawing.Size(99, 37);
            this.RunConvert_Button.TabIndex = 13;
            this.RunConvert_Button.Text = "Convert";
            this.RunConvert_Button.UseVisualStyleBackColor = true;
            this.RunConvert_Button.Click += new System.EventHandler(this.RunConvert_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Image = global::PCMRow_WavConverter.Properties.Resources.pngtree_vector_down_arrow_icon_png_image_9272051;
            this.pictureBox1.InitialImage = global::PCMRow_WavConverter.Properties.Resources.pngtree_vector_down_arrow_icon_png_image_9272051;
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
            this.panel2.Controls.Add(this.ExportPath_TextBox);
            this.panel2.Controls.Add(this.ExportPath_Button);
            this.panel2.Location = new System.Drawing.Point(12, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 44);
            this.panel2.TabIndex = 11;
            // 
            // ExportPath_TextBox
            // 
            this.ExportPath_TextBox.Location = new System.Drawing.Point(19, 11);
            this.ExportPath_TextBox.Name = "ExportPath_TextBox";
            this.ExportPath_TextBox.ReadOnly = true;
            this.ExportPath_TextBox.Size = new System.Drawing.Size(426, 21);
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
            this.ConvertFile_Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ConvertFile_Label.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertFile_Label.Location = new System.Drawing.Point(12, 115);
            this.ConvertFile_Label.Name = "ConvertFile_Label";
            this.ConvertFile_Label.Size = new System.Drawing.Size(35, 13);
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
            // StereoButton
            // 
            this.StereoButton.AutoSize = true;
            this.StereoButton.Location = new System.Drawing.Point(325, 41);
            this.StereoButton.Name = "StereoButton";
            this.StereoButton.Size = new System.Drawing.Size(59, 16);
            this.StereoButton.TabIndex = 19;
            this.StereoButton.TabStop = true;
            this.StereoButton.Text = "Stereo";
            this.StereoButton.UseVisualStyleBackColor = true;
            // 
            // MonoButton
            // 
            this.MonoButton.AutoSize = true;
            this.MonoButton.Checked = true;
            this.MonoButton.Location = new System.Drawing.Point(390, 41);
            this.MonoButton.Name = "MonoButton";
            this.MonoButton.Size = new System.Drawing.Size(55, 16);
            this.MonoButton.TabIndex = 14;
            this.MonoButton.TabStop = true;
            this.MonoButton.Text = "Mono";
            this.MonoButton.UseVisualStyleBackColor = true;
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
            this.label2.Location = new System.Drawing.Point(72, 43);
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
            this.FileUpload_Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FileUpload_Label.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FileUpload_Label.Location = new System.Drawing.Point(12, 5);
            this.FileUpload_Label.Name = "FileUpload_Label";
            this.FileUpload_Label.Size = new System.Drawing.Size(113, 13);
            this.FileUpload_Label.TabIndex = 5;
            this.FileUpload_Label.Text = "PCM Row Format";
            // 
            // SamplingRate
            // 
            this.SamplingRate.Location = new System.Drawing.Point(255, 38);
            this.SamplingRate.Name = "SamplingRate";
            this.SamplingRate.Size = new System.Drawing.Size(60, 21);
            this.SamplingRate.TabIndex = 20;
            // 
            // Bit
            // 
            this.Bit.Location = new System.Drawing.Point(96, 39);
            this.Bit.Name = "Bit";
            this.Bit.Size = new System.Drawing.Size(60, 21);
            this.Bit.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 280);
            this.Controls.Add(this.panel1);
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
    }
}

