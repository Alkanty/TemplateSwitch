using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
