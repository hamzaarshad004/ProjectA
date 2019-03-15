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
    public partial class AddEvaluation : Form
    {
        List<Evaluation> evaluations = new List<Evaluation>();
        int Mode = 0; // 0 For Add, 1 For Edit

        public AddEvaluation()
        {
            InitializeComponent();
        }

        public void setGrid()
        {
            Evaluation.getEvaluations();
            evaluations = Evaluation.Evaluations;
            BindingSource s = new BindingSource();
            s.DataSource = evaluations;
            dgvEvaluations.DataSource = s;
        }

        private void btnAddEvalutation_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(AddProject.conStr);
            con.Open();
            if (Mode == 0)
            {
                string Insert = "INSERT INTO Evaluation(Name, TotalMarks, TotalWeightage) VALUES ('" + Convert.ToString(txtName.Text) + "', '" + Convert.ToString(txtMarks.Text) + "', '" + Convert.ToString(txtWeightage.Text) + "')";
                SqlCommand cmd = new SqlCommand(Insert, con);
                cmd.ExecuteNonQuery();
                setGrid();

            }
        }
    }
}
