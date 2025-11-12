using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WinFormsApp1.Services
{
    public class Writting
    {
        //METHOD FOR WRITTING IN SELECTED BOX
        public static string WriteSelectedItemInbox(params System.Windows.Forms.ComboBox[] box)
{
        string selectedItemInbox = box[0].SelectedItem.ToString();
        Logger.WriteLog($"DEBUG:Selected constructor: {selectedItemInbox}");

            //reset combo box selection
            foreach (var ind in box.Skip(1))
            {
             ind.Items.Clear();
             ind.Text = "";
            }
            return selectedItemInbox;
        }

        // METHOD FOR DESERIALIZING JSON FILE
        public static Root DeserializeJson(string jsonPath)
        {
            //check if file doesnt exist
            if (!File.Exists(jsonPath))
            {
                MessageBox.Show($"Le fichier JSON {jsonPath} est introuvable !");
                return null;
            }

            //read the json file
            string json = File.ReadAllText(jsonPath);

            //deserialize the json into Root object
            Root config = JsonConvert.DeserializeObject<Root>(json);

            //return the config object
            return config;
        }
        //METHOD FOR WRITTING JSON IN BOX

        public static void WriteJsonInbox(System.Windows.Forms.TextBox box, System.Windows.Forms.TextBox boxVisual, string jsonPath)
        {

            //read the json file
            Root config = Writting.DeserializeJson(jsonPath);
            if (config == null) return;

            // on récupère les commandes
            string line1 = config.system_name.line1;
            string line2 = config.system_name.line2.Replace("{name}", box.Text);

            // on les ajoute au contenu de la TextBox
            boxVisual.AppendText($"{line1}\r\n{line2}\r\n \r\n");

        }

        }
    }

