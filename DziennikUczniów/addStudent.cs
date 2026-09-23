using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DziennikUczniów
{
    
    public partial class addStudent : Form
    {
        private FileHelper<List<Student>> _fileHelper = new FileHelper<List<Student>>(Program.FilePath);


        private int _studentdId = 0;
        private Student _student;
        
        public addStudent( int id = 0)
        {
            InitializeComponent();

            _studentdId = id;
            getStudentDate();
            boxName.Select();
        }

        private void getStudentDate()
        {
            if (_studentdId != 0)
            {
                Text = "Edytowanie danych ucznia";
                var students = _fileHelper.DeserializeFromFile();
                _student = students.FirstOrDefault(x => x.Id == _studentdId);

                if (_student == null)
                {
                    throw new Exception("Brak użytkownika o podanym id");
                }

                FillTextBoxes();
            }
        }

        private void FillTextBoxes()
        {
            boxId.Text = _student.Id.ToString();
            boxName.Text = _student.FirstName;
            boxLastname.Text = _student.LastName;
            boxMath.Text = _student.Math;
            boxPhysic.Text = _student.Physics;
            boxPol.Text = _student.PolishLang;
            rchNotes.Text = _student.Comments;
            boxObcy.Text = _student.ForeignLang;
            boxTech.Text = _student.Technology;
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var students = _fileHelper.DeserializeFromFile();

            if (_studentdId != 0)
            {
                // EDYCJA
                var student = students.FirstOrDefault(x => x.Id == _studentdId);

                if (student == null)
                {
                    MessageBox.Show("Nie znaleziono studenta.");
                    return;
                }

                student.FirstName = boxName.Text;
                student.LastName = boxLastname.Text;
                student.Math = boxMath.Text;
                student.Technology = boxTech.Text;
                student.Physics = boxPhysic.Text;
                student.PolishLang = boxPol.Text;
                student.ForeignLang = boxObcy.Text;
                student.Comments = rchNotes.Text;
            }

            else
            {
                // DODAWANIE
                AssignIdToNewStudent(students);
                AddNewUserToList(students);

            }

            _fileHelper.SerializeToFile(students);
            
            Close();
        }
        private void AssignIdToNewStudent(List<Student>students)
        {
            var lastStudent = students
                    .OrderByDescending(x => x.Id)
                    .FirstOrDefault();

            _studentdId = lastStudent == null ? 1 : lastStudent.Id + 1;
        }

         private void AddNewUserToList(List<Student>students)
         {
            var student = new Student
            {
                Id = _studentdId,
                FirstName = boxName.Text,
                LastName = boxLastname.Text,
                Math = boxMath.Text,
                Technology = boxTech.Text,
                Physics = boxPhysic.Text,
                PolishLang = boxPol.Text,
                ForeignLang = boxObcy.Text,
                Comments = rchNotes.Text
            };

            students.Add(student);
        }
    }
}
