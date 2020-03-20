/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				BİLİŞİM SİSTEMLERİ  MÜHENDİSLİĞİ BÖLÜMÜ
**				NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI: 1
**				ÖĞRENCİ ADI: YAYA USMAN ADAIZA
**				ÖĞRENCİ NUMARASI: B181200557
**              DERSİN ALINDIĞI GRUP: A
****************************************************************************/
namespace Matrix3X3
{
    partial class Determinant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Determinant));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.EqualBtn = new System.Windows.Forms.Button();
            this.Det = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.A33 = new System.Windows.Forms.TextBox();
            this.A32 = new System.Windows.Forms.TextBox();
            this.A31 = new System.Windows.Forms.TextBox();
            this.A12 = new System.Windows.Forms.TextBox();
            this.A23 = new System.Windows.Forms.TextBox();
            this.A22 = new System.Windows.Forms.TextBox();
            this.A11 = new System.Windows.Forms.TextBox();
            this.A13 = new System.Windows.Forms.TextBox();
            this.A21 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(12, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(2, 120);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // EqualBtn
            // 
            this.EqualBtn.Location = new System.Drawing.Point(226, 121);
            this.EqualBtn.Name = "EqualBtn";
            this.EqualBtn.Size = new System.Drawing.Size(53, 34);
            this.EqualBtn.TabIndex = 11;
            this.EqualBtn.Text = "=";
            this.EqualBtn.UseVisualStyleBackColor = true;
            this.EqualBtn.Click += new System.EventHandler(this.EqualBtn_Click);
            // 
            // Det
            // 
            this.Det.Location = new System.Drawing.Point(300, 121);
            this.Det.Multiline = true;
            this.Det.Name = "Det";
            this.Det.ReadOnly = true;
            this.Det.Size = new System.Drawing.Size(82, 34);
            this.Det.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(206, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2, 120);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // A33
            // 
            this.A33.Location = new System.Drawing.Point(144, 149);
            this.A33.Multiline = true;
            this.A33.Name = "A33";
            this.A33.Size = new System.Drawing.Size(56, 34);
            this.A33.TabIndex = 21;
            // 
            // A32
            // 
            this.A32.Location = new System.Drawing.Point(82, 149);
            this.A32.Multiline = true;
            this.A32.Name = "A32";
            this.A32.Size = new System.Drawing.Size(56, 34);
            this.A32.TabIndex = 20;
            // 
            // A31
            // 
            this.A31.Location = new System.Drawing.Point(20, 149);
            this.A31.Multiline = true;
            this.A31.Name = "A31";
            this.A31.Size = new System.Drawing.Size(56, 34);
            this.A31.TabIndex = 19;
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(82, 69);
            this.A12.Multiline = true;
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(56, 34);
            this.A12.TabIndex = 18;
            // 
            // A23
            // 
            this.A23.Location = new System.Drawing.Point(144, 109);
            this.A23.Multiline = true;
            this.A23.Name = "A23";
            this.A23.Size = new System.Drawing.Size(56, 34);
            this.A23.TabIndex = 16;
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(82, 109);
            this.A22.Multiline = true;
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(56, 34);
            this.A22.TabIndex = 17;
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(20, 69);
            this.A11.Multiline = true;
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(56, 34);
            this.A11.TabIndex = 15;
            // 
            // A13
            // 
            this.A13.Location = new System.Drawing.Point(144, 69);
            this.A13.Multiline = true;
            this.A13.Name = "A13";
            this.A13.Size = new System.Drawing.Size(56, 34);
            this.A13.TabIndex = 14;
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(20, 109);
            this.A21.Multiline = true;
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(56, 34);
            this.A21.TabIndex = 13;
            // 
            // Determinant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 245);
            this.Controls.Add(this.A33);
            this.Controls.Add(this.A32);
            this.Controls.Add(this.A31);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A23);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A13);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.Det);
            this.Controls.Add(this.EqualBtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Determinant";
            this.Text = "DETERMINANT";
            this.Load += new System.EventHandler(this.Determinant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button EqualBtn;
        private System.Windows.Forms.TextBox Det;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox A33;
        private System.Windows.Forms.TextBox A32;
        private System.Windows.Forms.TextBox A31;
        private System.Windows.Forms.TextBox A12;
        private System.Windows.Forms.TextBox A23;
        private System.Windows.Forms.TextBox A22;
        private System.Windows.Forms.TextBox A11;
        private System.Windows.Forms.TextBox A13;
        private System.Windows.Forms.TextBox A21;
    }
}