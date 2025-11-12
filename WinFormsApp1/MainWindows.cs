

using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing.Text;
using WinFormsApp1.Services;

////NOMENCLATURE////
//NAMESPACE + CLASS + METHOD = PascalCase
// VARIABLE = LOWER CASE or camelCase
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
        public string _selection3;

        public string jsonPath;

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

             _selection3 = Writting.WriteSelectedItemInbox(comboBox_Version);
        }


        //TEXTBOX FOR PATH LABEL
        private void label_Path_Click(object sender, EventArgs e)
        {

        }

        //BUTTON FOR SAVING FILE ON CLICK
        private void button_Save_Click(object sender, EventArgs e)
        {
            Edition.SaveFile(textVisualBox);
        }


        //TEXTBOX FOR HOSTNAME
        private void textbox_Hostname_Click(object sender, EventArgs e)
        {

        }

        //BUTTON FOR HOSTNAME GENERATION ON CLICK
        private void button_Hostname_Click(object sender, EventArgs e)
        {
            // Path of the JSON
            jsonPath = Path.Combine(Edition.maindirpath,"ConstructorTemplates",_selection1,_selection2,_selection3, "config.json");

            //read the json file
            Writting.WriteJsonInbox(textbox_Hostname, textVisualBox,jsonPath,typeof(SystemName));
        }
    }
}

