namespace Ders7
{
	public partial class Form1 : Form
	{
		string ad;
		string soyad;
		string gozRengi;
		string kulak;
		string burun;
		public Form1()
		{
			InitializeComponent();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			ad = txtAd.Text;
			soyad = txtSoyad.Text;
			lblSonuc.Text = "Randevu alan ki�inin: \nad�: " + ad + " \nSoyad� :"+soyad+ " \nG�z Rengi:" + gozRengi+ " \nKulak �ekli: " + kulak
				+ "\nBurun �ekli: " + burun;

		}

		private void cmbGozRengi_SelectedIndexChanged(object sender, EventArgs e)
		{
			gozRengi = cmbGozRengi.SelectedItem.ToString();
			
		}

		private void cmbKulak_SelectedIndexChanged(object sender, EventArgs e)
		{
			kulak = cmbKulak.SelectedItem.ToString();
		}

		private void cmbBurun_SelectedIndexChanged(object sender, EventArgs e)
		{
			burun = cmbBurun.SelectedItem.ToString();
		}
	}
}
