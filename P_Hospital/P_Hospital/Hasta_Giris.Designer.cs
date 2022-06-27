namespace P_Hospital
{
    partial class Hasta_Giris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hasta_Giris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskdtc = new System.Windows.Forms.MaskedTextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.linkuye = new System.Windows.Forms.LinkLabel();
            this.btngiris = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnsonraki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // mskdtc
            // 
            this.mskdtc.BackColor = System.Drawing.Color.White;
            this.mskdtc.Location = new System.Drawing.Point(117, 56);
            this.mskdtc.Mask = "00000000000";
            this.mskdtc.Name = "mskdtc";
            this.mskdtc.Size = new System.Drawing.Size(100, 23);
            this.mskdtc.TabIndex = 3;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(117, 85);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(100, 23);
            this.txtsifre.TabIndex = 4;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // linkuye
            // 
            this.linkuye.AutoSize = true;
            this.linkuye.Location = new System.Drawing.Point(172, 191);
            this.linkuye.Name = "linkuye";
            this.linkuye.Size = new System.Drawing.Size(45, 15);
            this.linkuye.TabIndex = 5;
            this.linkuye.TabStop = true;
            this.linkuye.Text = "Üye Ol";
            this.linkuye.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkuye_LinkClicked);
            // 
            // btngiris
            // 
            this.btngiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btngiris.ImageKey = "key.png";
            this.btngiris.ImageList = this.ımageList1;
            this.btngiris.Location = new System.Drawing.Point(61, 114);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(75, 74);
            this.btngiris.TabIndex = 6;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "key.png");
            this.ımageList1.Images.SetKeyName(1, "share.png");
            // 
            // btnsonraki
            // 
            this.btnsonraki.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsonraki.ImageKey = "share.png";
            this.btnsonraki.ImageList = this.ımageList1;
            this.btnsonraki.Location = new System.Drawing.Point(142, 114);
            this.btnsonraki.Name = "btnsonraki";
            this.btnsonraki.Size = new System.Drawing.Size(75, 74);
            this.btnsonraki.TabIndex = 7;
            this.btnsonraki.Text = "Sonraki";
            this.btnsonraki.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsonraki.UseVisualStyleBackColor = true;
            this.btnsonraki.Click += new System.EventHandler(this.btnsonraki_Click);
            // 
            // Hasta_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(222, 209);
            this.Controls.Add(this.btnsonraki);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.linkuye);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.mskdtc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Hasta_Giris";
            this.Text = "Hasta Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskdtc;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.LinkLabel linkuye;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnsonraki;
    }
}