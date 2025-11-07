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

        //var to the current Filepath
        public static string current_file_path; 




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
                current_file_path = OpenBox.FileName;
                string contenu = System.IO.File.ReadAllText(OpenBox.FileName);
                box.Text = contenu;

            }


        }

        // METHOD FOR SAVING A FILE
        public static void SaveFile(System.Windows.Forms.TextBox box)
        {
            //if direcoty exist we save the file
            if (!string.IsNullOrEmpty(current_file_path))
            {
                File.WriteAllText(current_file_path, box.Text);
                Logger.WriteLog($"Fichier sauvegardé : {current_file_path}");
                MessageBox.Show("Fichier enregistré !");
            }
            // if no file opened we show a messagebox
            else
            {
                MessageBox.Show("Aucun fichier ouvert à enregistrer.");
            }
        }


        //METHOD FOR LOADING FOLDER FOR CONSTRUCTOR COMBOBOX
        public static void LoadFileConstructor(System.Windows.Forms.ComboBox box)
        {
            //var for Path constructor
            string local_constructor_path = Path.Combine(Directory.GetParent(main_dir_path)!.Parent!.Parent!.Parent!.FullName,"ConstructorTemplates");
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
            else { Logger.WriteLog($"Debug : Le dossier {local_constructor_path} n'existe pas"); MessageBox.Show($" Le dossier {local_constructor_path} n'existe pas"); }

        }
        //METHOD FOR LOADING FOLDER FOR MODEL COMBOBOX 
        public static void LoadFileModel(string box, System.Windows.Forms.ComboBox box2)
        {

            //var for Path model
            string local_model_path = Path.Combine(Directory.GetParent(main_dir_path)!.Parent!.Parent!.Parent!.FullName,"ConstructorTemplates", box);
            //clears the combo box
            box2.Items.Clear();

            MessageBox.Show($" Le dossier {local_model_path} ");
            //if directory with the ConstructorTemplates folder exists...
            if (Directory.Exists(local_model_path))
            {
                //we keep all the subdirectory of ConstructorTemplates folder, we select only the names, and we put them in an array.
                var model = Directory.GetDirectories(local_model_path).Select(path => Path.GetFileName(path)!).ToArray();

                //add the array to the box
                box2.Items.AddRange(model);

            }
            else { Logger.WriteLog($"Debug : Le dossier {local_model_path} n'existe pas"); MessageBox.Show($" Le dossier {local_model_path} n'existe pas"); }
        }

        //METHOD FOR LOADING FOLDER FOR VERSION COMBOBOX 
        public static void LoadFileVersion(string box,string box2, System.Windows.Forms.ComboBox box3)
        {

            //var for Path model
            string local_model_path = Path.Combine(Directory.GetParent(main_dir_path)!.Parent!.Parent!.Parent!.FullName, "ConstructorTemplates", box,box2);
            //clears the combo box
            box3.Items.Clear();

            MessageBox.Show($" Le dossier {local_model_path} ");
            //if directory with the ConstructorTemplates folder exists...
            if (Directory.Exists(local_model_path))
            {
                //we keep all the subdirectory of ConstructorTemplates folder, we select only the names, and we put them in an array.
                var model = Directory.GetDirectories(local_model_path).Select(path => Path.GetFileName(path)!).ToArray();

                //add the array to the box
                box3.Items.AddRange(model);

            }
            else { Logger.WriteLog($"Debug : Le dossier {local_model_path} n'existe pas"); MessageBox.Show($" Le dossier {local_model_path} n'existe pas"); }
        }
    }
}


    

