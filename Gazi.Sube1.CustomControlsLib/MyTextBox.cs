using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazi.Sube1.CustomControlsLib
{
    public enum WorkMode
    {
        Harf,
        Sayi,
        Normal
    }
    public class MyTextBox : TextBox
    {
        int[] dizi = { 231, 199, 351, 350, 287, 286, 252, 220, 304, 305, 246, 214, 8, 32 };

        public WorkMode CalismaModu { get; set; }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {           
            switch (CalismaModu)
            {
                case WorkMode.Harf:
                    if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || dizi.Contains(e.KeyChar))
                    {
                        base.OnKeyPress(e);
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case WorkMode.Sayi:

                    break;
                case WorkMode.Normal:
                    base.OnKeyPress(e);
                    break;
                default:
                    break;
            }

            
        }
    }
}
