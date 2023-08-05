namespace Proje___Bilgi_Yarışması_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            BtnA = new Button();
            BtnB = new Button();
            BtnC = new Button();
            BtnD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LblSoruNo = new Label();
            LblDogru = new Label();
            LblYanlis = new Label();
            BtnSonraki = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FloralWhite;
            richTextBox1.Location = new Point(2, 1);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(572, 213);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // BtnA
            // 
            BtnA.Location = new Point(2, 222);
            BtnA.Name = "BtnA";
            BtnA.Size = new Size(283, 44);
            BtnA.TabIndex = 1;
            BtnA.Text = "A";
            BtnA.UseVisualStyleBackColor = true;
            BtnA.Click += BtnA_Click;
            // 
            // BtnB
            // 
            BtnB.Location = new Point(291, 222);
            BtnB.Name = "BtnB";
            BtnB.Size = new Size(283, 44);
            BtnB.TabIndex = 5;
            BtnB.Text = "B";
            BtnB.UseVisualStyleBackColor = true;
            BtnB.Click += BtnB_Click;
            // 
            // BtnC
            // 
            BtnC.Location = new Point(2, 272);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(283, 44);
            BtnC.TabIndex = 6;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = true;
            BtnC.Click += BtnC_Click;
            // 
            // BtnD
            // 
            BtnD.Location = new Point(291, 272);
            BtnD.Name = "BtnD";
            BtnD.Size = new Size(283, 44);
            BtnD.TabIndex = 7;
            BtnD.Text = "D";
            BtnD.UseVisualStyleBackColor = true;
            BtnD.Click += BtnD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(594, 23);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 8;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(613, 61);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 9;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(618, 101);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 10;
            label3.Text = "Yanlış:";
            // 
            // LblSoruNo
            // 
            LblSoruNo.AutoSize = true;
            LblSoruNo.Location = new Point(696, 23);
            LblSoruNo.Name = "LblSoruNo";
            LblSoruNo.Size = new Size(24, 28);
            LblSoruNo.TabIndex = 11;
            LblSoruNo.Text = "0";
            // 
            // LblDogru
            // 
            LblDogru.AutoSize = true;
            LblDogru.Location = new Point(696, 61);
            LblDogru.Name = "LblDogru";
            LblDogru.Size = new Size(24, 28);
            LblDogru.TabIndex = 12;
            LblDogru.Text = "0";
            // 
            // LblYanlis
            // 
            LblYanlis.AutoSize = true;
            LblYanlis.Location = new Point(696, 101);
            LblYanlis.Name = "LblYanlis";
            LblYanlis.Size = new Size(24, 28);
            LblYanlis.TabIndex = 13;
            LblYanlis.Text = "0";
            // 
            // BtnSonraki
            // 
            BtnSonraki.Location = new Point(580, 152);
            BtnSonraki.Name = "BtnSonraki";
            BtnSonraki.Size = new Size(199, 44);
            BtnSonraki.TabIndex = 14;
            BtnSonraki.Text = "Sonraki";
            BtnSonraki.UseVisualStyleBackColor = true;
            BtnSonraki.Click += BtnSonraki_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(580, 222);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(705, 222);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(497, 334);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 17;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(498, 362);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 18;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(818, 318);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BtnSonraki);
            Controls.Add(LblYanlis);
            Controls.Add(LblDogru);
            Controls.Add(LblSoruNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnD);
            Controls.Add(BtnC);
            Controls.Add(BtnB);
            Controls.Add(BtnA);
            Controls.Add(richTextBox1);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button BtnA;
        private Button BtnB;
        private Button BtnC;
        private Button BtnD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LblSoruNo;
        private Label LblDogru;
        private Label LblYanlis;
        private Button BtnSonraki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}