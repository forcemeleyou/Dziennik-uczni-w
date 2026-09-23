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
        private string _filePath = Path.Combine(Environment.CurrentDirectory, "students.txt");

        private int _studentdId = 0;
        public void SerializeToFile(List<Student> students)
        {
            var serializer = new XmlSerializer(typeof(List<Student>));

            using (var streamWriter = new StreamWriter(_filePath))
            {
                serializer.Serialize(streamWriter, students);
                streamWriter.Close();
            }
        }

        public List<Student> DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Student>();
            }
            var serializer = new XmlSerializer(typeof(List<Student>));

            using (var streamReader = new StreamReader(_filePath))
            {
                var students = (List<Student>)serializer.Deserialize(streamReader);
                streamReader.Close();

                return students;
            }
        }
        public addStudent( int id = 0)
        {
            InitializeComponent();

            _studentdId = id;
            if(id != 0)
            {
                var students = DeserializeFromFile();
                var student = students.FirstOrDefault(x => x.Id == id);

                if(student == null)
                {
                    throw new Exception("Brak użytkownika o podanym id");
                }

                boxId.Text = student.Id.ToString();
                boxName.Text = student.FirstName;
                boxLastname.Text = student.LastName;
                boxMath.Text = student.Math;
                boxPhysic.Text = student.Physics;
                boxPol.Text = student.PolishLang;
                rchNotes.Text = student.Comments;
                boxObcy.Text = student.ForeignLang;
                boxTech.Text = student.Technology;
            }
            boxName.Select();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var students = DeserializeFromFile();

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
                var lastStudent = students
                    .OrderByDescending(x => x.Id)
                    .FirstOrDefault();

                _studentdId = lastStudent == null ? 1 : lastStudent.Id + 1;

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

            SerializeToFile(students);
            
            Close();
        }
    }
}
