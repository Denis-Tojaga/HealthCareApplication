using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System_Demo.Helpers
{
    public class MboxHelper
    {
        public static void PrikaziGresku(Exception greska)
        {
            MessageBox.Show($"{greska.Message} \n {greska.InnerException?.Message}" , "Message for user",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public static void PrikaziInformaciju(Exception greska)
        {
            MessageBox.Show($"{greska.Message} \n {greska.InnerException?.Message}", "Information for user", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void PrikaziObavjestenje(string message) 
        {
            MessageBox.Show(message);
        }
    }
}
