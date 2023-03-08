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

		ReservationRepository _reservationRep;

		OrderExtraRepository _orderExtraRep;

		RoomReservationRepository _roomReservationRep;

		//SEçilenler

		Room _secilenOda;
		Extra _secilenYemek;
		Order _secilenOrder;
		Reservation _secilenReservasyon;
		OrderExtra _secilenOrderExtra;
		RoomReservation _secilenRoomReservattion;

		public Form2()
		{
			InitializeComponent();
			_orderRep = new OrderRepository();
			_extraRep = new ExtraRepository();
			_customerRep = new CustomerRepository();
			_roomRep = new RoomRepository();
			_reservationRep = new ReservationRepository();
			_orderExtraRep = new OrderExtraRepository();
			_roomReservationRep = new RoomReservationRepository();

		}

		private void Form2_Load(object sender, EventArgs e)
		{
			List<Room> orginal = _roomRep.GetAll();

			foreach (Room item in orginal)
			{
				lstBosOda.Items.Add(item);
			}
			List<Extra> extra = _extraRep.GetAll();

			foreach (Extra item in extra)
			{
				cmbYemek.Items.Add(item);
			}


		}


		private void btnYemek_Click(object sender, EventArgs e)
		{
			Order o = new Order();
			o.OrderNo = _secilenYemek.MealName;
			o.UnitPrice = _secilenYemek.UnitPrice;
			_orderRep.Add(o);
			_secilenOrder = o;


		    Extra ex = new Extra();
			ex.MealName = _secilenYemek.MealName;
			ex.UnitPrice = _secilenYemek.UnitPrice;
			_extraRep.Add(ex);

			
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			
			
			Customer cst = new Customer();
			cst.FirstName = txtIsim.Text;
			cst.LastName = txtSoyIsim.Text;
			_customerRep.Add(cst);


			Reservation rst = new Reservation();
			rst.Customer = cst;
			rst.UnitPrice = _secilenOda.UnitPrice;
			_reservationRep.Add(rst);

			

			Room r = new Room();
			r.RoomNo = _secilenOda.RoomNo;
			r.UnitPrice = _secilenOda.UnitPrice;
			_roomRep.Add(r);

			RoomReservation rr = new RoomReservation();
			rr.ReservationID = rst.ID;
			rr.RoomID = r.ID;
			_roomReservationRep.Add(rr);

            lstReservasyon.Items.Add(rst);











        }

		private void lblOda_Click(object sender, EventArgs e)
		{

		}

		private void cmbYemek_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbYemek.SelectedIndex > -1)
			{
				_secilenYemek = cmbYemek.SelectedItem as Extra;
			}
		}

		private void lstReservasyon_Click(object sender, EventArgs e)
		{
			if (lstReservasyon.SelectedIndex > -1)
			{
				_secilenReservasyon = lstReservasyon.SelectedItem as Reservation;
				lblYemekliReservasyon.Text = (lstReservasyon.SelectedItem as Reservation).BilgiGoster();
			}
		}

		private void btnSiparisEkle_Click(object sender, EventArgs e)
		{
            if (_secilenYemek != null && _secilenOrder !=null)
            {
                OrderExtra oa = new OrderExtra();

                oa.ExtraID = _secilenYemek.ID;
                oa.OrderID = _secilenOrder.ID;

                _orderExtraRep.Add(oa);
                _secilenOrderExtra = oa;

            }


            if (_secilenReservasyon != null && _secilenOrder != null)
			{

				_secilenReservasyon.Orders.Add(_secilenOrder);

				lblYemekliReservasyon.Text = _secilenReservasyon.BilgiGoster();

				_secilenReservasyon.TutarHesapla();
				lblTotalFiyat.Text = _secilenReservasyon.UnitPrice.ToString();
				//Todo : ilk seferde 1x yerine 2 x hesaplayip ardından 1 x hesaplamaya devam ediyor..
			}
			
			
		}

		private void btnCiro_Click(object sender, EventArgs e)
		{
			decimal toplamTutar = 0;

			foreach (Reservation item in lstReservasyon.Items)
			{
				toplamTutar += item.UnitPrice;
				if (lblTotalFiyat.Text !=null)
				{
					toplamTutar += _secilenOrder.UnitPrice;
				}
				
			}
			lblTotalFiyat.Text = $"{toplamTutar:C2}";
		}

        private void lstBosOda_Click(object sender, EventArgs e)
        {
			if (lstBosOda.SelectedIndex>-1)
			{
				_secilenOda = lstBosOda.SelectedItem as Room;
				lblOda.Text = _secilenOda.BilgiGoster();
			}
        }
    }
}
