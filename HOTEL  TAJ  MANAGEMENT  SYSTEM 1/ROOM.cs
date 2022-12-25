using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace hotel_management_system
{
    public class ROOM
    {
        CONNECT conn = new CONNECT();

        public bool insert_room(string room_no, string customer_name, string address, string contact, string status)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `booking`(`room_no`, `customer_name`, `address`, `contact`,`status`) VALUES (@room_no,@cnm,@adrs,@cont,@stat)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@room_no", MySqlDbType.Int32).Value = room_no;
            command.Parameters.Add("@cnm", MySqlDbType.VarChar).Value = customer_name;
            command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@cont", MySqlDbType.Int32).Value = contact;
            command.Parameters.Add("@stat", MySqlDbType.VarChar).Value = status;
            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

            public DataTable getbooking()
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `booking`", conn.getConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                return table;
            }
        }

        internal bool insert_booking(int room_no, string customer_name, string address, int contact, string status)
        {
            throw new NotImplementedException();
        }


        public bool edit_room(int room_no, String customer_name, String address, int contact, string status)
        {

            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `booking` SET `room_no`=@room_no,`customer_name`=@cnm,`address`=@adrs,`contact`=@cont,`status`=@stat WHERE `room_no`=@room_no ";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@room_no", MySqlDbType.Int32).Value = room_no;
            command.Parameters.Add("@cnm", MySqlDbType.VarChar).Value = customer_name;
            command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@cont", MySqlDbType.Int32).Value = contact;
            command.Parameters.Add("@stat", MySqlDbType.VarChar).Value = status;

            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }

            public DataTable getbooking()
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `booking`", conn.getConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                return table;
            }

        }

        internal object getbooking()
        {
            throw new NotImplementedException();
        }
    }

