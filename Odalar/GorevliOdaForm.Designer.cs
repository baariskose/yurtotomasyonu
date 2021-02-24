namespace YurtOtomasyonu2.Odalar
{
    partial class GorevliOdaForm
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
            this.liste = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdaTemizle = new System.Windows.Forms.Button();
            this.ListeTemiz = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // liste
            // 
            this.liste.FormattingEnabled = true;
            this.liste.ItemHeight = 16;
            this.liste.Location = new System.Drawing.Point(31, 95);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(190, 292);
            this.liste.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Temizlenecek Odalar:";
            // 
            // btnOdaTemizle
            // 
            this.btnOdaTemizle.Location = new System.Drawing.Point(564, 134);
            this.btnOdaTemizle.Name = "btnOdaTemizle";
            this.btnOdaTemizle.Size = new System.Drawing.Size(177, 110);
            this.btnOdaTemizle.TabIndex = 13;
            this.btnOdaTemizle.Text = "Odaları Temizle";
            this.btnOdaTemizle.UseVisualStyleBackColor = true;
            this.btnOdaTemizle.Click += new System.EventHandler(this.btnOdaTemizle_Click);
            // 
            // ListeTemiz
            // 
            this.ListeTemiz.FormattingEnabled = true;
            this.ListeTemiz.ItemHeight = 16;
            this.ListeTemiz.Location = new System.Drawing.Point(303, 95);
            this.ListeTemiz.Name = "ListeTemiz";
            this.ListeTemiz.Size = new System.Drawing.Size(190, 292);
            this.ListeTemiz.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(303, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Temiz Olanlar:";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(178)))));
            this.btnGeri.Image = global::YurtOtomasyonu2.Properties.Resources.back;
            this.btnGeri.Location = new System.Drawing.Point(564, 339);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(90, 48);
            this.btnGeri.TabIndex = 16;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(178)))));
            this.btnKapat.Image = global::YurtOtomasyonu2.Properties.Resources.close;
            this.btnKapat.Location = new System.Drawing.Point(727, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(61, 52);
            this.btnKapat.TabIndex = 18;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKucult
            // 
            this.btnKucult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(178)))));
            this.btnKucult.Image = global::YurtOtomasyonu2.Properties.Resources.minimize;
            this.btnKucult.Location = new System.Drawing.Point(660, 12);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(61, 52);
            this.btnKucult.TabIndex = 19;
            this.btnKucult.UseVisualStyleBackColor = false;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // GorevliOdaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YurtOtomasyonu2.Properties.Resources.arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKucult);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListeTemiz);
            this.Controls.Add(this.btnOdaTemizle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liste);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GorevliOdaForm";
            this.Text = "GorevliOdaForm";
            this.Load += new System.EventHandler(this.GorevliOdaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox liste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdaTemizle;
        private System.Windows.Forms.ListBox ListeTemiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKucult;
    }
}