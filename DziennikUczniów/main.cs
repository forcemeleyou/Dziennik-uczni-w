namespace DziennikUczniów
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();

            string path = $@"{Path.GetDirectoryName(Application.ExecutablePath)}\..\plikDoZapisu.txt";

            if (!File.Exists(path))
            {
                File.Create(path);  // --> tworzy nowy plik
            }

            //File.Delete(path); --> usuwa plik
            //File.WriteAllText(path, "Zostań programistą .net");   --> nadpisuje tekst
            //File.AppendAllText(path, "Akademia .net\n");     --> dopisuje tekst


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdyt_Click(object sender, EventArgs e)
        {

        }

        private void btnDelate_Click(object sender, EventArgs e)
        {

        }

        private void btnReflesh_Click(object sender, EventArgs e)
        {

        }
    }
}
