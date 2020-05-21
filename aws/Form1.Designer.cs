namespace aws
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.img_source = new System.Windows.Forms.PictureBox();
            this.btn_source = new System.Windows.Forms.Button();
            this.btn_target = new System.Windows.Forms.Button();
            this.img_target = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_find_faces = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.RichTextBox();
            this.face_comparison = new System.Windows.Forms.TabControl();
            this.tab_faceComparison = new System.Windows.Forms.TabPage();
            this.tabAdultContent = new System.Windows.Forms.TabPage();
            this.btn_DetectAdultContent = new System.Windows.Forms.Button();
            this.txt_adultContent = new System.Windows.Forms.RichTextBox();
            this.btn_uploadAdultContent = new System.Windows.Forms.Button();
            this.img_adultContent = new System.Windows.Forms.PictureBox();
            this.tab_textToSpeech = new System.Windows.Forms.TabPage();
            this.btn_speak = new System.Windows.Forms.Button();
            this.txt_Text = new System.Windows.Forms.RichTextBox();
            this.tabTranslate = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_langTarget = new System.Windows.Forms.RichTextBox();
            this.txt_langSource = new System.Windows.Forms.RichTextBox();
            this.btn_translate = new System.Windows.Forms.Button();
            this.tabTxtInImg = new System.Windows.Forms.TabPage();
            this.btn_detectText = new System.Windows.Forms.Button();
            this.txtDetectedText = new System.Windows.Forms.RichTextBox();
            this.img_DetectTextImg = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_source)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_target)).BeginInit();
            this.face_comparison.SuspendLayout();
            this.tab_faceComparison.SuspendLayout();
            this.tabAdultContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_adultContent)).BeginInit();
            this.tab_textToSpeech.SuspendLayout();
            this.tabTranslate.SuspendLayout();
            this.tabTxtInImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_DetectTextImg)).BeginInit();
            this.SuspendLayout();
            // 
            // img_source
            // 
            this.img_source.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_source.Location = new System.Drawing.Point(34, 57);
            this.img_source.Name = "img_source";
            this.img_source.Size = new System.Drawing.Size(420, 501);
            this.img_source.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_source.TabIndex = 0;
            this.img_source.TabStop = false;
            // 
            // btn_source
            // 
            this.btn_source.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_source.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_source.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_source.Location = new System.Drawing.Point(34, 597);
            this.btn_source.Name = "btn_source";
            this.btn_source.Size = new System.Drawing.Size(80, 30);
            this.btn_source.TabIndex = 1;
            this.btn_source.Text = "Source";
            this.btn_source.UseVisualStyleBackColor = false;
            this.btn_source.Click += new System.EventHandler(this.btn_source_Click);
            // 
            // btn_target
            // 
            this.btn_target.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_target.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_target.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_target.Location = new System.Drawing.Point(498, 597);
            this.btn_target.Name = "btn_target";
            this.btn_target.Size = new System.Drawing.Size(80, 30);
            this.btn_target.TabIndex = 2;
            this.btn_target.Text = "Target";
            this.btn_target.UseVisualStyleBackColor = false;
            this.btn_target.Click += new System.EventHandler(this.btn_target_Click);
            // 
            // img_target
            // 
            this.img_target.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_target.Location = new System.Drawing.Point(498, 57);
            this.img_target.Name = "img_target";
            this.img_target.Size = new System.Drawing.Size(420, 501);
            this.img_target.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_target.TabIndex = 3;
            this.img_target.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(34, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 16);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Reference face";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(498, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 16);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Comparison faces";
            // 
            // btn_find_faces
            // 
            this.btn_find_faces.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_find_faces.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find_faces.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_find_faces.Location = new System.Drawing.Point(1127, 597);
            this.btn_find_faces.Name = "btn_find_faces";
            this.btn_find_faces.Size = new System.Drawing.Size(120, 30);
            this.btn_find_faces.TabIndex = 6;
            this.btn_find_faces.Text = "Find faces";
            this.btn_find_faces.UseVisualStyleBackColor = false;
            this.btn_find_faces.Click += new System.EventHandler(this.btn_find_faces_Click);
            // 
            // txt_result
            // 
            this.txt_result.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_result.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_result.Location = new System.Drawing.Point(953, 57);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(294, 501);
            this.txt_result.TabIndex = 7;
            this.txt_result.Text = "";
            // 
            // face_comparison
            // 
            this.face_comparison.Controls.Add(this.tab_faceComparison);
            this.face_comparison.Controls.Add(this.tabAdultContent);
            this.face_comparison.Controls.Add(this.tab_textToSpeech);
            this.face_comparison.Controls.Add(this.tabTranslate);
            this.face_comparison.Controls.Add(this.tabTxtInImg);
            this.face_comparison.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.face_comparison.Location = new System.Drawing.Point(21, 12);
            this.face_comparison.Name = "face_comparison";
            this.face_comparison.SelectedIndex = 0;
            this.face_comparison.Size = new System.Drawing.Size(1298, 688);
            this.face_comparison.TabIndex = 8;
            this.face_comparison.TabStop = false;
            // 
            // tab_faceComparison
            // 
            this.tab_faceComparison.Controls.Add(this.img_source);
            this.tab_faceComparison.Controls.Add(this.btn_find_faces);
            this.tab_faceComparison.Controls.Add(this.txt_result);
            this.tab_faceComparison.Controls.Add(this.btn_source);
            this.tab_faceComparison.Controls.Add(this.btn_target);
            this.tab_faceComparison.Controls.Add(this.textBox1);
            this.tab_faceComparison.Controls.Add(this.textBox2);
            this.tab_faceComparison.Controls.Add(this.img_target);
            this.tab_faceComparison.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_faceComparison.Location = new System.Drawing.Point(4, 24);
            this.tab_faceComparison.Name = "tab_faceComparison";
            this.tab_faceComparison.Padding = new System.Windows.Forms.Padding(3);
            this.tab_faceComparison.Size = new System.Drawing.Size(1290, 660);
            this.tab_faceComparison.TabIndex = 0;
            this.tab_faceComparison.Text = "Face Comparison";
            this.tab_faceComparison.UseVisualStyleBackColor = true;
            this.tab_faceComparison.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabAdultContent
            // 
            this.tabAdultContent.Controls.Add(this.btn_DetectAdultContent);
            this.tabAdultContent.Controls.Add(this.txt_adultContent);
            this.tabAdultContent.Controls.Add(this.btn_uploadAdultContent);
            this.tabAdultContent.Controls.Add(this.img_adultContent);
            this.tabAdultContent.Location = new System.Drawing.Point(4, 24);
            this.tabAdultContent.Name = "tabAdultContent";
            this.tabAdultContent.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdultContent.Size = new System.Drawing.Size(1290, 660);
            this.tabAdultContent.TabIndex = 1;
            this.tabAdultContent.Text = "Adult Content";
            this.tabAdultContent.UseVisualStyleBackColor = true;
            // 
            // btn_DetectAdultContent
            // 
            this.btn_DetectAdultContent.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_DetectAdultContent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DetectAdultContent.Location = new System.Drawing.Point(1099, 591);
            this.btn_DetectAdultContent.Name = "btn_DetectAdultContent";
            this.btn_DetectAdultContent.Size = new System.Drawing.Size(162, 30);
            this.btn_DetectAdultContent.TabIndex = 3;
            this.btn_DetectAdultContent.Text = "Detect Adult Content";
            this.btn_DetectAdultContent.UseVisualStyleBackColor = false;
            this.btn_DetectAdultContent.Click += new System.EventHandler(this.btn_DetectAdultContent_Click);
            // 
            // txt_adultContent
            // 
            this.txt_adultContent.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_adultContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_adultContent.Location = new System.Drawing.Point(954, 57);
            this.txt_adultContent.Name = "txt_adultContent";
            this.txt_adultContent.Size = new System.Drawing.Size(294, 501);
            this.txt_adultContent.TabIndex = 2;
            this.txt_adultContent.Text = "";
            // 
            // btn_uploadAdultContent
            // 
            this.btn_uploadAdultContent.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_uploadAdultContent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_uploadAdultContent.Location = new System.Drawing.Point(34, 591);
            this.btn_uploadAdultContent.Name = "btn_uploadAdultContent";
            this.btn_uploadAdultContent.Size = new System.Drawing.Size(80, 30);
            this.btn_uploadAdultContent.TabIndex = 1;
            this.btn_uploadAdultContent.Text = "Upload";
            this.btn_uploadAdultContent.UseVisualStyleBackColor = false;
            this.btn_uploadAdultContent.Click += new System.EventHandler(this.btn_uploadAdultContent_Click);
            // 
            // img_adultContent
            // 
            this.img_adultContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_adultContent.Location = new System.Drawing.Point(34, 57);
            this.img_adultContent.Name = "img_adultContent";
            this.img_adultContent.Size = new System.Drawing.Size(883, 501);
            this.img_adultContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_adultContent.TabIndex = 0;
            this.img_adultContent.TabStop = false;
            // 
            // tab_textToSpeech
            // 
            this.tab_textToSpeech.Controls.Add(this.btn_speak);
            this.tab_textToSpeech.Controls.Add(this.txt_Text);
            this.tab_textToSpeech.Location = new System.Drawing.Point(4, 24);
            this.tab_textToSpeech.Name = "tab_textToSpeech";
            this.tab_textToSpeech.Size = new System.Drawing.Size(1290, 660);
            this.tab_textToSpeech.TabIndex = 2;
            this.tab_textToSpeech.Text = "Text to Speech";
            this.tab_textToSpeech.UseVisualStyleBackColor = true;
            // 
            // btn_speak
            // 
            this.btn_speak.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_speak.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_speak.Location = new System.Drawing.Point(1127, 592);
            this.btn_speak.Name = "btn_speak";
            this.btn_speak.Size = new System.Drawing.Size(110, 30);
            this.btn_speak.TabIndex = 10;
            this.btn_speak.Text = "Speak";
            this.btn_speak.UseVisualStyleBackColor = false;
            this.btn_speak.Click += new System.EventHandler(this.btn_speak_Click);
            // 
            // txt_Text
            // 
            this.txt_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Text.Location = new System.Drawing.Point(34, 57);
            this.txt_Text.Name = "txt_Text";
            this.txt_Text.Size = new System.Drawing.Size(1203, 501);
            this.txt_Text.TabIndex = 9;
            this.txt_Text.Text = "";
            // 
            // tabTranslate
            // 
            this.tabTranslate.Controls.Add(this.label2);
            this.tabTranslate.Controls.Add(this.label1);
            this.tabTranslate.Controls.Add(this.txt_langTarget);
            this.tabTranslate.Controls.Add(this.txt_langSource);
            this.tabTranslate.Controls.Add(this.btn_translate);
            this.tabTranslate.Location = new System.Drawing.Point(4, 24);
            this.tabTranslate.Name = "tabTranslate";
            this.tabTranslate.Size = new System.Drawing.Size(1290, 660);
            this.tabTranslate.TabIndex = 3;
            this.tabTranslate.Text = "Translate";
            this.tabTranslate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tiếng Việt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "English";
            // 
            // txt_langTarget
            // 
            this.txt_langTarget.Location = new System.Drawing.Point(675, 57);
            this.txt_langTarget.Name = "txt_langTarget";
            this.txt_langTarget.Size = new System.Drawing.Size(575, 268);
            this.txt_langTarget.TabIndex = 4;
            this.txt_langTarget.Text = "";
            // 
            // txt_langSource
            // 
            this.txt_langSource.Location = new System.Drawing.Point(34, 57);
            this.txt_langSource.Name = "txt_langSource";
            this.txt_langSource.Size = new System.Drawing.Size(575, 268);
            this.txt_langSource.TabIndex = 3;
            this.txt_langSource.Text = "";
            // 
            // btn_translate
            // 
            this.btn_translate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_translate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_translate.Location = new System.Drawing.Point(1137, 355);
            this.btn_translate.Name = "btn_translate";
            this.btn_translate.Size = new System.Drawing.Size(113, 30);
            this.btn_translate.TabIndex = 2;
            this.btn_translate.Text = "Dịch nghĩa";
            this.btn_translate.UseVisualStyleBackColor = false;
            this.btn_translate.Click += new System.EventHandler(this.btn_translate_Click);
            // 
            // tabTxtInImg
            // 
            this.tabTxtInImg.Controls.Add(this.button2);
            this.tabTxtInImg.Controls.Add(this.btn_detectText);
            this.tabTxtInImg.Controls.Add(this.txtDetectedText);
            this.tabTxtInImg.Controls.Add(this.img_DetectTextImg);
            this.tabTxtInImg.Location = new System.Drawing.Point(4, 24);
            this.tabTxtInImg.Name = "tabTxtInImg";
            this.tabTxtInImg.Size = new System.Drawing.Size(1290, 660);
            this.tabTxtInImg.TabIndex = 4;
            this.tabTxtInImg.Text = "Text in image";
            this.tabTxtInImg.UseVisualStyleBackColor = true;
            // 
            // btn_detectText
            // 
            this.btn_detectText.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_detectText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_detectText.Location = new System.Drawing.Point(1073, 601);
            this.btn_detectText.Name = "btn_detectText";
            this.btn_detectText.Size = new System.Drawing.Size(178, 30);
            this.btn_detectText.TabIndex = 6;
            this.btn_detectText.Text = "Detect Text in Image";
            this.btn_detectText.UseVisualStyleBackColor = false;
            this.btn_detectText.Click += new System.EventHandler(this.btn_detectText_Click);
            // 
            // txtDetectedText
            // 
            this.txtDetectedText.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDetectedText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetectedText.Location = new System.Drawing.Point(957, 51);
            this.txtDetectedText.Name = "txtDetectedText";
            this.txtDetectedText.Size = new System.Drawing.Size(294, 501);
            this.txtDetectedText.TabIndex = 5;
            this.txtDetectedText.Text = "";
            // 
            // img_DetectTextImg
            // 
            this.img_DetectTextImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_DetectTextImg.Location = new System.Drawing.Point(51, 51);
            this.img_DetectTextImg.Name = "img_DetectTextImg";
            this.img_DetectTextImg.Size = new System.Drawing.Size(883, 501);
            this.img_DetectTextImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_DetectTextImg.TabIndex = 4;
            this.img_DetectTextImg.TabStop = false;
            this.img_DetectTextImg.Click += new System.EventHandler(this.img_DetectTextImg_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(51, 601);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Upload";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.face_comparison);
            this.Name = "Form1";
            this.Text = "AWS Application";
            ((System.ComponentModel.ISupportInitialize)(this.img_source)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_target)).EndInit();
            this.face_comparison.ResumeLayout(false);
            this.tab_faceComparison.ResumeLayout(false);
            this.tab_faceComparison.PerformLayout();
            this.tabAdultContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_adultContent)).EndInit();
            this.tab_textToSpeech.ResumeLayout(false);
            this.tabTranslate.ResumeLayout(false);
            this.tabTranslate.PerformLayout();
            this.tabTxtInImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_DetectTextImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_source;
        private System.Windows.Forms.Button btn_source;
        private System.Windows.Forms.Button btn_target;
        private System.Windows.Forms.PictureBox img_target;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_find_faces;
        private System.Windows.Forms.RichTextBox txt_result;
        private System.Windows.Forms.TabControl face_comparison;
        private System.Windows.Forms.TabPage tab_faceComparison;
        private System.Windows.Forms.TabPage tabAdultContent;
        private System.Windows.Forms.PictureBox img_adultContent;
        private System.Windows.Forms.Button btn_DetectAdultContent;
        private System.Windows.Forms.RichTextBox txt_adultContent;
        private System.Windows.Forms.Button btn_uploadAdultContent;
        private System.Windows.Forms.TabPage tab_textToSpeech;
        private System.Windows.Forms.Button btn_speak;
        private System.Windows.Forms.RichTextBox txt_Text;
        private System.Windows.Forms.TabPage tabTranslate;
        private System.Windows.Forms.RichTextBox txt_langSource;
        private System.Windows.Forms.Button btn_translate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_langTarget;
        private System.Windows.Forms.TabPage tabTxtInImg;
        private System.Windows.Forms.Button btn_detectText;
        private System.Windows.Forms.RichTextBox txtDetectedText;
        private System.Windows.Forms.PictureBox img_DetectTextImg;
        private System.Windows.Forms.Button button2;
    }
}

