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
	public partial class Form3 : Form
	{
		RoomRepository _roomRep;
		RoomTypeRepository _roomTypeRep;
		ExtraRepository _extraRep;
		public Form3()
		{
			InitializeComponent();
			_roomTypeRep = new RoomTypeRepository();
			_roomRep = new RoomRepository();
			_extraRep = new ExtraRepository();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Room r = new Room();

			r.RoomNo = txtRoomNo.Text;
			r.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
			lstRoom.Items.Add(r);
			_roomRep.Add(r);



		}
		Room _secilen;
		private void lstRoom_SelectedIndexChanged(object sender, EventArgs e)
		{

			if (lstRoom.SelectedIndex > -1)
			{
				_secilen = lstRoom.SelectedItem as Room;
				RoomType rt = new RoomType();
				rt.RoomTypeName = txtRoomTypeName.Text;
				rt.Rooms.Add(_secilen);
				_secilen.RoomType = rt;
				_roomTypeRep.Add(rt);
			}
		}

		private void btnYemekEkle_Click(object sender, EventArgs e)
		{
			Extra ex = new Extra();
			ex.Name = txtYemek.Text;
			ex.UnitPrice = Convert.ToDecimal(txtFiyat.Text);
			_extraRep.Add(ex);


		}
	}
}
