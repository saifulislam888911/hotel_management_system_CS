using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace hotel_management_system
{
    class EMPLOYEE
    {
       
        CONNECT conn = new CONNECT();

        public bool insert_employee(String id, String emp_name, String position, String salary)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `employee`(`id`, `emp_name`, `position`, `salary`) VALUES (@id,@enm,@pos,@sal)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@enm", MySqlDbType.VarChar).Value = emp_name;
            command.Parameters.Add("@pos", MySqlDbType.VarChar).Value = position;
            command.Parameters.Add("@sal", MySqlDbType.Int32).Value = salary;

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

           public  DataTable getEmployee()
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `employee`", conn.getConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                return table;
            }
        }

        internal bool insert_employee(int id, string emp_name, string position, int salary)
        {
            throw new NotImplementedException();
        }

    public bool edit_employee(int id, String emp_name, String position, int salary)
    {

        MySqlCommand command = new MySqlCommand();
        String editQuery = "UPDATE `employee` SET `id`=@id,`emp_name`=@enm,`position`=@pos,`salary`=@sal WHERE `id`=@id ";
        command.CommandText = editQuery;
        command.Connection = conn.getConnection();

        command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
        command.Parameters.Add("@enm", MySqlDbType.VarChar).Value = emp_name;
        command.Parameters.Add("@pos", MySqlDbType.VarChar).Value = position;
        command.Parameters.Add("@sal", MySqlDbType.Int32).Value = salary;

        conn.openConnection();
        if (command.ExecuteNonQuery() == 1)
        {
            ConnectionState.closeConnection();
            return true;
        }
        else
        {
            conn.closeConnection();
            return false;
        }
    }

            public  DataTable getEmployee()
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `employee`", conn.getConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                return table;
            }

        }

        internal object getemployee()
        {
            throw new NotImplementedException();
        }

        internal bool removeemployee(int id)
        {
            throw new NotImplementedException();
        }
    

    public bool Removeemployee(int id)
    {
        MySqlCommand command = new MySqlCommand();
        String removeQuery = "DELETE FROM `employee` WHERE `id`=@id";
        command.CommandText = removeQuery;
        command.Connection = conn.getConnection();

        command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

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

