using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PioneerTech.Models.models;
using System.Windows.Forms;

namespace PioneerTechSystem.DAL
{
    public class EmployeeDataAccessLayer
    {

        public string SaveEmployee(string FirstName, string LastName, string EmailId, long MobileNo, string CurrentCountry, string HomeCountry, string Address, int ZipCode)
        {
            string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";
            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            try
            {


                mysqlconnection.Open();
                String mysql = "INSERT INTO Employee_Details(Employee_Name,Last_Name,Email,Mobile_Number,Current_Country,Home_Country,Address, ZipCode) Values ('"
                    + FirstName + "','" + LastName + "','" + EmailId + "'," + MobileNo + ",'" + CurrentCountry + "','" + HomeCountry + "','" + Address + "'," + ZipCode + ")";
                SqlCommand employeedetails = new SqlCommand(mysql, mysqlconnection);
                int result = employeedetails.ExecuteNonQuery();
                if (result > 0)
                {
                    return "success";
                }
                return "failed";
            }



            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                mysqlconnection.Close();
            }
        }
    }
    public class EducationDataAccess
    {
        public int SaveEducation(EducationDetailsModel education)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";

                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqleducationdetails = @"INSERT INTO Education_Details(Passing_Year,Course,specialization)VALUES('" + education.Course + "'," + "'" + education.specialization + "'," + "" + education.Passing_Year + "')";
                SqlCommand command;
                command = new SqlCommand(sqleducationdetails, mysqlconnection);
                result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("CompanyDetailsModel have been saved:");
                }
                mysqlconnection.Close();

            }



            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact administrator: " + ex.Message);
            }

            return result;
        }
    }



    public class TechnicalDataAccess
    {
        public int SaveTechnical(TechnicalDetailsModel technical)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source = LAPTOP-TBFNHHOI; Initial Catalog = PioneerEmployeeDB;Integrated Security=True";

                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqltechnicaldetails = @"INSERT INTO Technical_Details(Programming_Languages,Databases,UI)VALUES('" + technical.Programming_Languages + "'," + "'" + technical.Data_Bases + "'," + "'" + technical.UI + "')";
                SqlCommand command;
                command = new SqlCommand(sqltechnicaldetails, mysqlconnection);
                result = command.ExecuteNonQuery();
                mysqlconnection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error has been occured, please contact administrator: " + ex.Message);
            }
            return result;
        }
    }
    public class CompanyDataAccess
    {
        public int SaveCompany(CompanyDetailsModel company)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source=RAKI;Initial Catalog=PioneerEmployeeDB;" + "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqlcompanydetails = @"INSERT INTO Company_Details(Employer_Name,Company_Details,Contact_NO,Location_C,Website)VALUES('" + company.Employer_Name + "'," + "" + company.Company_Details + "," + "" + company.Contact_NO + "," + "'" + company.Location_C + "'," + "'" + company.Website + "')";
                SqlCommand command;
                command = new SqlCommand(sqlcompanydetails, mysqlconnection);
                result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Details have been saved Successfully:");
                }
                mysqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
            return result;
        }
    }
    public class ProjectDataAccess
    {
        public int SaveProject(ProjectDetailsModel project)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source=RAKI;Initial Catalog=PioneerEmployeeDB;" +
                   " Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqlprojectdetails = @"INSERT INTO Project_Details(projectID,client,Location,Roles_SW)VALUES(" + project.EmployeeID + "," + "'" + project.Project_ID + "'," + "'" + project.Client + "'," + "'" + project.Location_tx + "'," + "'" + project.Roles_SW + "')";
                SqlCommand command;
                command = new SqlCommand(sqlprojectdetails, mysqlconnection);
                result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Details have been saved Successfully:");
                }
                mysqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
            return result;
        }
    }
}




















































