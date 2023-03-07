using Project.BLL.GenericRepository.ConcRep;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			_empProfileRep = new EmployeeProfileRepository();


		}
		EmployeeProfileRepository _empProfileRep;

		private void btnGiris_Click(object sender, EventArgs e)
		{
			if (_empProfileRep.Any(x => x.UserName == txtKullaniciAdi.Text && x.Password == txtSifre.Text))
			{
				MessageBox.Show("Hoş Geldiniz");
				Form2 fr2 = new Form2();	
				fr2.ShowDialog();
				
			}
			else
			{
				MessageBox.Show("Şifre Veya Kullanıcı Adı Yanlış");
			}
			





		}
	}
}
