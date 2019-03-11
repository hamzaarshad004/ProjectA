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
    public partial class AddProject : Form
    {
        public string conStr = "Data Source=DESKTOP-P69CV50;Initial Catalog=ProjectA;Integrated Security=True";

        public AddProject()
        {
            InitializeComponent();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string Insert = "INSERT INTO Project(Description, Title) VALUES('"+Convert.ToString(txtDescription.Text)+"', '"+Convert.ToString(txtTitle.Text)+"')";
                SqlCommand cmd = new SqlCommand(Insert, con);
                cmd.ExecuteNonQuery();
            }

        }
    }
}
