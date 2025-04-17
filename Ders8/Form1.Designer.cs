namespace Ders8
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
			lblTelefon = new Label();
			lblDepartman = new Label();
			lblDogumTarihi = new Label();
			lblMaas = new Label();
			txtAd = new TextBox();
			txtTelefon = new TextBox();
			txtDepertman = new TextBox();
			txtMaas = new TextBox();
			btnSerializeEt = new Button();
			btnDeserializeEt = new Button();
			dtpDogumTarihi = new DateTimePicker();
			btnJsonOlustur = new Button();
			btnJsonOku = new Button();
			SuspendLayout();
			// 
			// lblAd
			// 
			lblAd.AutoSize = true;
			lblAd.Location = new Point(45, 38);
			lblAd.Name = "lblAd";
			lblAd.Size = new Size(25, 15);
			lblAd.TabIndex = 0;
			lblAd.Text = "Ad:";
			// 
			// lblTelefon
			// 
			lblTelefon.AutoSize = true;
			lblTelefon.Location = new Point(43, 76);
			lblTelefon.Name = "lblTelefon";
			lblTelefon.Size = new Size(49, 15);
			lblTelefon.TabIndex = 1;
			lblTelefon.Text = "Telefon:";
			// 
			// lblDepartman
			// 
			lblDepartman.AutoSize = true;
			lblDepartman.Location = new Point(45, 117);
			lblDepartman.Name = "lblDepartman";
			lblDepartman.Size = new Size(69, 15);
			lblDepartman.TabIndex = 2;
			lblDepartman.Text = "Departman:";
			// 
			// lblDogumTarihi
			// 
			lblDogumTarihi.AutoSize = true;
			lblDogumTarihi.Location = new Point(45, 158);
			lblDogumTarihi.Name = "lblDogumTarihi";
			lblDogumTarihi.Size = new Size(82, 15);
			lblDogumTarihi.TabIndex = 3;
			lblDogumTarihi.Text = "Doğum Tarihi:";
			// 
			// lblMaas
			// 
			lblMaas.AutoSize = true;
			lblMaas.Location = new Point(45, 205);
			lblMaas.Name = "lblMaas";
			lblMaas.Size = new Size(38, 15);
			lblMaas.TabIndex = 4;
			lblMaas.Text = "Maaş:";
			// 
			// txtAd
			// 
			txtAd.Location = new Point(168, 35);
			txtAd.Name = "txtAd";
			txtAd.Size = new Size(198, 23);
			txtAd.TabIndex = 5;
			// 
			// txtTelefon
			// 
			txtTelefon.Location = new Point(168, 73);
			txtTelefon.Name = "txtTelefon";
			txtTelefon.Size = new Size(198, 23);
			txtTelefon.TabIndex = 6;
			// 
			// txtDepertman
			// 
			txtDepertman.Location = new Point(168, 117);
			txtDepertman.Name = "txtDepertman";
			txtDepertman.Size = new Size(198, 23);
			txtDepertman.TabIndex = 7;
			// 
			// txtMaas
			// 
			txtMaas.Location = new Point(168, 202);
			txtMaas.Name = "txtMaas";
			txtMaas.Size = new Size(198, 23);
			txtMaas.TabIndex = 9;
			// 
			// btnSerializeEt
			// 
			btnSerializeEt.Location = new Point(91, 290);
			btnSerializeEt.Name = "btnSerializeEt";
			btnSerializeEt.Size = new Size(129, 48);
			btnSerializeEt.TabIndex = 10;
			btnSerializeEt.Text = "Serialize Et";
			btnSerializeEt.UseVisualStyleBackColor = true;
			btnSerializeEt.Click += btnSerializeEt_Click;
			// 
			// btnDeserializeEt
			// 
			btnDeserializeEt.Location = new Point(336, 290);
			btnDeserializeEt.Name = "btnDeserializeEt";
			btnDeserializeEt.Size = new Size(129, 48);
			btnDeserializeEt.TabIndex = 11;
			btnDeserializeEt.Text = "Desearialize Et";
			btnDeserializeEt.UseVisualStyleBackColor = true;
			btnDeserializeEt.Click += btnDeserializeEt_Click;
			// 
			// dtpDogumTarihi
			// 
			dtpDogumTarihi.Location = new Point(168, 158);
			dtpDogumTarihi.Name = "dtpDogumTarihi";
			dtpDogumTarihi.Size = new Size(200, 23);
			dtpDogumTarihi.TabIndex = 12;
			// 
			// btnJsonOlustur
			// 
			btnJsonOlustur.Location = new Point(91, 366);
			btnJsonOlustur.Name = "btnJsonOlustur";
			btnJsonOlustur.Size = new Size(129, 48);
			btnJsonOlustur.TabIndex = 13;
			btnJsonOlustur.Text = "Json Oluştur";
			btnJsonOlustur.UseVisualStyleBackColor = true;
			btnJsonOlustur.Click += btnJsonOlustur_Click;
			// 
			// btnJsonOku
			// 
			btnJsonOku.Location = new Point(336, 366);
			btnJsonOku.Name = "btnJsonOku";
			btnJsonOku.Size = new Size(129, 48);
			btnJsonOku.TabIndex = 14;
			btnJsonOku.Text = "Json Oku";
			btnJsonOku.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(948, 574);
			Controls.Add(btnJsonOku);
			Controls.Add(btnJsonOlustur);
			Controls.Add(dtpDogumTarihi);
			Controls.Add(btnDeserializeEt);
			Controls.Add(btnSerializeEt);
			Controls.Add(txtMaas);
			Controls.Add(txtDepertman);
			Controls.Add(txtTelefon);
			Controls.Add(txtAd);
			Controls.Add(lblMaas);
			Controls.Add(lblDogumTarihi);
			Controls.Add(lblDepartman);
			Controls.Add(lblTelefon);
			Controls.Add(lblAd);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblAd;
		private Label lblTelefon;
		private Label lblDepartman;
		private Label lblDogumTarihi;
		private Label lblMaas;
		private TextBox txtAd;
		private TextBox txtTelefon;
		private TextBox txtDepertman;
		private TextBox txtMaas;
		private Button btnSerializeEt;
		private Button btnDeserializeEt;
		private DateTimePicker dtpDogumTarihi;
		private Button btnJsonOlustur;
		private Button btnJsonOku;
	}
}
