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

namespace ProjectA
{
    public partial class AddStudent : Form
    {

        public string conStr = "Data Source=DESKTOP-P69CV50;Initial Catalog=ProjectA;Integrated Security=True";
        public static int Mode = 0; // 0 For Add, 1 For Edit
        public int StudentID;
        string FName, LName, Contact, Reg_No, Email, Gender;
        DateTime DOB;
        public AddStudent()
        {
            InitializeComponent();
        }

        public AddStudent(int Id, string FName, string LName, string Contact, string Reg_No, string Email, DateTime DOB, string Gender)
        {
            InitializeComponent();
            this.FName = FName;
            this.LName = LName;
            this.Reg_No = Reg_No;
            this.Email = Email;
            this.Contact = Contact;
            this.DOB = DOB;
            this.Gender = Gender;
            StudentID = Id;
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
           if (Mode == 1)
           {
                txtFirstName.Text = FName;
                txtLastName.Text = LName;
                txtRegNo.Text = Reg_No;
                txtEmail.Text = Email;
                txtContact.Text = Contact;
                dtDOB.Value = DOB;
                if (Gender == "Male")
                {
                    cmbGender.SelectedIndex = 0;
                }
                else
                {
                    cmbGender.SelectedIndex = 1;
                }
           }
        }
                
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (Mode == 0)
            {
                if (con.State == ConnectionState.Open)
                {
                    string Insert;
                    if (cmbGender.SelectedIndex == 0)
                    {
                        Insert = "INSERT INTO Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) VALUES('" + Convert.ToString(txtFirstName.Text) + "', '" + Convert.ToString(txtLastName.Text) + "','" + Convert.ToString(txtContact.Text) + "', '" + Convert.ToString(txtEmail.Text) + "','" + Convert.ToDateTime(dtDOB.Value) + "', '" + 1 + "')";
                    }
                    else
                    {
                        Insert = "INSERT INTO Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) VALUES('" + Convert.ToString(txtFirstName.Text) + "', '" + Convert.ToString(txtLastName.Text) + "','" + Convert.ToString(txtContact.Text) + "', '" + Convert.ToString(txtEmail.Text) + "','" + Convert.ToDateTime(dtDOB.Value) + "', '" + 2 + "')";
                    }
                    int ID;
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT @@IDENTITY";
                    ID = Convert.ToInt32(cmd.ExecuteScalar());
                    string StudentInsert = "INSERT INTO Student(Id, RegistrationNo) VALUES('" + ID + "','" + Convert.ToString(txtRegNo.Text) + "')";
                    SqlCommand sqlCommand = new SqlCommand(StudentInsert, con);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            else if (Mode == 1)
            {
                if (con.State == ConnectionState.Open)
                {
                    string Update;
                    if (cmbGender.SelectedIndex == 0)
                    {
                        Update = "UPDATE Person SET FirstName = '" + Convert.ToString(txtFirstName.Text) + "', LastName = '"+ Convert.ToString(txtLastName.Text) + "', Contact = '"+ Convert.ToString(txtContact.Text) + "', Email = '"+ Convert.ToString(txtEmail.Text) + "', DateOfBirth = '"+Convert.ToDateTime(dtDOB.Value)+"', Gender = '"+1+"' WHERE ID = '"+StudentID+"'";
                    }
                    else
                    {
                        Update = "UPDATE Person SET FirstName = '" + Convert.ToString(txtFirstName.Text) + "', LastName = '" + Convert.ToString(txtLastName.Text) + "', Contact = '" + Convert.ToString(txtContact.Text) + "', Email = '" + Convert.ToString(txtEmail.Text) + "', DateOfBirth = '" + Convert.ToDateTime(dtDOB.Value) + "', Gender = '" + 2 + "' WHERE ID = '" + StudentID + "'";
                    }
                    string Update_Student = "UPDATE Student SET RegistrationNo = '" + Convert.ToString(txtRegNo.Text) + "' WHERE Id = '" + StudentID + "'";
                    SqlCommand cmd = new SqlCommand(Update, con);
                    cmd.ExecuteNonQuery();
                    SqlCommand sqlCommand = new SqlCommand(Update_Student, con);
                    sqlCommand.ExecuteNonQuery();
                }
                AddStudent.Mode = 0;
            }
                
        }

        private void lblViewAdded_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ShowStudents SS = new ShowStudents();
            SS.Show();
        }
    }
}
