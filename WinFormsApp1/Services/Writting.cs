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

        public static void WriteJsonInbox(System.Windows.Forms.TextBox box, System.Windows.Forms.TextBox boxVisual, string jsonPath,Type classType)
        {

            //read the json file

            //root object 
            Root config = Writting.DeserializeJson(jsonPath);
            if (config == null) return;


            // get number of variable in classType (only for debbuging)
            int count = classType.GetProperties().Length;
            Logger.WriteLog($"DEBUG:number of variable in class :{count}");

            //get the name of the property associated to the class ("SystemName" → "systemname")
            string propertyName = classType.Name.ToLower();

            //Create a table with all properties of root object (systemname,dhcpserver...) within all the classes. and it gives back first match with propertyName
            var prop = typeof(Root).GetProperties().FirstOrDefault(p => p.Name.Equals(propertyName));

            //check if the property exist in object
            if (prop == null)
            {
                Logger.WriteLog($"⚠️ Impossible de trouver {propertyName} dans Root\r\n");
                return;
            }

            // get the sub-object  (config.systemname)
            var subObject = prop.GetValue(config);

            // read all properties 
            foreach (var p in classType.GetProperties())
            {
                //get back value of property in sub-object
                string value = p.GetValue(subObject)?.ToString() ?? "";
                value = value.Replace("{name}", box.Text); // remplace les placeholders si besoin
                boxVisual.AppendText(value + "\r\n");
            }
        }

        }

        }

