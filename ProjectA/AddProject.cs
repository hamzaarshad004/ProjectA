﻿using System;
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
        public static string conStr = "Data Source=DESKTOP-P69CV50;Initial Catalog=ProjectA;Integrated Security=True";
        int Mode = 0, Id; // 0 For Add, 1 For Edit
        List<Project> showprojects = new List<Project>();

        public AddProject()
        {
            InitializeComponent();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (Mode == 0)
            {
                if (con.State == ConnectionState.Open)
                {
                    string Insert = "INSERT INTO Project(Description, Title) VALUES('" + Convert.ToString(txtDescription.Text) + "', '" + Convert.ToString(txtTitle.Text) + "')";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();
                }

                BindingSource s = new BindingSource();
                Project.getProjects();
                showprojects = Project.projects;
                s.DataSource = showprojects;
                dgvProjects.DataSource = s;

            }
            else if (Mode == 1)
            {
                if (con.State == ConnectionState.Open)
                {
                    string Update = "UPDATE Project SET Title = '" + Convert.ToString(txtTitle.Text) + "', Description = '" + Convert.ToString(txtDescription.Text) + "' WHERE Id = '" + Id + "'";
                    SqlCommand cmd = new SqlCommand(Update, con);
                    cmd.ExecuteNonQuery();
                }

                BindingSource s = new BindingSource();
                Project.getProjects();
                showprojects = Project.projects;
                s.DataSource = showprojects;
                dgvProjects.DataSource = s;
            }
        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            BindingSource s = new BindingSource();
            Project.getProjects();
            showprojects = Project.projects;
            s.DataSource = showprojects;
            dgvProjects.DataSource = s;

            txtCompleteData.Text = null;
        }

        private void dgvProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                txtCompleteData.Text = dgvProjects.Rows[e.RowIndex].Cells[3].Value + string.Empty;
            }
            else if (e.ColumnIndex == 4)
            {
                txtCompleteData.Text = dgvProjects.Rows[e.RowIndex].Cells[4].Value + string.Empty;
            }
            else if (e.ColumnIndex == 0)
            {
                Id = Project.projects[e.RowIndex].Id1;
                Project p = Project.projects[e.RowIndex];
                txtTitle.Text = p.Title1;
                txtDescription.Text = p.Description1;
                Mode = 1;
            }
            else if (e.ColumnIndex == 1)
            {
                int Delete_Id = Project.projects[e.RowIndex].Id1;
                string Delete = "DELETE FROM Project WHERE Id = '" + Delete_Id + "'";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand(Delete, con);
                    cmd.ExecuteNonQuery();
                }
                BindingSource s = new BindingSource();
                Project.getProjects();
                showprojects = Project.projects;
                s.DataSource = showprojects;
                dgvProjects.DataSource = s;
            }
        }
    }
}
