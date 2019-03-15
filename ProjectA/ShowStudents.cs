using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class ShowStudents : Form
    {
        List<Student> GetStudents = new List<Student>();
        public ShowStudents()
        {
            InitializeComponent();
        }

        private void ShowStudents_Load(object sender, EventArgs e)
        {
            Student.ShowStudents();
            GetStudents = Student.students;
            BindingSource s = new BindingSource();
            s.DataSource = GetStudents;
            dgvStudents.DataSource = s;
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                AddStudent.Mode = 1;
                Student S = Student.students[e.RowIndex];
                AddStudent AS = new AddStudent(S.ID1, S.FirstName1, S.LastName1, S.Contact1, S.Registration_Number1, S.Email1, S.DOB1, S.Gender1);
                AS.Show();
            }
        }
    }
}
