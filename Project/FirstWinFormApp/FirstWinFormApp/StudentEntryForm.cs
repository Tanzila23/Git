using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using FirstWinFormApp.BLL;
using FirstWinFormApp.Models;

namespace FirstWinFormApp
{
    public partial class StudentEntryForm : Form
    {

        StudentManager _studentManager = new StudentManager();
        CityManager _cityManager = new CityManager();
        public StudentEntryForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {

                Student student = new Student();

                student.Name = nameTextBox.Text;
                student.Address = addressTextBox.Text;
                student.ContactNo = contactnoTextBox.Text;
                student.CityId = Convert.ToInt32(cityComboBox.SelectedValue);
                student.RegNo = regnoTextBox.Text;
                student.Email = emailTextBox.Text;
                //DateTime dateOfBirth = Convert.ToDateTime(DOBDateTimePicker.Text);
                //DateTime admissionDate = Convert.ToDateTime(addmissionDateDateTimePicker.Text);

                student.DateOfBirth = DOBDateTimePicker.Text;
                student.AdmissionDate = addmissionDateDateTimePicker.Text;



                if (string.IsNullOrEmpty(student.Name))
                {
                    MessageBox.Show("Name Required");
                    return;
                }

                bool isSaved = _studentManager.Save(student);




                if (isSaved)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Failed");
                }

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }



        private void ShowAllButton_Click(object sender, EventArgs e)
        {


            //string query = @"SELECT * FROM VGetStudentList";
            //SqlCommand command = new SqlCommand(query, con);
            //con.Open();


            //SqlDataAdapter da = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //con.Close();
            //StudentListGridView.DataSource = dt;





        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox1.SelectedValue);
        }

        private void StudentEntryForm_Load(object sender, EventArgs e)
        {
            DataTable dt = _cityManager.GetCityBindingSource();
            cityBindingSource.DataSource = dt;

        }

        private void transferDatabutton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = nameTextBox.Text;
            student.Address = addressTextBox.Text;
            new StudentEditForm(student).Show();
        }

    }
}
