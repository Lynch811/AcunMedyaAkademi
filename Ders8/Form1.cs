using Ders8.Classes;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Ders8
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSerializeEt_Click(object sender, EventArgs e)
		{
			try
			{
				Employee employee = new Employee
				{
					Name = txtAd.Text,
					Phone = txtTelefon.Text,
					Department = txtDepertman.Text,
					DoB = dtpDogumTarihi.Value,
					Salary = Convert.ToInt32(txtMaas.Text)
				};

				XmlSerializer serializer = new XmlSerializer(typeof(Employee));
				FileStream fileStream = new FileStream("employee.xml", FileMode.Create, FileAccess.Write, FileShare.None);
				using (fileStream)
				{
					serializer.Serialize(fileStream, employee);
					txtAd.Text = "";
					txtDepertman.Text = "";
					txtMaas.Text = "";
					txtTelefon.Text = "";
					MessageBox.Show("Serileþtirme tamamlandi");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("Hata oluþtu : " + ex.Message.ToString());
			}
		}

		private void btnDeserializeEt_Click(object sender, EventArgs e)
		{
			try
			{
				Employee emp = new Employee();
				XmlSerializer xs = new XmlSerializer(typeof(Employee));
				FileStream fsin = new FileStream("employee.xml", FileMode.Open, FileAccess.Read, FileShare.None);
				using (fsin)
				{
					emp = (Employee)xs.Deserialize(fsin);
					txtAd.Text = emp.Name;
					txtTelefon.Text = emp.Phone;
					txtDepertman.Text = emp.Department;
					txtMaas.Text = Convert.ToString(emp.Salary);
					MessageBox.Show("Deserialization gerçeklþti:");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("Hata oluþtu : " + ex.Message.ToString());
			}
		}

		private void btnJsonOlustur_Click(object sender, EventArgs e)
		{
			Product product = new Product();
			product.Name = "Aplle 16";
			product.price = 150;
			product.expryDate= DateTime.Now;

			try
			{
				JsonSerializer jsonSerializer = new JsonSerializer();
				using (StreamWriter sr = new StreamWriter(@"C:\Users\talha\Documents\AcunMedyaAkademi\Ders8\product.json"))
				using (JsonWriter jsonWriter = new JsonTextWriter(sr))
				{
					jsonSerializer.Serialize(jsonWriter, product);
					MessageBox.Show("Serileþtirme tamamlandý json");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("Hata oluþtu : " + ex.Message.ToString());
			}
		}
	}
}
