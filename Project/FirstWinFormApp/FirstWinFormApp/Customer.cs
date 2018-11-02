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

namespace FirstWinFormApp
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }


        List<string> names = new List<string>();

        private void SaveButton_Click(object sender, EventArgs e)
        {

            string userName = nameTextBox.Text;
            //validation

            bool isUserNameUnique = CheckUserNameUnique(names, userName);
            if (!isUserNameUnique)
            {
                MessageBox.Show("Exist");
            }

            names.Add(userName);

            //for (int i = 0; i < names.Count; i++)
            //{
            //    if (names[i] == userName)
            //    {
            //        MessageBox.Show("Already Exist");
            //    }
            //}
        }

        public bool CheckUserNameUnique(List<string> userNames, string userName)
        {
            foreach (string name in userNames)
            {
                if (name == userName)
                {
                    return false;
                }
            }
            return true;
        }

        private void CountrySaveButton_Click(object sender, EventArgs e)
        {

            try
            {

                string name = countryNameTextBox.Text;
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Name Required");
                    return;
                }

                //1. Connection String

                string conString = @"Server=BITMTRAINER-301\SQLEXPRESS; Database=StudentInfo_53_13; Integrated Security = true;";

                //2. SQl Connection Crate

                SqlConnection con = new SqlConnection(conString);

                //con.ConnectionString = conString;

                //3. Query

                string query = @"INSERT INTO Countries (Name) VALUES ('" + name + "');";

                //4. SQL Command

                SqlCommand command = new SqlCommand(query, con);

                //5. Connection Open
                con.Open();


                //6. Execute Command

                int rowAffected = command.ExecuteNonQuery();

                //7. Connection Close

                con.Close();

                //8. Write ur code Here

                if (rowAffected > 0)
                {
                    MessageBox.Show("Saved");
                    return;
                }
                MessageBox.Show("Failed");






            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }



        }

        private void CitySaveButton_Click(object sender, EventArgs e)
        {

            try
            {

                string countryName = countryNameCTextBoxt.Text;
                string cityName = cityNameTextBox.Text;

                if (string.IsNullOrEmpty(cityName) || string.IsNullOrEmpty(countryName))
                {
                    MessageBox.Show("Name Required");
                    return;
                }

                string conString = @"Server=BITMTRAINER-301\SQLEXPRESS; Database=StudentInfo_53_13; Integrated Security = true;";
                SqlConnection con = new SqlConnection(conString);

                string query = @"SELECT * FROM Countries WHERE Name='" + countryName + "'";

                SqlCommand command = new SqlCommand(query, con);

                con.Open();

                SqlDataReader dr = command.ExecuteReader();

                if (dr.HasRows)
                {
                    //
                }
                int countryIdTwo = 0;
                if (dr.Read())
                {

                    int countryId = Convert.ToInt32(dr.GetValue(0));
                    countryIdTwo = Convert.ToInt32(dr["Id"]);
                }
                con.Close();
                // ------------------


                if (countryIdTwo > 0)
                {
                    query = @"INSERT INTO Cities (Name, CountryId) VALUES ('" + cityName + "'," + countryIdTwo + ")";
                    command = new SqlCommand(query, con);

                    con.Open();
                    int rowAffected = command.ExecuteNonQuery();
                    con.Close();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Saved");
                        return;
                    }
                    MessageBox.Show("Failed");
                   
                }
                MessageBox.Show("Sorry!! No Country Found!!");

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }





        }

    }
}
