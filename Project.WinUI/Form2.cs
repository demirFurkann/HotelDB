using Project.BLL.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form2 : Form
    {
        CustomerRepository _customerRep;

        OrderRepository _orderRep;

        ExtraRepository _extraRep;

        RoomRepository _roomRep;

        RoomTypeRepository _roomTypeRep;
        public Form2()
        {
            InitializeComponent(); 
            _orderRep = new OrderRepository();
            _extraRep = new ExtraRepository();
            _customerRep = new CustomerRepository();
            _roomRep = new RoomRepository();
            _roomTypeRep = new RoomTypeRepository();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Room> orginal = _roomRep.GetAll();

            foreach (Room item in orginal)
            {
                cmbOda.Items.Add(item);
            }
			List<Extra> extra = _extraRep.GetAll();

			foreach (Extra item in  extra)
            {
                cmbYemek.Items.Add(item);
            }


		}
        Room _secilen;
        private void cmbOda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOda.SelectedIndex>-1)
            {
                _secilen = lstDoluOda.SelectedItem as Room; 
                lblOda.Text = (cmbOda.SelectedItem as Room).BilgiGoster();
            }
        }

		private void btnYemek_Click(object sender, EventArgs e)
		{
            
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
            Customer cst = new Customer();
            Order ord =new Order();

            cst.FirstName=txtIsim.Text;
            cst.LastName = txtSoyIsim.Text;
            _customerRep.Add(cst);

            
            ord.Rooms.Add(cmbOda.SelectedItem as Room);

            ord.Customer = cst;
			_orderRep.Add(ord);

			lstDoluOda.Items.Add(ord);



            

		}
	}
}
