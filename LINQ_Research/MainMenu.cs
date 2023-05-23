using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_Research
{
    public partial class MainMenu : Form
    {
        Author author;
        Research research;
        List<Teacher> teachers;
        List<Teacher> original_teachers;
        public MainMenu()
        {
            InitializeComponent();
            author = new Author();
            research = new Research();
            teachers = new List<Teacher>();
            original_teachers = new List<Teacher>()
            {
                new Teacher
                {
                    Id = 1,
                    Surname = "Litvinov",
                    Name = "Andrii",
                    Patronymic = "Andriyovych",
                    Birthday = new DateTime(2004, 9, 9),
                    Cathedra = 503,
                    Title = "Postgraduate",
                    Standing = 3,
                    Salary = 2880

                },

                new Teacher
                {
                    Id = 2,
                    Surname = "Babeshko",
                    Name = "Eugene",
                    Patronymic = "Vasilyevich",
                    Birthday = new DateTime(1990, 3, 12),
                    Cathedra = 503,
                    Title = "PhD",
                    Standing = 15,
                    Salary = 13450

                },

                new Teacher
                {
                    Id = 3,
                    Surname = "Davis",
                    Name = "Olivia",
                    Patronymic = "Grace",
                    Birthday = new DateTime(1990, 9, 20),
                    Cathedra = 501,
                    Title = "Senior Lecturer",
                    Standing = 5,
                    Salary = 10235
                },

                new Teacher
                {
                    Id = 4,
                    Surname = "Harris",
                    Name = "Chloe",
                    Patronymic = "Ann",
                    Birthday = new DateTime(1988, 2, 23),
                    Cathedra = 505,
                    Title = "Assistant",
                    Standing = 4,
                    Salary = 11435
                },

                new Teacher
                {
                    Id = 5,
                    Surname = "Davis",
                    Name = "Matthew",
                    Patronymic = "James",
                    Birthday = new DateTime(1979, 10, 17),
                    Cathedra = 504,
                    Title = "PhD",
                    Standing = 1,
                    Salary = 9375
                },

                new Teacher
                {
                    Id = 6,
                    Surname = "Harris",
                    Name = "Ava",
                    Patronymic = "Rose",
                    Birthday = new DateTime(2001, 2, 4),
                    Cathedra = 501,
                    Title = "Postgraduate",
                    Standing = 3,
                    Salary = 3213
                },

                new Teacher
                {
                    Id = 7,
                    Surname = "Stadnyk",
                    Name = "Anastasiia",
                    Patronymic = "Oleksandrivna",
                    Birthday = new DateTime(1991, 4, 21),
                    Cathedra = 503,
                    Title = "Senior Lecturer",
                    Standing = 9,
                    Salary = 12233
                },

                new Teacher
                {
                    Id = 8,
                    Surname = "Shostak",
                    Name = "Anatoliy",
                    Patronymic = "Vasylovych",
                    Birthday = new DateTime(1973, 1, 7),
                    Cathedra = 503,
                    Title = "Associate professor",
                    Standing = 18,
                    Salary = 8732
                },

                new Teacher
                {
                    Id = 9,
                    Surname = "Martinez",
                    Name = "Daniel",
                    Patronymic = "Alejandro",
                    Birthday = new DateTime(1987, 11, 29),
                    Cathedra = 504,
                    Title = "Postgraduate",
                    Standing = 9,
                    Salary = 4712
                },

                new Teacher
                {
                    Id = 10,
                    Surname = "Wilson",
                    Name = "Alexander",
                    Patronymic = "Michael",
                    Birthday = new DateTime(1982, 5, 8),
                    Cathedra = 505,
                    Title = "Associate professor",
                    Standing = 1,
                    Salary = 5000
                }
            };

            TeacherGridView.ColumnCount = 9;
            TeacherGridView.Columns[0].Name = "Id";
            TeacherGridView.Columns[1].Name = "Surname";
            TeacherGridView.Columns[2].Name = "Name";
            TeacherGridView.Columns[3].Name = "Patronymic";
            TeacherGridView.Columns[4].Name = "Birthday";
            TeacherGridView.Columns[5].Name = "Cathedra";
            TeacherGridView.Columns[6].Name = "Title";
            TeacherGridView.Columns[7].Name = "Standing";
            TeacherGridView.Columns[8].Name = "Salary";

            OutputList(original_teachers);
        }

        private void ResearchButton_Click(object sender, EventArgs e)
        {
            research.ShowDialog();
        }

        private void AuthorButton_Click(object sender, EventArgs e)
        {
            author.ShowDialog();
        }

        private void OutputList(List<Teacher> list)
        {
            if (list == null)
                return;

            TeacherGridView.EnableHeadersVisualStyles = false;
            TeacherGridView.BorderStyle = BorderStyle.None;
            TeacherGridView.Rows.Clear();
            TeacherGridView.RowCount = list.Count;

            for (int i = 0; i < list.Count; i++)
            {
                int j = 0;
                TeacherGridView[j++, i].Value = list[i].Id;
                TeacherGridView[j++, i].Value = list[i].Surname;
                TeacherGridView[j++, i].Value = list[i].Name;
                TeacherGridView[j++, i].Value = list[i].Patronymic;
                TeacherGridView[j++, i].Value = list[i].Birthday.ToShortDateString();
                TeacherGridView[j++, i].Value = list[i].Cathedra;
                TeacherGridView[j++, i].Value = list[i].Title;
                TeacherGridView[j++, i].Value = list[i].Standing;
                TeacherGridView[j++, i].Value = list[i].Salary;
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (FilterSalaryRButton.Checked)
                teachers = original_teachers.Where(t => t.Salary > 5000).ToList();
            else if (FilterStandingRButton.Checked)
                teachers = original_teachers.Where(t => t.Standing > 5).ToList();
            else
                teachers = original_teachers.Where(t => t.Birthday.Year > 1990).ToList();
            OutputList(teachers);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            if (SortSalaryRButton.Checked)
                teachers = original_teachers.OrderBy(t => t.Salary).ToList();
            else if (SortStandingRButton.Checked)
                teachers = original_teachers.OrderBy(t => t.Standing).ToList();
            else
                teachers = original_teachers.OrderBy(t => t.Birthday).ToList();
            OutputList(teachers);
        }

        private void AggregateButton_Click(object sender, EventArgs e)
        {
            double result;
            if (AggregateAverageSalaryRButton.Checked)
                result = original_teachers.Average(t => t.Salary);
            else if (AggregateAverageStandingRButton.Checked)
                result = original_teachers.Average(t => t.Standing);
            else
                result = original_teachers.Average(t => DateTime.Now.Year - t.Birthday.Year);

            AggregateTextBox.Text = ((double)result).ToString();
        }

        private void GroupButton_Click(object sender, EventArgs e)
        {
            IEnumerable<IGrouping<String, Teacher>> result = null;
            if (GroupSurnameRButton.Checked)
                result = original_teachers.GroupBy(x => x.Surname).OrderByDescending(x => x.Count()).ToArray();
            else if (GroupTitleRButton.Checked)
                result = original_teachers.GroupBy(x => x.Title).OrderByDescending(x => x.Count()).ToArray();
            else
                result = original_teachers.GroupBy(x => x.Cathedra.ToString()).OrderByDescending(x => x.Count()).ToArray();
            
            teachers.Clear();
            foreach (var key in result)
            {
                foreach (var elem in key)
                {
                    teachers.Add(elem);
                }
            }

            OutputList(teachers);
        }
    }
}
