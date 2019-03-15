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
        int Mode = 0, Id; // 0 For Add, 1 For Edit
        List<Advisor> advisors = new List<Advisor>();
        public AddAdvisor()
        {
            InitializeComponent();
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAdvisor_Click(object sender, EventArgs e)
        {
            int Desig = 0;
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (Mode == 0)
            {
                if (con.State == ConnectionState.Open)
                {
                    if (cmbDesignation.SelectedIndex == 0)
                    {
                        Desig = 6;
                    }
                    else if (cmbDesignation.SelectedIndex == 1)
                    {
                        Desig = 7;
                    }
                    else if (cmbDesignation.SelectedIndex == 2)
                    {
                        Desig = 8;
                    }
                    else if (cmbDesignation.SelectedIndex == 3)
                    {
                        Desig = 9;
                    }
                    else if (cmbDesignation.SelectedIndex == 4)
                    {
                        Desig = 10;
                    }
                    string Insert = "INSERT INTO Advisor(Id, Designation, Salary) VALUES('" + Convert.ToString(txtID.Text) + "', '" + Desig + "', '" + Convert.ToString(txtSalary.Text) + "')";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();
                }
                setGrid();
            }
            else if (Mode == 1)
            {
                if (con.State == ConnectionState.Open)
                {
                    string Update = "UPDATE Advisor SET Designation = '" + Convert.ToInt32(cmbDesignation.SelectedIndex + 6) + "', Salary = '" + Convert.ToInt32(txtSalary.Text) + "' WHERE Id = '" + Id + "'";
                    SqlCommand cmd = new SqlCommand(Update, con);
                    cmd.ExecuteNonQuery();
                }

                Mode = 0;
                txtID.ReadOnly = false;
                setGrid();
            }
            
        }

        private void AddAdvisor_Load(object sender, EventArgs e)
        {
            setGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(AddProject.conStr);
            con.Open();
            if (e.ColumnIndex == 0)
            {
                Id = Advisor.Advisors[e.RowIndex].Id1;
                Advisor advisor = Advisor.Advisors[e.RowIndex];
                txtID.Text = advisor.Id1.ToString();
                txtSalary.Text = advisor.Salary1.ToString();
                cmbDesignation.SelectedIndex = advisor.Designation1 - 6;
                txtID.ReadOnly = true;

                Mode = 1;
            }

            else if (e.ColumnIndex == 1)
            {
                int Delete_Id = Advisor.Advisors[e.RowIndex].Id1;
                string Delete = "DELETE FROM Advisor WHERE Id = '" + Delete_Id + "'";
                if (con.State == ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand(Delete, con);
                    cmd.ExecuteNonQuery();
                }

                setGrid();
            }
        }

        private void setGrid()
        {
            Advisor.getAdvisors();
            advisors = Advisor.Advisors;
            BindingSource s = new BindingSource();
            s.DataSource = advisors;
            dgvAdvisors.DataSource = s;

        }
    }
}
