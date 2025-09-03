using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Services
{
    public class Edition
    {
        //var to get local usersession name
        static string username = Environment.UserName;
        //var for local path 
        static string local_template_path = $"C:\\Users\\{username}\\AppData\\Local\\WinformApp\\Templates";

        public static void NewTemplate()
        {
            //create local directory for templates 
            FileSystem.CreateDirectory(local_template_path);
            MessageBox.Show("Debug : bouton_NewTemp a été cliqué !");

        }

        public static void OpenFileBox(TextBox box)
        {
            // Creation of a new object OpenFileDialog called OpenBox
            OpenFileDialog OpenBox = new OpenFileDialog();
            OpenBox.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            OpenBox.Title = "Choisir un fichier texte";

            if (OpenBox.ShowDialog() == DialogResult.OK)
            {
                // Lire le contenu du fichier et l’afficher dans la TextBox
                string contenu = System.IO.File.ReadAllText(OpenBox.FileName);
                box.Text = contenu;

            }


        }
    }
}

    

