using Microsoft.VisualBasic.FileIO;
using System;
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
        //var to get local usersession name
        static string username = Environment.UserName;
        //var for local path for templates
        static string local_template_path = $"C:\\Users\\{username}\\AppData\\Local\\WinformApp\\Templates";

        public static void NewTemplate()
        {
            //create local directory for templates 
            string newfile = "New_template.txt";
            Directory.CreateDirectory(local_template_path);

            if (File.Exists($"{local_template_path}\\{newfile}") == true) { MessageBox.Show("Debug : Le fichier existe"); }
            else { MessageBox.Show("Debug : Le fichier n'existe pas,création en cours...");File.Create($"{local_template_path}\\{newfile}");}
        }

        public static void OpenFileBox(System.Windows.Forms.TextBox box)
        {
            // Creation of a new object OpenFileDialog called OpenBox
            OpenFileDialog OpenBox = new OpenFileDialog();
            OpenBox.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            OpenBox.Title = "Choisir un fichier texte";

            if (OpenBox.ShowDialog() == DialogResult.OK)
            {
                // read the content of a file and show it on the text box.
                string contenu = System.IO.File.ReadAllText(OpenBox.FileName);
                box.Text = contenu;

            }


        }
    }
}

    

