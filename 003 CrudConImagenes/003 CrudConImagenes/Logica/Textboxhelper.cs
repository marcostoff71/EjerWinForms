using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _003_CrudConImagenes.Logica
{
    public static class Textboxhelper
    {
        public static void SoloNumerosEnteros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)||
                char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public static void SoloNumerosDecimales(TextBox text,KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)||char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }else if (e.KeyChar == '.'&&text.Text.IndexOf(".")==-1&&text.Text.Length!=0)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
                
        }
        public static bool EsValidoLetras(this TextBox text)
        {
            text.Text = text.Text.Trim();
            if (string.IsNullOrEmpty(text.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public static bool EsValidoNumEntero(this TextBox textBox)
        {
            textBox.Text = textBox.Text.Trim();

            if (string.IsNullOrEmpty(textBox.Text)==false&&
                int.TryParse(textBox.Text,out int num))
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}
