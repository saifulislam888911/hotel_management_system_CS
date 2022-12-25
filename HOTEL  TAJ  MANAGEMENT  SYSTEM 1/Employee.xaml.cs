using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for Employee.xaml
    /// </summary>
    public partial class Employee : Window
    {

        EMPLOYEE employee = new EMPLOYEE();
        private int id;
        private string name;
        private string position;
        private string salary;

        public string DataGrid1 { get; private set; }
        public string TextBoxid { get; private set; }

        public Employee()
        {
            InitializeComponent();
        }

        private void button4_click(object sender, RoutedEventArgs e)
        {
            id = "";
            name = "";
            position = "";
            salary = "";
        }

        private void button1_click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(id.Text);
            String emp_name = name.Text;
            String position = position.Text;
            int salary = Convert.ToInt32(salary.Text);

            if (id.Equals("") || emp_name.Trim().Equals("") || position.Trim().Equals("") || salary.Equals(""))
            {
                MessageBox.Show("Requerd fields- ", "Empty fields", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Boolean insert_employee = employee.insert_employee(id, emp_name, position, salary);

                if (insert_employee)
                {
                    MessageBox.Show("new employee inserted succesfully", "Add Data", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error- employee not inserted", "Add Data", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        private void manageclientform_load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataGrid1.DataSource = employee.getemployee();
        }

        private void edit_employee_click(object sender, RoutedEventArgs e)
        {
            int id;
            String emp_name = name.Text;
            String position = position.Text;
            int salary = Convert.ToInt32(salary.Text);

            try
            {
                id = Convert.ToInt32(id.Text);

                if (id.Equals("") || emp_name.Trim().Equals("") || position.Trim().Equals("") || salary.Equals(""))
                {
                    MessageBox.Show("Requerd fields- ", "Empty fields", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    Boolean insert_employee = employee.edit_employee(id, emp_name, position, salary);

                    if (insert_employee)
                    {
                        DataTable dt = new DataTable();
                        DataGrid1.ItemSource = employee.getemployee();

                        MessageBox.Show("new employee updated succesfully", "Edit Data", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error- employee not updated", "Edit Data", MessageBoxButton.OK, MessageBoxImage.Error);
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
            id = DataGrid1.CurrentRow.Cells[0].Value.ToString();
            name = DataGrid1.CurrentRow.Cells[1].Value.ToString();
            position = DataGrid1.CurrentRow.Cells[2].Value.ToString();
            salary = DataGrid1.CurrentRow.Cells[3].Value.ToString();
        }

        private void removedata_click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(TextBoxid.text);

                if (employee.removeemployee(id))
                {
                    DataGrid1.DataSource = employee.getemployee();
                    MessageBox.Show("new employee deleted succesfully", "Delete Data", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error- employee not deleted", "Delete Data", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

    }

}
