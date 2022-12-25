using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management_system
{
    class login
    {


        SqlConnection con = new SqlConnection("datasource = localhost; port = 3306; username = root; passward = ; database = hotel management;");

        public bool login_check()
        {
            command.CommandText = query;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@user name", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@passward", MySqlDbType.VarChar).Value = passward;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                Main_Window mwindow = new Main_Window();
                mwindow.Show();

            }
            else
            {
                if (username.Equals(""))
                {
                    MessageBox.Show("Enter Your Username To Login", "Empty Username", MessageBoxButton.OK);
                }
                else if (passward.Equals(""))
                {
                    MessageBox.Show("Enter Your Passward To Login", "Empty Passward", MessageBoxButton.OK);
                }
                else
                {
                    MessageBox.Show("Your Passward Or Username Dosen't Exists", "Wrong Data", MessageBoxButton.OK);
                }

            }
