

using System.Diagnostics;
using WinFormsApp1.Services;

////NOMENCLATURE////
//NAMESPACE + CLASS + METHOD = PASCAL CASE
// VARIABLE = LOWER CASE
// COMMENT ALWAYS ON ONE LINE : BRIEF IN ONE SENTENCE ON TOP OF THE ELEMENT DESCRIBE
//COMMENT OF METHOD CAPITAL LETTER COMMENT OF CODE LOWERCASE
// {} JUMP A LIGNE AFTER LINKED CLASS/METHOD/LOOP BMUT SAME LEVEL +
// INDENTING AFTER {}
// CONDITION EXCEPTION(switch,if,) : ALL ON ONE LINE


namespace WinFormsApp1
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        //METHOD WHEN LOADING
        private void Form1_Load(object sender, EventArgs e)
        {
            // Ici tu mets ce qui doit se passer quand on change de constructeur
            Edition.LoadFile(comboBox_Constructor);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        //TEXTBOX FOR VISUAL 
        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //BUTTON FOR NEW TEMPLATE ON CLICK
        private void button1_Click(object sender, EventArgs e)
        {
            Edition.NewTemplate(textVisualBox);
        }

        //BUTTON FOR EDITING ON CLICK
        private void button2_Click(object sender, EventArgs e)

        {
            //appel de la methode pour ouvrir l'onglet de chargement fichier + affichage dans textbox 
            Edition.OpenFileBox(textVisualBox);
        }

        //BUTTON FOR OPENING DEBUG FILE ON CLICK
        private void button_debug_Click(object sender, EventArgs e)
        {
            try
            {
                // open the log file with default text editor
                Process.Start(new ProcessStartInfo("debug_log.txt") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ouverture du fichier de log : " + ex.Message);
                Logger.WriteLog("Erreur lors de l'ouverture du fichier de log : " + ex.Message);
            }
        }

        //SCROLL DOWN LIST FOR CHOOSING CONSTRUCTOR TYPE
        private void comboBox_Constructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ici tu mets ce qui doit se passer quand on change de constructeur
            Edition.LoadFile(comboBox_Constructor);
        }

        //SCROLL DOWN LIST FOR CHOOSING MODEL TYPE
        private void comboBox_Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ici tu mets ce qui doit se passer quand on change de modèle
            MessageBox.Show("Tu as changé de modèle !");
        }

        //SCROLL DOWN LIST FOR CHOOSING VERSION TYPE
        private void comboBox_Version_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ici tu mets ce qui doit se passer quand on change de modèle
            MessageBox.Show("Tu as changé de modèle !");
        }


    }
}
