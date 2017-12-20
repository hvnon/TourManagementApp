using System;
using System.Windows.Forms;

namespace Winform
{
    public class MyCustomForm:Form
    {
        public void CheckIsNumber(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        
    }
}
