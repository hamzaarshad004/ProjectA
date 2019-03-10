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
    public partial class AddAdvisor : Form
    {
        public string conStr = "Data Source=DESKTOP-P69CV50;Initial Catalog=ProjectA;Integrated Security=True";
        public AddAdvisor()
        {
            InitializeComponent();
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAdvisor_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                if (cmbDesignation.SelectedIndex == 0)
                {
                    string Insert = "INSERT INTO Advisor(Id, Designation, Salary) VALUES('" + Convert.ToString(txtID.Text) + "', '"+6+"', '"+ Convert.ToString(txtSalary.Text)+"')";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();
                }
                else if (cmbDesignation.SelectedIndex == 1)
                {
                    string Insert = "INSERT INTO Advisor(Id, Designation, Salary) VALUES('" + Convert.ToString(txtID.Text) + "', '"+7+"', '" + Convert.ToString(txtSalary.Text) + "')";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();
                }
                else if (cmbDesignation.SelectedIndex == 2)
                {
                    string Insert = "INSERT INTO Advisor(Id, Designation, Salary) VALUES('" + Convert.ToString(txtID.Text) + "', '"+8+"', '" + Convert.ToString(txtSalary.Text) + "')";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();
                }
                else if (cmbDesignation.SelectedIndex == 3)
                {
                    string Insert = "INSERT INTO Advisor(Id, Designation, Salary) VALUES('" + Convert.ToString(txtID.Text) + "', '"+9+"', '" + Convert.ToString(txtSalary.Text) + "')";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();
                }
                else if (cmbDesignation.SelectedIndex == 4)
                {
                    string Insert = "INSERT INTO Advisor(Id, Designation, Salary) VALUES('" + Convert.ToString(txtID.Text) + "', '"+10+"', '" + Convert.ToString(txtSalary.Text) + "')";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
