using Connexion_BD.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connexion_BD
{
    public partial class FrmMain : Form
    {
        SqlConnection connection;

        public FrmMain()
        {
            InitializeComponent();
            tcView.Enabled = false;
            UDSelectMax.Enabled = false;
            UDSelectMin.Enabled = false;
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(
                    @"Data source = 79.143.90.12,54321;
                    Initial Catalog=MarioEmployees;
                    Persist Security Info=true;
                    User Id = sa; Password = 123456789"
                );

                connection.Open();
                tcView.Enabled = true;
                SelectLocations();
                Console.WriteLine("Connected!");
            }
            catch ( SqlException ex ) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (connection != null )
            {
                connection.Close();
                connection = null;
                tcView.Enabled = false;
                Console.WriteLine("Closed");
            }
        }

        void InsertJob(Job job)
        {
            try
            {
                if (connection == null)
                    lbWarningInsert.Text = "No se ha connectado al servidor";
                else if (job.max_salary < job.min_salary)
                    lbWarningInsert.Text = "El salario maximo tiene que ser mas grande que el minimo";
                else if (job.job_title.Trim() == "")
                    lbWarningInsert.Text = "Escribe un nombre valido";
                else
                {
                    string query = "INSERT INTO JOBS (job_title, min_salary, max_salary) VALUES ( @jobTitle, @jobMin, @jobMax )";

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@jobTitle", job.job_title);
                        sqlCommand.Parameters.AddWithValue("@jobMin", job.min_salary);
                        sqlCommand.Parameters.AddWithValue("@jobMax", job.max_salary);

                        sqlCommand.ExecuteNonQuery();
                    }

                    lbWarningInsert.Text = "";
                    Console.WriteLine("Insertado correctamente");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        List<Job> SelectJob()
        {
            List<Job> jobs = new List<Job>();
            try
            {
                string query;

                if (cbAllJobs.Checked)
                    query = "SELECT * FROM JOBS";
                else
                    query = "SELECT * FROM JOBS WHERE min_salary >= @jobMin AND max_salary <= @jobMax";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    if (!cbAllJobs.Checked)
                    {
                        command.Parameters.AddWithValue("@jobMax", UDSelectMax.Value);
                        command.Parameters.AddWithValue("@jobMin", UDSelectMin.Value);
                    }

                    var myTable = new DataTable();
                    adapter.Fill(myTable);
                    dgvJobs.DataSource = myTable;

                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }

                //while(reader.Read())
                //{
                //    int job_id = reader.GetInt32(0);
                //    string job_title = reader.GetString(1);
                //    decimal min_salary = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                //    decimal max_salart = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);

                //    Job j = new Job(job_title, min_salary, max_salart);
                //    jobs.Add(j);
                //}
                //reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return jobs;
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            InsertJob(new Job(tbName.Text, UdMin.Value, UdMax.Value));
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            SelectJob();
            //foreach (Job j in )
            //{
            //    lbSelect.Items.Add(j.job_title + ":  " + j.min_salary + "-" + j.max_salary);
            //}
        }

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllJobs.Checked)
            {
                UDSelectMax.Enabled = false; 
                UDSelectMin.Enabled = false;
            }
            else
            {
                UDSelectMax.Enabled = true; 
                UDSelectMin.Enabled = true;
            }
        }


        void InsertEmployee(Employees employee)
        {

        }

        void SelectLocations()
        {
            try
            {
                string query = "SELECT * FROM LOCATIONS";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string city = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    cbSelec_Location.Items.Add(city);
                }

                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        void SelectEmployees()
        {
            try
            {
                string query = "";

                if (cbSelec_Location.SelectedIndex != -1)
                    query = "SELECT E.* FROM EMPLOYEES E " +
                            "INNER JOIN departments D ON D.department_id = E.department_id " +
                            "INNER JOIN locations L ON L.location_id = D.location_id " +
                            "WHERE E.first_name LIKE '" + tbSelect_FirstName_Employee.Text + "%' AND E.last_name LIKE '" + tbSelect_LastName_Employee.Text + "%' " +
                            "AND L.city = '" + cbSelec_Location.SelectedItem.ToString() + "'";
                else
                    query = "SELECT * FROM EMPLOYEES " +
                            "WHERE first_name LIKE '" + tbSelect_FirstName_Employee.Text + "%' AND last_name LIKE '" + tbSelect_LastName_Employee.Text + "%'";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    var myTable = new DataTable();
                    adapter.Fill(myTable);
                    dgvEmployee.DataSource = myTable;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btSelectEmployee_Click(object sender, EventArgs e)
        {
            SelectEmployees();
        }

        private void btInsetEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
