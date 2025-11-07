

using System;
using System.Diagnostics;
using System.Drawing.Text;
using WinFormsApp1.Services;

////NOMENCLATURE////
//NAMESPACE + CLASS + METHOD = PASCAL CASE
// VARIABLE = LOWER CASE
// COMMENT ALWAYS ON ONE LINE : BRIEF IN ONE SENTENCE ON TOP OF THE ELEMENT DESCRIBE
//COMMENT OF METHOD CAPITAL LETTER COMMENT OF CODE LOWERCASE
// {} JUMP A LIGNE AFTER LINKED CLASS/METHOD/LOOP BMUT SAME LEVEL +
// INDENTING AFTER {}
// CONDITION EXCEPTION(switch,if,) : ALL ON ONE LINE EXCEPT IF TOO LONG


namespace WinFormsApp1
{
    public partial class MainWindows : Form
    {
        //CLASS VARIABLE
        public string _selection1;
        public string _selection2;
        public MainWindows()
        {
            InitializeComponent();
        }

        //METHOD WHEN LOADING
        private void Form1_Load(object sender, EventArgs e)
        {
            Edition.LoadFileConstructor(comboBox_Constructor);

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
            label_Path.Text = Edition.currentfilepath ?? "No file opened.";
        }

        //BUTTON FOR EDITING ON CLICK
        private void button2_Click(object sender, EventArgs e)

        {
            //appel de la methode pour ouvrir l'onglet de chargement fichier + affichage dans textbox 
            Edition.OpenFileBox(textVisualBox);

            label_Path.Text = Edition.currentfilepath ?? "No file opened.";
        }

        //BUTTON FOR OPENING DEBUG FILE ON CLICK
        private void button_debug_Click(object sender, EventArgs e)
        {
            Logger.ButtonLog();
        }

        //SCROLL DOWN LIST FOR CHOOSING CONSTRUCTOR TYPE
        private void comboBox_Constructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selection1 = Writting.WriteSelectedItemInbox(comboBox_Constructor, comboBox_Model, comboBox_Version);
            Edition.LoadFileModel(_selection1, comboBox_Model);

        }

        //SCROLL DOWN LIST FOR CHOOSING MODEL TYPE
        private void comboBox_Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selection2 = Writting.WriteSelectedItemInbox(comboBox_Model, comboBox_Version);
            Edition.LoadFileVersion(_selection1, _selection2, comboBox_Version);
        }

        //SCROLL DOWN LIST FOR CHOOSING VERSION TYPE
        private void comboBox_Version_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selection = Writting.WriteSelectedItemInbox(comboBox_Version);
        }

        //TEXTBOX FOR HOSTNAME
        private void textbox_Hostname_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //PATH LABEL
        private void label_Path_Click(object sender, EventArgs e)
        {

        }
    }
}

