namespace YurtOtomasyonu2.Odalar
{
    partial class OdaForm
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxKisiler = new System.Windows.Forms.TextBox();
            this.tbxKisiSayi = new System.Windows.Forms.TextBox();
            this.tbxOdaNo = new System.Windows.Forms.TextBox();
            this.dgwOda = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxKalan = new System.Windows.Forms.TextBox();
            this.cbxTemizMi = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(413, 365);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(130, 52);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kişiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kisi Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Oda No:";
            // 
            // tbxKisiler
            // 
            this.tbxKisiler.Location = new System.Drawing.Point(185, 350);
            this.tbxKisiler.Name = "tbxKisiler";
            this.tbxKisiler.Size = new System.Drawing.Size(100, 22);
            this.tbxKisiler.TabIndex = 11;
            // 
            // tbxKisiSayi
            // 
            this.tbxKisiSayi.Location = new System.Drawing.Point(185, 306);
            this.tbxKisiSayi.Name = "tbxKisiSayi";
            this.tbxKisiSayi.Size = new System.Drawing.Size(100, 22);
            this.tbxKisiSayi.TabIndex = 10;
            // 
            // tbxOdaNo
            // 
            this.tbxOdaNo.Location = new System.Drawing.Point(185, 266);
            this.tbxOdaNo.Name = "tbxOdaNo";
            this.tbxOdaNo.Size = new System.Drawing.Size(100, 22);
            this.tbxOdaNo.TabIndex = 9;
            // 
            // dgwOda
            // 
            this.dgwOda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOda.Location = new System.Drawing.Point(12, 56);
            this.dgwOda.Name = "dgwOda";
            this.dgwOda.RowTemplate.Height = 24;
            this.dgwOda.Size = new System.Drawing.Size(776, 145);
            this.dgwOda.TabIndex = 8;
            this.dgwOda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOda_CellClick);
            this.dgwOda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOda_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kalan Kişi Sayısı";
            // 
            // tbxKalan
            // 
            this.tbxKalan.Location = new System.Drawing.Point(185, 395);
            this.tbxKalan.Name = "tbxKalan";
            this.tbxKalan.Size = new System.Drawing.Size(100, 22);
            this.tbxKalan.TabIndex = 16;
            // 
            // cbxTemizMi
            // 
            this.cbxTemizMi.AutoSize = true;
            this.cbxTemizMi.BackColor = System.Drawing.Color.Transparent;
            this.cbxTemizMi.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxTemizMi.Location = new System.Drawing.Point(413, 254);
            this.cbxTemizMi.Name = "cbxTemizMi";
            this.cbxTemizMi.Size = new System.Drawing.Size(197, 34);
            this.cbxTemizMi.TabIndex = 18;
            this.cbxTemizMi.Text = "Oda Temizlendi Mi";
            this.cbxTemizMi.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(178)))));
            this.button1.Image = global::YurtOtomasyonu2.Properties.Resources.minimize;
            this.button1.Location = new System.Drawing.Point(664, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 38);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(178)))));
            this.button2.Image = global::YurtOtomasyonu2.Properties.Resources.close;
            this.button2.Location = new System.Drawing.Point(729, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 38);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(178)))));
            this.btnGeri.Image = global::YurtOtomasyonu2.Properties.Resources.back;
            this.btnGeri.Location = new System.Drawing.Point(12, 1);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(79, 49);
            this.btnGeri.TabIndex = 21;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click_1);
            // 
            // OdaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YurtOtomasyonu2.Properties.Resources.arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 451);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxTemizMi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxKalan);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxKisiler);
            this.Controls.Add(this.tbxKisiSayi);
            this.Controls.Add(this.tbxOdaNo);
            this.Controls.Add(this.dgwOda);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OdaForm";
            this.Text = "OdaForm";
            this.Load += new System.EventHandler(this.OdaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxKisiler;
        private System.Windows.Forms.TextBox tbxKisiSayi;
        private System.Windows.Forms.TextBox tbxOdaNo;
        private System.Windows.Forms.DataGridView dgwOda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxKalan;
        private System.Windows.Forms.CheckBox cbxTemizMi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGeri;
    }
}