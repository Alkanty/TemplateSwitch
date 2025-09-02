

using WinFormsApp1.Services;

////NOMENCLATURE////
//NAMESPACE + CLASS + METHOD = PASCAL CASE
// VARIABLE = LOWER CASE
// COMMENT ALWAYS ON ONE LINE : BRIEF IN ONE SENTENCE ON TOP OF THE ELEMENT DESCRIBE
//COMMENT OF METHOD CAPITAL LETTER COMMENT OF CODE LOWERCASE
// {} JUMP A LIGNE AFTER LINKED CLASS/METHOD/LOOP BUT SAME LEVEL +
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        //TEXTBOX FOR VISUAL 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edition.NewTemplate();
        }

        //BUTTON FOR EDITING
        private void button2_Click(object sender, EventArgs e)
         
        {
            //appel de la methode pour ouvrir l'onglet de chargement fichier + affichage dans textbox 
            Edition.OpenFileBox(textVisualBox);
        }
    }
}
