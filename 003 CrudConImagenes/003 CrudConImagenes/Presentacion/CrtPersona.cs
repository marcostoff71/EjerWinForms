using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _003_CrudConImagenes.Modelos;
using _003_CrudConImagenes.Modelos.AccesoDb;
using _003_CrudConImagenes.Logica;
using _003_CrudConImagenes.Presentacion;
using System.IO;

namespace _003_CrudConImagenes.Presentacion
{
    public partial class CrtPersona : UserControl
    {
        private readonly AccesoDatosPersona _acceso;
        private string ruta = "";
        private Persona auxPersona;



        public CrtPersona()
        {
            this._acceso = new AccesoDatosPersona();
            InitializeComponent();
            InicalizarDgv();
            Refrescar();

        }
        #region helpers
        private byte[] ObtieneImagen()
        {
            byte[] image;
            if (auxPersona == null)
            {
                image = ImagenesHelper.ObtieneBytesDeRuta(ruta);
            }
            else
            {
                if (ruta == "")
                {
                    image = this.auxPersona.foto;
                }
                else
                {
                    image = ImagenesHelper.ObtieneBytesDeRuta(ruta);
                }
            }

            return image;
        }
        private string ObtieneNombre()
        {
            string nombre="";
            if (auxPersona == null)
            {
                nombre = picImagenUsuario.Name;

            }
            else
            {
                if (ruta == "")
                {
                    nombre = auxPersona.nombreFoto;
                }
                else
                {
                    nombre = picImagenUsuario.Name;
                }
            }

            return nombre;
        }

        public void InicalizarDgv()
        {
            Dise.DiseDgv.Dise1BlancoDgv(dgvDatos);
        }
        public void Refrescar()
        {
            dgvDatos.DataSource = _acceso.Obtener();
            dgvDatos.Columns["foto"].Visible = false;
        }
        #endregion

        #region operaciones
        private void LimpiaCampos()
        {
            this.ruta = string.Empty;
            picImagenUsuario.Image = null;
            txtNombre.Clear();
            txtApeMaterno.Clear();
            txtApePaterno.Clear();
            cbxSexo.SelectedIndex = -1;
            dtpFechaNaci.Value = DateTime.Now;


            if (auxPersona != null) auxPersona = null;

        }
        private void CargaDatos(int id)
        {
            Persona per = this._acceso.ObtenerPorId(id);
            if (per != null)
            {
                this.auxPersona = per;
                txtNombre.Text = per.nombre;
                txtApeMaterno.Text = per.apellidoMaterno;
                txtApePaterno.Text = per.apellidoPaterno;
                dtpFechaNaci.Value = per.fechaNacimiento;
                picImagenUsuario.Image = ImagenesHelper.obtenerImagenDeBytes(per.foto);
                pnlRegistro.Visible = true;
                
            }
            else
            {
                Refrescar();
            }
        }
        #endregion


        private void btnCargaImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Multiselect = false;
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            file.FilterIndex = 0;
            file.Filter = "Archivos de image(*.jpg)|*jpg";

            if (file.ShowDialog() == DialogResult.OK)
            {
               this.ruta = file.FileName;
               Image img=ImagenesHelper.ObtenerImageDeRuta(ruta);
                picImagenUsuario.Image = img;
                picImagenUsuario.Name = Path.GetFileName(ruta);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtNombre.EsValidoLetras()

                &&txtApePaterno.EsValidoLetras()&&

                txtApeMaterno.EsValidoLetras()&&
                cbxSexo.SelectedIndex >= 0 &&
                dtpFechaNaci.Value < DateTime.Now&&
                picImagenUsuario.Image!=null)
            {
                bool corre = false;


                Persona per = new Persona();
                per.nombre = txtNombre.Text;
                per.apellidoMaterno = txtApeMaterno.Text;
                per.apellidoPaterno = txtApePaterno.Text;
                per.fechaNacimiento = dtpFechaNaci.Value;
                per.edad = (byte)(DateTime.Now.Subtract(per.fechaNacimiento).Days / 356);
                per.foto = ObtieneImagen();
                per.nombreFoto = ObtieneNombre();

                if (auxPersona == null)
                {
                    corre=this._acceso.Agregar(per);
                }
                else
                {
                    per.id = this.auxPersona.id;
                    corre=this._acceso.Modificar(per);
                   
                }

                if (corre)
                {
                    pnlRegistro.Visible = false;
                    LimpiaCampos();
                    Refrescar();

                }
            }
        }

        private void btnAgregarPnl_Click(object sender, EventArgs e)
        {
            pnlRegistro.Visible = true;
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1 &&
                dgvDatos.Rows!=null&&
                e.RowIndex >= 0)
            {
                int id = int.Parse(dgvDatos.Rows[e.RowIndex].Cells[2].Value.ToString());

                if (e.ColumnIndex == 0)
                {
                    CargaDatos(id);
                }else if (e.ColumnIndex == 1)
                {
                    MessageBox.Show("Modificar");

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiaCampos();
            pnlRegistro.Visible = false;
        }
    }
}
