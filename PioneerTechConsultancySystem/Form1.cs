using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PioneerTechConsultancySystem
{
    public partial class Form1 : Form
    {
        private string databaseconnectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";


        public Form1()
        {

            InitializeComponent();
            GetEmployeeDetails();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            FirstNameTextbox.Text = string.Empty;
            LastNameTextbox.Text = string.Empty;
            EmailIdTextbox.Text= String.Empty;
            MobileNoTextbox.Text = String.Empty;
            CurrentCountryTextbox.Text = String.Empty;
            HomeCountryTextbox.Text = String.Empty;
            AddressTextbox.Text = String.Empty;
            ZipCodeTextbox.Text = String.Empty;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string FirstName = FirstNameTextbox.Text;
                string LastName = LastNameTextbox.Text;
                string EmailId = EmailIdTextbox.Text;
                long MobileNo = Convert.ToInt64(MobileNoTextbox.Text);
                string CurrentCountry = CurrentCountryTextbox.Text;
                string HomeCountry = HomeCountryTextbox.Text;
                string Address = AddressTextbox.Text;
                int ZipCode = Convert.ToInt32(ZipCodeTextbox.Text);
                string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                String mysql = "INSERT INTO Employee_Details(Employee_Name,Last_Name,Email,Mobile_Number,Current_Country,Home_Country,Address, ZipCode) Values ('"
                    + FirstName + "','" + LastName + "','" + EmailId + "'," + MobileNo + ",'" + CurrentCountry + "','" + HomeCountry + "','" + Address + "'," + ZipCode + ")";
                SqlCommand emploeeDetailsCommand=new  SqlCommand(mysql, mysqlconnection);

               int result= emploeeDetailsCommand.ExecuteNonQuery();
                if(result>0)
                {
                    MessageBox.Show("your data is saved");

                }

                mysqlconnection.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }

        
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String Course = coursetxt.Text;
                int Passing_Year = Convert.ToInt32(passingyear.Text);
                String specialization = specializationtxt.Text;
                string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                String mysql = "INSERT INTO Education_Details(course,Passing_year,specialization) VALUES ('"+Course+"',"+Passing_Year+",'"+specialization+"')";
                SqlCommand educationdetails = new SqlCommand(mysql, mysqlconnection);
                int result = educationdetails.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("your data is saved");

                }

                mysqlconnection.Close();
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String Programming_Languages = pltextbox.Text;
                String Data_Bases= dbtxt.Text;
                String UI = uitxt.Text;
                string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                String mysql = "INSERT INTO Technical_Details(Programming_Languages,Data_Bases,UI) VALUES ('" + Programming_Languages+"','"+ Data_Bases+"','" +UI+ "')";
                SqlCommand technicaldetails = new SqlCommand(mysql, mysqlconnection);
                int result = technicaldetails.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("your data is saved");

                }

                mysqlconnection.Close();
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int Project_ID = Convert.ToInt32(projectid.Text);
                String Client = clienttxt.Text;
                String Location_tx = locationtxt.Text;
                String Roles_SW = rolestxt.Text;
                string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                String mysql = "INSERT INTO Project_Details(Project_ID,client,Location_tx,Roles_SW ) VALUES ("+ Project_ID + ",'" +Client+ "','" + Location_tx+"','"+ Roles_SW+"')";
                SqlCommand projectdet= new SqlCommand(mysql, mysqlconnection);
                int result = projectdet.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("your data is saved");

                }

                mysqlconnection.Close();
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {try

            {
                String Employer_Name = Employeetxt.Text;
                String Company_Details = Comptxt.Text;
                String Contact_NO = contacttxt.Text;
                String Location_C = loctxt.Text;
                String Website = webtxt.Text;

                string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                String mysql = "INSERT INTO Company_Details(Employer_Name,Company_Details,Contact_NO ,Location_C,Website) VALUES ('" + Employer_Name + "','" + Company_Details + "','" + Contact_NO + "','" + Location_C + "','" + Website + "')";
                    SqlCommand compdet = new SqlCommand(mysql, mysqlconnection);
                int result = compdet.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("your data is saved");

                }

                mysqlconnection.Close();
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coursetxt.Text = String.Empty;
            passingyear.Text = String.Empty;
            specializationtxt.Text = String.Empty;

        }

        private void passingyear_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pltextbox.Text = String.Empty;
            dbtxt.Text = String.Empty;
            uitxt.Text = String.Empty;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            projectid.Text = String.Empty;
            clienttxt.Text = String.Empty;
            locationtxt.Text = String.Empty;
            rolestxt.Text = String.Empty;

        }

        private void clienttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            Employeetxt.Text = String.Empty;
            Comptxt.Text = String.Empty;
            contacttxt.Text = String.Empty;
            loctxt.Text = String.Empty;
            webtxt.Text = String.Empty;

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {

           
}

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                int EmployeeID = Convert.ToInt32(Searchtxt.Text);
                string connectionstring = "Data Source=LAPTOP-TBFNHHOI;Initial Catalog=PioneerEmployeeDB;" +
                       " Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqlEmployeeDetails = ("SELECT * FROM Employee_Details WHERE EmployeeID=" + EmployeeID);
                string sqlTechnicalDetails = ("SELECT * FROM Technical_Details WHERE EmployeeID=" + EmployeeID);
                string sqlCompanyDetails = ("SELECT * FROM Company_Details WHERE EmployeeID=" + EmployeeID);
                string sqlProjectDetails = ("SELECT * FROM Project_Details WHERE EmployeeID=" + EmployeeID);

                SqlCommand command;
                command = new SqlCommand(sqlEmployeeDetails, mysqlconnection);
                SqlDataReader employeeData = command.ExecuteReader();
                BindingSource gridview1 = new BindingSource();
                gridview1.DataSource = employeeData;
                Employeegridview.DataSource = gridview1;
                employeeData.Close();
                
                command = new SqlCommand(sqlTechnicalDetails, mysqlconnection);
                SqlDataReader technicaldata = command.ExecuteReader();
                BindingSource TechnicalgridviewBindingSource = new BindingSource();
                TechnicalgridviewBindingSource.DataSource = technicaldata;
                Technicalgridview.DataSource = TechnicalgridviewBindingSource;
                technicaldata.Close();

                command = new SqlCommand(sqlCompanyDetails, mysqlconnection);
                SqlDataReader companydata = command.ExecuteReader();
                BindingSource Companygridview1 = new BindingSource();
                Companygridview1.DataSource = companydata;
                Companygridview.DataSource = Companygridview1;
                companydata.Close();

                command = new SqlCommand(sqlProjectDetails, mysqlconnection);
                SqlDataReader projectdata = command.ExecuteReader();
                BindingSource projectgridview1 = new BindingSource();
                projectgridview1.DataSource = projectdata;
                Projectgridview.DataSource = projectgridview1;
                projectdata.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetEmployeeDetails()
        {
            try
            {
                string sqlEmployeeDetailsCommand = "select EmployeeID,Employee_Name from Employee_Details";
                SqlConnection sqlConnection = new SqlConnection(databaseconnectionstring);
                sqlConnection.Open();
                SqlCommand employeedetailsSqlcommand = new SqlCommand(sqlEmployeeDetailsCommand, sqlConnection);
                SqlDataReader employeeDetailsDataReader = employeedetailsSqlcommand.ExecuteReader();
                BindingSource employeesurce = new BindingSource();
                employeesurce.DataSource = employeeDetailsDataReader;
                EmployeeDetailscomboBox.DataSource = employeesurce;
               
                //EmployeeDetailscomb = employeeDetailsDataReader[1].ToString();
                
                while(employeeDetailsDataReader.Read())
                {

                }
                sqlConnection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void EmployeeDetailscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
