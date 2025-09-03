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
        //var for local path 
        static string local_template_path = $"C:\\Users\\{username}\\AppData\\Local\\WinformApp\\Templates";

        public static void NewTemplate(TextBox box)
        {
            //create local directory for templates 
            FileSystem.CreateDirectory(local_template_path);
            MessageBox.Show("Debug : bouton_NewTemp a été cliqué !");

            string contenu = System.IO.File.ReadAllText(newfile);
            box.Text = contenu;
        }

        public static void OpenFileBox(TextBox box)
        {
            // Creation d'un nouvel objet OpenFileDialog appelé OpenBox
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

    

