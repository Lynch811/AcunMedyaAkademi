namespace Ders7
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
			lblAd = new Label();
			lblSoyad = new Label();
			lblGozRengi = new Label();
			lblKulak = new Label();
			lblBurun = new Label();
			cmbGozRengi = new ComboBox();
			cmbKulak = new ComboBox();
			txtAd = new TextBox();
			txtSoyad = new TextBox();
			cmbBurun = new ComboBox();
			btnKaydet = new Button();
			lblSonuc = new Label();
			SuspendLayout();
			// 
			// lblAd
			// 
			lblAd.AutoSize = true;
			lblAd.Location = new Point(303, 97);
			lblAd.Name = "lblAd";
			lblAd.Size = new Size(43, 15);
			lblAd.TabIndex = 0;
			lblAd.Text = "Adınız:";
			// 
			// lblSoyad
			// 
			lblSoyad.AutoSize = true;
			lblSoyad.Location = new Point(303, 136);
			lblSoyad.Name = "lblSoyad";
			lblSoyad.Size = new Size(60, 15);
			lblSoyad.TabIndex = 1;
			lblSoyad.Text = "Soyadınız:";
			// 
			// lblGozRengi
			// 
			lblGozRengi.AutoSize = true;
			lblGozRengi.Location = new Point(303, 187);
			lblGozRengi.Name = "lblGozRengi";
			lblGozRengi.Size = new Size(63, 15);
			lblGozRengi.TabIndex = 1;
			lblGozRengi.Text = "Göz Rengi:";
			// 
			// lblKulak
			// 
			lblKulak.AutoSize = true;
			lblKulak.Location = new Point(303, 256);
			lblKulak.Name = "lblKulak";
			lblKulak.Size = new Size(36, 15);
			lblKulak.TabIndex = 1;
			lblKulak.Text = "Kulak";
			// 
			// lblBurun
			// 
			lblBurun.AutoSize = true;
			lblBurun.Location = new Point(303, 318);
			lblBurun.Name = "lblBurun";
			lblBurun.Size = new Size(39, 15);
			lblBurun.TabIndex = 1;
			lblBurun.Text = "Burun";
			// 
			// cmbGozRengi
			// 
			cmbGozRengi.FormattingEnabled = true;
			cmbGozRengi.Items.AddRange(new object[] { "Seçiniz", "Kahverengi", "Mavi", "Yeşil", "Ela" });
			cmbGozRengi.Location = new Point(422, 187);
			cmbGozRengi.Name = "cmbGozRengi";
			cmbGozRengi.Size = new Size(208, 23);
			cmbGozRengi.TabIndex = 2;
			cmbGozRengi.SelectedIndexChanged += cmbGozRengi_SelectedIndexChanged;
			// 
			// cmbKulak
			// 
			cmbKulak.FormattingEnabled = true;
			cmbKulak.Items.AddRange(new object[] { "Kepçe", "Normal" });
			cmbKulak.Location = new Point(422, 248);
			cmbKulak.Name = "cmbKulak";
			cmbKulak.Size = new Size(208, 23);
			cmbKulak.TabIndex = 2;
			cmbKulak.SelectedIndexChanged += cmbKulak_SelectedIndexChanged;
			// 
			// txtAd
			// 
			txtAd.Location = new Point(422, 98);
			txtAd.Name = "txtAd";
			txtAd.Size = new Size(208, 23);
			txtAd.TabIndex = 3;
			// 
			// txtSoyad
			// 
			txtSoyad.Location = new Point(422, 136);
			txtSoyad.Name = "txtSoyad";
			txtSoyad.Size = new Size(208, 23);
			txtSoyad.TabIndex = 3;
			// 
			// cmbBurun
			// 
			cmbBurun.FormattingEnabled = true;
			cmbBurun.Items.AddRange(new object[] { "Normal", "Estetikli" });
			cmbBurun.Location = new Point(422, 310);
			cmbBurun.Name = "cmbBurun";
			cmbBurun.Size = new Size(208, 23);
			cmbBurun.TabIndex = 2;
			cmbBurun.SelectedIndexChanged += cmbBurun_SelectedIndexChanged;
			// 
			// btnKaydet
			// 
			btnKaydet.Location = new Point(393, 394);
			btnKaydet.Name = "btnKaydet";
			btnKaydet.Size = new Size(203, 77);
			btnKaydet.TabIndex = 4;
			btnKaydet.Text = "Kaydet";
			btnKaydet.UseVisualStyleBackColor = true;
			btnKaydet.Click += btnKaydet_Click;
			// 
			// lblSonuc
			// 
			lblSonuc.AutoSize = true;
			lblSonuc.Location = new Point(136, 512);
			lblSonuc.Name = "lblSonuc";
			lblSonuc.Size = new Size(43, 15);
			lblSonuc.TabIndex = 1;
			lblSonuc.Text = "Sonuç:";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1307, 687);
			Controls.Add(btnKaydet);
			Controls.Add(txtSoyad);
			Controls.Add(txtAd);
			Controls.Add(cmbBurun);
			Controls.Add(cmbKulak);
			Controls.Add(cmbGozRengi);
			Controls.Add(lblSonuc);
			Controls.Add(lblBurun);
			Controls.Add(lblKulak);
			Controls.Add(lblGozRengi);
			Controls.Add(lblSoyad);
			Controls.Add(lblAd);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblAd;
		private Label lblSoyad;
		private Label lblGozRengi;
		private Label lblKulak;
		private Label lblBurun;
		private ComboBox cmbGozRengi;
		private ComboBox cmbKulak;
		private TextBox txtAd;
		private TextBox txtSoyad;
		private ComboBox cmbBurun;
		private Button btnKaydet;
		private Label lblSonuc;
	}
}
