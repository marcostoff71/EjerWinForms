using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _003_CrudConImagenes.Presentacion;
namespace _003_CrudConImagenes.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();


            this.Controls.Add(new CrtPersona() { Dock = DockStyle.Fill });
        }
    }
}
