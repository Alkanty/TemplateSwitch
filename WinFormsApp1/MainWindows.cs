namespace WinFormsApp1
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Creation d'un nouvel objet OpenFileDialog appelé OpenBox
            OpenFileDialog OpenBox = new OpenFileDialog();
            OpenBox.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            OpenBox.Title = "Choisir un fichier texte";

            if (OpenBox.ShowDialog() == DialogResult.OK)
            {
                // Lire le contenu du fichier et l’afficher dans la TextBox
                string contenu = System.IO.File.ReadAllText(OpenBox.FileName);
                textVisualBox.Text = contenu;  
            }
        }
    }
}
