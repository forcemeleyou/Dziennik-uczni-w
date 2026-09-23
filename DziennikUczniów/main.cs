//string path = $@"{Path.GetDirectoryName(Application.ExecutablePath)}\..\plikDoZapisu.txt";

//if (!File.Exists(path))
//{
//    File.Create(path);   --> tworzy nowy plik
//}

//File.Delete(path); --> usuwa plik

//File.WriteAllText(path, "Zostań programistą .net");   --> nadpisuje tekst
//File.AppendAllText(path, "Akademia .net\n"); --> dopisuje tekst

//var text = File.ReadAllText(path); --> pobieranie całego tekstu
//MessageBox.Show(text);  --> wyswietla w okienku małym tekst

//MessageBox.Show("Test","Tytuł",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);  --> parametry messageboxa

using System.Xml.Serialization;

namespace DziennikUczniów
{
    public partial class main : Form
    {
        private string _filePath = Path.Combine(Environment.CurrentDirectory, "students.txt");
        public main()
        {
            InitializeComponent();

            var students = DeserializeFromFile();
            dgvDiary.DataSource = students;

        }
        public void Reload()
        {
            var students = DeserializeFromFile();
            dgvDiary.DataSource = null;
            dgvDiary.DataSource = students;
        }
        public void SerializeToFile(List<Student> students)
        {
            var serializer = new XmlSerializer(typeof(List<Student>));

            using(var streamWriter = new StreamWriter(_filePath))
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEditStudent = new addStudent();
            addEditStudent.ShowDialog();

        }

        private void btnEdyt_Click(object sender, EventArgs e)
        {
            if(dgvDiary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznacz ucznia którego dane chcesz edytować");
                return;
            }

            var EditStudent = new addStudent(Convert.ToInt32(dgvDiary.SelectedRows[0].Cells["Id"].Value));
            EditStudent.ShowDialog();

        }

        private void btnDelate_Click(object sender, EventArgs e)
        {
            if(dgvDiary.SelectedRows.Count == 1)
            { 
                var SelectedRow = dgvDiary.SelectedRows[0];
                var ConfrimDelate = MessageBox.Show($"Czy napewno chcesz usunąć ucznia {(SelectedRow.Cells[1].Value.ToString() + " " + SelectedRow.Cells[2].Value.ToString()).Trim()}?", "Usuwanie ucznia",MessageBoxButtons.OKCancel);
                
                if(ConfrimDelate == DialogResult.OK)
                {
                    var students = DeserializeFromFile();
                    students.RemoveAll(x => x.Id == Convert.ToInt32(SelectedRow.Cells[0].Value));
                    SerializeToFile(students);
                }

                Reload();
            }
            else
            {
                MessageBox.Show("Najpierw zaznacz ucznia!");
                return;
            }
        }

        private void btnReflesh_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
