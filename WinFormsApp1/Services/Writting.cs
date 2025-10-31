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
        public static string WriteSelectedItemInbox(System.Windows.Forms.ComboBox box, object sender, EventArgs e)
{
        string selectedItemInbox = box.SelectedItem.ToString();
        Logger.WriteLog($"DEBUG:Selected constructor: {selectedItemInbox}");
            return selectedItemInbox;
        }

    }
}
