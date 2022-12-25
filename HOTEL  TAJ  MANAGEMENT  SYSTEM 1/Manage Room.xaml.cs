using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace hotel_management_system
{
    /// <summary>
    /// Interaction logic for Manage_Room.xaml
    /// </summary>
    public partial class Manage_Room : Window
    {
        private object booking;
        private object room_no;
        private object customer_name;
        private object address;
        private object contact;
        private object status;

        public Manage_Room()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public object DataGrid1 { get; private set; }

        private void edit_room_click(object sender, RoutedEventArgs e)
        {
            {
                int room_no;
                String customer_name = customer_name.Text;
                string address = address.Text;
                int contact = Convert.ToInt32(contact.Text);
                string status = status.Text;

                try
                {
                    room_no = Convert.ToInt32(room_no.Text);

                    if (room_no.Equals("") || customer_name.Trim().Equals("") || address.Trim().Equals("") || contact.Equals("") || status.Trim().Equals(""))
                    {
                        MessageBox.Show("Requerd fields- ", "Empty fields", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        Boolean insert_booking = room.edit_employee(room_no, customer_name, address, contact,status);

                        if (insert_booking)
                        {
                            DataGrid1.DataSource = booking.getbooking();
                            MessageBox.Show("Room Booked succesfully", "Edit Data", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error- room not booked", "Edit Data", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ID Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }


            }

            private void DataGrid1_cellclick(object sender, DataGridCellEventArgs e)
            {
                room_no = DataGrid1.CurrentRow.Cells[0].Value.ToString();
                customer_name = DataGrid1.CurrentRow.Cells[1].Value.ToString();
                address = DataGrid1.CurrentRow.Cells[2].Value.ToString();
                contact = DataGrid1.CurrentRow.Cells[3].Value.ToString();
                status = DataGrid1.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
