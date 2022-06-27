namespace P_Hospital
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.btnhasgiris = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btndokgiris = new System.Windows.Forms.Button();
            this.btnsekgiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhasgiris
            // 
            this.btnhasgiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnhasgiris.ImageKey = "patient.png";
            this.btnhasgiris.ImageList = this.ımageList1;
            this.btnhasgiris.Location = new System.Drawing.Point(16, 89);
            this.btnhasgiris.Name = "btnhasgiris";
            this.btnhasgiris.Size = new System.Drawing.Size(112, 98);
            this.btnhasgiris.TabIndex = 0;
            this.btnhasgiris.Text = "Hasta";
            this.btnhasgiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnhasgiris.UseVisualStyleBackColor = true;
            this.btnhasgiris.Click += new System.EventHandler(this.btnhasgiris_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "doctor.png");
            this.ımageList1.Images.SetKeyName(1, "patient.png");
            this.ımageList1.Images.SetKeyName(2, "reception.png");
            // 
            // btndokgiris
            // 
            this.btndokgiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndokgiris.ImageKey = "doctor.png";
            this.btndokgiris.ImageList = this.ımageList1;
            this.btndokgiris.Location = new System.Drawing.Point(134, 89);
            this.btndokgiris.Name = "btndokgiris";
            this.btndokgiris.Size = new System.Drawing.Size(112, 98);
            this.btndokgiris.TabIndex = 1;
            this.btndokgiris.Text = "Doktor";
            this.btndokgiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndokgiris.UseVisualStyleBackColor = true;
            this.btndokgiris.Click += new System.EventHandler(this.btndokgiris_Click);
            // 
            // btnsekgiris
            // 
            this.btnsekgiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsekgiris.ImageKey = "reception.png";
            this.btnsekgiris.ImageList = this.ımageList1;
            this.btnsekgiris.Location = new System.Drawing.Point(252, 89);
            this.btnsekgiris.Name = "btnsekgiris";
            this.btnsekgiris.Size = new System.Drawing.Size(112, 98);
            this.btnsekgiris.TabIndex = 2;
            this.btnsekgiris.Text = "Sekreter";
            this.btnsekgiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsekgiris.UseVisualStyleBackColor = true;
            this.btnsekgiris.Click += new System.EventHandler(this.btnsekgiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "Star Hospital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(265, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(370, 193);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsekgiris);
            this.Controls.Add(this.btndokgiris);
            this.Controls.Add(this.btnhasgiris);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnaForm";
            this.Text = "STAR HOSPİTAL";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhasgiris;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btndokgiris;
        private System.Windows.Forms.Button btnsekgiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

