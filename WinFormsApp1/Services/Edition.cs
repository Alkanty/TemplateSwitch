using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
 
namespace WinFormsApp1.Services
{
    public class Edition
    {
        //var to get main directory
        static string main_dir_path = AppContext.BaseDirectory;

        //var for local path for templates
        static string local_template_path = $"C:\\Users\\{username}\\AppData\\Local\\WinformApp\\Templates";

        //var to get local usersession name
        static string username = Environment.UserName;

        //var for Path constructor
        static string local_constructor_path = Path.Combine(Directory.GetParent(main_dir_path)!.Parent!.Parent!.Parent!.FullName,"ConstructorTemplates");


        //METHOD FOR CREATING A NEW BLANK FILE AND SHOW IT IN EDITOR
        public static void NewTemplate(System.Windows.Forms.TextBox box)
        {
            //create local directory for templates 
            string newfile = "New_template.txt";
            Directory.CreateDirectory(local_template_path);

            //if file exist nothing else create it
            if (File.Exists($"{local_template_path}\\{newfile}") == true) 
            { 
               Logger.WriteLog($"Debug : Le fichier {newfile} existe");
            }
            else 
            {
                Logger.WriteLog($"Debug : Le fichier {newfile} n'existe pas,création en cours..."); 
                File.Create($"{local_template_path}\\{newfile}"); 
            }

            // read the content of a file and show it on the text box.
            string contenu = File.ReadAllText($"{local_template_path}\\{newfile}");
            box.Text = contenu;

        }

        //METHOD FOR EDITING A FILE
        public static void OpenFileBox(System.Windows.Forms.TextBox box)
        {
            // Creation of a new object OpenFileDialog called OpenBox
            OpenFileDialog OpenBox = new OpenFileDialog();
            OpenBox.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            OpenBox.Title = "Choisir un fichier texte";

            //test to see if dialog box openned 
            if (OpenBox.ShowDialog() == DialogResult.OK)
            {
                // read the content of a file and show it on the text box.
                string contenu = System.IO.File.ReadAllText(OpenBox.FileName);
                box.Text = contenu;

            }


        }

        //METHOD FOR LOADING FOLDER
        public static void LoadFile(System.Windows.Forms.ComboBox box)
        {
            //clears the combo box
            box.Items.Clear();
            //if directory with the ConstructorTemplates folder exists...
            if (Directory.Exists(local_constructor_path))
            {
                //we keep all the subdirectory of ConstructorTemplates folder, we select only the names, and we put them in an array.
                var constructeur = Directory.GetDirectories(local_constructor_path).Select(path => Path.GetFileName(path)!).ToArray();

                //add the array to the box
                box.Items.AddRange(constructeur);
            }
            else { Logger.WriteLog($"Debug : Le dossier {local_constructor_path} n'existe pas");MessageBox.Show($" Le dossier {local_constructor_path} n'existe pas"); }

        }
        
    }
}


    

