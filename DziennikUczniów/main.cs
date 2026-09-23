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

        private FileHelper<List<Student>> _fileHelper = new FileHelper<List<Student>>(Program.FilePath);
        public main()
        {
            InitializeComponent();
            Reload();
            setColumnHeader();

            var list1 = new List<string>();
            var list2 = new List<int>();
            var list3 = new List<Student>();



        }

        private void setColumnHeader()
        {
            dgvDiary.Columns[0].HeaderText = "Numer";
            dgvDiary.Columns[1].HeaderText = "Imię";
            dgvDiary.Columns[3].HeaderText = "Nazwisko";
            dgvDiary.Columns[4].HeaderText = "Uwagi";
            dgvDiary.Columns[5].HeaderText = "Matematyka";
            dgvDiary.Columns[6].HeaderText = "Technologia";
            dgvDiary.Columns[7].HeaderText = "Język Polski";
            dgvDiary.Columns[8].HeaderText = "Język Obcy";
        }
        private void Reload()
        {
            var students = _fileHelper.DeserializeFromFile();
            dgvDiary.DataSource = null;
            dgvDiary.DataSource = students;
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
                    DeleteStudent(Convert.ToInt32(SelectedRow.Cells[0].Value));
                    Reload();
                }
            }
            else
            {
                MessageBox.Show("Najpierw zaznacz ucznia!");
                return;
            }
        }

        private void DeleteStudent(int id)
        {
            var students = _fileHelper.DeserializeFromFile();
            students.RemoveAll(x => x.Id == id);
            _fileHelper.SerializeToFile(students);
        }

        private void btnReflesh_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
