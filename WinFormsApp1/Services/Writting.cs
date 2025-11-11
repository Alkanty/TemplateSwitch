using System;
using System.Collections.Generic;
using System.Linq;
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
        public static Root WriteJson(string jsonPath)
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
    }
}
