using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PioneerTechSystem.DAL
{
    public class EmployeeDataAccessLayer
    {
        public int SaveEmployee(string FirstName, string LastName, string EmailId, long MobileNo,, string CurrentCountry, string HomeCountry, string Address, int ZipCode)
        {
            try { 
            string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";
            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
            String mysql = "INSERT INTO Education_Details(course,Passing_year,specialization) VALUES ('" + Course + "'," + Passing_Year + ",'" + specialization + "')";
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



    }

    public class EducationDetailsDataAccessLayer
    {
        public int SaveEducationDetails()
            {
            try
            {
                String Course = coursetxt.Text;
                int Passing_Year = Convert.ToInt32(passingyear.Text);
                String specialization = specializationtxt.Text;
                string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                String mysql = "INSERT INTO Education_Details(course,Passing_year,specialization) VALUES ('" + Course + "'," + Passing_Year + ",'" + specialization + "')";
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

    }

    public class EducationDetailsDataAccessLayer
    {

        public int SaveEducationDetails()
        {

        }
    }


    public class ProjectDetailsDataAccessLayer
    {

        public int SaveProjectDetails()
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
                String mysql = "INSERT INTO Project_Details(Project_ID,client,Location_tx,Roles_SW ) VALUES (" + Project_ID + ",'" + Client + "','" + Location_tx + "','" + Roles_SW + "')";
                SqlCommand projectdet = new SqlCommand(mysql, mysqlconnection);
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
    }


    public class CompanyDetailsDataAccessLayer
    {

        public int SaveCompanyDetails()
        {
            try

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
    }
}
