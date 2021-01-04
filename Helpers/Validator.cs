using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System_Demo
{
    public class Validator
    {
        public const string Warning = "This field is required!";
        public static bool ValidirajPolje(Control kontrola,ErrorProvider err,string Warning)
        {
            bool validno = true;
            if (kontrola is TextBox && string.IsNullOrEmpty(kontrola.Text))
                validno = false;
            else if (kontrola is ComboBox && (kontrola as ComboBox).SelectedIndex < 0)
                validno = false;
            else if (kontrola is PictureBox && (kontrola as PictureBox).Image == null)
                validno = false;
            else if (kontrola is RichTextBox && string.IsNullOrEmpty((kontrola as RichTextBox).Text))
                validno = false;

            if(!validno)
            {
                err.SetError(kontrola,Warning);
                return false;
            }else
            {
                err.Clear();
                return true;
            }
        }


        //public static void SveUredu(Control kontrola,ErrorProvider valid,bool JelValidno)
        //{
        //    if(JelValidno)
        //    {
        //        valid.SetIconAlignment(kontrola, ErrorIconAlignment.BottomRight);
        //        valid.SetError(kontrola, "All fields are okay!");
        //    }
        //}
    }
}
