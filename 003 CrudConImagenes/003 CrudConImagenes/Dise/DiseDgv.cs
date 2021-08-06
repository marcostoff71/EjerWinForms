using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace _003_CrudConImagenes.Dise
{
    public static class DiseDgv
    {
        public static void Dise1BlancoDgv(DataGridView dgv)
        {


            var estiloColuma = new DataGridViewCellStyle();
            estiloColuma.Alignment = DataGridViewContentAlignment.MiddleCenter;
            estiloColuma.Padding = new Padding(3, 3, 3, 3);
            estiloColuma.Font = new Font(FontFamily.GenericSansSerif, 9f, FontStyle.Bold, GraphicsUnit.Point);
            estiloColuma.SelectionBackColor =SystemColors.ControlDarkDark;
            estiloColuma.SelectionForeColor = Color.White;



            //dgv.ReadOnly = true;
            //dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ColumnHeadersDefaultCellStyle=estiloColuma;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, 9f, FontStyle.Regular);
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            


        }

    }
}
