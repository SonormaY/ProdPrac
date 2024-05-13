using System.Windows.Forms;

namespace TaskLast
{
    public partial class Form1 : Form
    {
        List<Course> courses = new List<Course>();
        private string filePath { get; set; } = "None";

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents (*.txt)|*.txt|All files (*.*)|*.*", ValidateNames = true, Multiselect = false, InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) })
            {
                if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
                {
                    filePath = ofd.FileName;
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');
                            Course course = new Course(parts[0], parts[1], int.Parse(parts[2]));
                            courses.Add(course);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a file.");
                }
            }
            UpdateFilePathLabel();
            UpdateTable();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            courses.Clear();
            UpdateTable();
            MessageBox.Show("List is cleared.");
        }

        private void debug_Click(object sender, EventArgs e)
        {
            string message = "";
            foreach (Course course in courses)
            {
                message += course.ToString() + "\n";
            }
            MessageBox.Show(message);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                string message = "";
                foreach (Course course in courses)
                {
                    message += course.ToFile() + "\n";
                }
                File.WriteAllText(filePath, message);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents (*.txt)|*.txt|All files (*.*)|*.*", ValidateNames = true, InitialDirectory = "%USERPROFILE%/Desktop" })
            {
                if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
                {
                    filePath = sfd.FileName;
                    string message = "";
                    foreach (Course course in courses)
                    {
                        message += course.ToFile() + "\n";
                    }
                    File.WriteAllText(sfd.FileName, message);
                }
            }
            UpdateFilePathLabel();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string courseName = courseNameTextBox.Text;
            string teacher = teacherTextBox.Text;
            int.TryParse(hoursTextBox.Text, out int hours);
            courseNameTextBox.Text = "";
            teacherTextBox.Text = "";
            hoursTextBox.Text = "";
            if (!string.IsNullOrEmpty(courseName) && !string.IsNullOrEmpty(teacher) && hours != 0)
            {
                Course course = new Course(courseName, teacher, hours);
                courses.Add(course);
                MessageBox.Show("Course added.");
            }
            else
            {
                MessageBox.Show("Please fill all the fields correctly.");
            }
            UpdateTable();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string search = searchTextBox.Text;
            searchTextBox.Text = "";
            if (!string.IsNullOrEmpty(search))
            {
                string message = "";
                foreach (Course course in courses)
                {
                    if (course.ToString().Contains(search))
                    {
                        message += course.ToString() + "\n";
                    }
                }
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Please enter a search term.");
            }
        }

        private void UpdateFilePathLabel()
        {
            filePathLabel.Text = $"Currently opened file: {filePath}";
        }
        private void UpdateTable()
        {
            dataTable.Rows.Clear();
            foreach (Course course in courses)
            {
                dataTable.Rows.Add(course.CourseName, course.Teacher, course.Hours);
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (courseNameRadioButton.Checked)
            {
                courses = courses.OrderBy(x => x.CourseName).ToList();
            }
            else if (teacherRadioButton.Checked)
            {
                courses = courses.OrderBy(x => x.Teacher).ToList();
            }
            else if (hoursRadioButton.Checked)
            {
                courses = courses.OrderBy(x => x.Hours).ToList();
            }
            else
            {
                MessageBox.Show("Please select a sorting option.");
            }
            UpdateTable();
        }
    }
}
