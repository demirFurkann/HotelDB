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
           
        }
    }
}
