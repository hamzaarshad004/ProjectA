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
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
                
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string Insert = "INSERT INTO Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) VALUES('" + Convert.ToString(txtFirstName.Text) + "', '" + Convert.ToString(txtLastName.Text) + "','" + Convert.ToString(txtContact.Text) + "', '" + Convert.ToString(txtEmail.Text) + "','" +Convert.ToDateTime(dtDOB.Value) + "', '" + 1 + "')";
                int ID;
                SqlCommand cmd = new SqlCommand(Insert,con);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT @@IDENTITY";
                ID = Convert.ToInt32(cmd.ExecuteScalar());
                string StudentInsert = "INSERT INTO Student(Id, RegistrationNo) VALUES('"+ID+"','" + Convert.ToString(txtRegNo.Text) + "')";
                SqlCommand sqlCommand = new SqlCommand(StudentInsert, con);
                sqlCommand.ExecuteNonQuery();
            }
                
        }
    }
}
