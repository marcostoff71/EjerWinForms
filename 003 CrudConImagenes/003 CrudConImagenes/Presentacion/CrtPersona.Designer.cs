
namespace _003_CrudConImagenes.Presentacion
{
    partial class CrtPersona
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrtPersona));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarPnl = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.dtpFechaNaci = new System.Windows.Forms.DateTimePicker();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picImagenUsuario = new System.Windows.Forms.PictureBox();
            this.btnCargaImagen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAceptar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.Modificar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlRegistro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenUsuario)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.Eliminar});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 70);
            this.dgvDatos.Name = "dgvDatos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.Size = new System.Drawing.Size(881, 378);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAgregarPnl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 70);
            this.panel1.TabIndex = 1;
            // 
            // btnAgregarPnl
            // 
            this.btnAgregarPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarPnl.BackgroundImage")));
            this.btnAgregarPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarPnl.FlatAppearance.BorderSize = 0;
            this.btnAgregarPnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPnl.Location = new System.Drawing.Point(806, 8);
            this.btnAgregarPnl.Name = "btnAgregarPnl";
            this.btnAgregarPnl.Size = new System.Drawing.Size(50, 50);
            this.btnAgregarPnl.TabIndex = 2;
            this.btnAgregarPnl.UseVisualStyleBackColor = true;
            this.btnAgregarPnl.Click += new System.EventHandler(this.btnAgregarPnl_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(15, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 45);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(43, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(43, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 19);
            this.textBox1.TabIndex = 0;
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.BackColor = System.Drawing.Color.White;
            this.pnlRegistro.Controls.Add(this.dtpFechaNaci);
            this.pnlRegistro.Controls.Add(this.cbxSexo);
            this.pnlRegistro.Controls.Add(this.groupBox1);
            this.pnlRegistro.Controls.Add(this.label6);
            this.pnlRegistro.Controls.Add(this.label5);
            this.pnlRegistro.Controls.Add(this.label3);
            this.pnlRegistro.Controls.Add(this.txtApeMaterno);
            this.pnlRegistro.Controls.Add(this.label2);
            this.pnlRegistro.Controls.Add(this.txtApePaterno);
            this.pnlRegistro.Controls.Add(this.label1);
            this.pnlRegistro.Controls.Add(this.txtNombre);
            this.pnlRegistro.Controls.Add(this.menuStrip1);
            this.pnlRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistro.Location = new System.Drawing.Point(0, 70);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(881, 378);
            this.pnlRegistro.TabIndex = 2;
            this.pnlRegistro.Visible = false;
            // 
            // dtpFechaNaci
            // 
            this.dtpFechaNaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNaci.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNaci.Location = new System.Drawing.Point(537, 243);
            this.dtpFechaNaci.Name = "dtpFechaNaci";
            this.dtpFechaNaci.Size = new System.Drawing.Size(137, 24);
            this.dtpFechaNaci.TabIndex = 16;
            // 
            // cbxSexo
            // 
            this.cbxSexo.BackColor = System.Drawing.Color.White;
            this.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Otro"});
            this.cbxSexo.Location = new System.Drawing.Point(537, 289);
            this.cbxSexo.Margin = new System.Windows.Forms.Padding(1);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(137, 26);
            this.cbxSexo.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picImagenUsuario);
            this.groupBox1.Controls.Add(this.btnCargaImagen);
            this.groupBox1.Location = new System.Drawing.Point(53, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 167);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foto";
            // 
            // picImagenUsuario
            // 
            this.picImagenUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagenUsuario.Location = new System.Drawing.Point(54, 19);
            this.picImagenUsuario.Name = "picImagenUsuario";
            this.picImagenUsuario.Size = new System.Drawing.Size(137, 82);
            this.picImagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagenUsuario.TabIndex = 0;
            this.picImagenUsuario.TabStop = false;
            // 
            // btnCargaImagen
            // 
            this.btnCargaImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCargaImagen.FlatAppearance.BorderSize = 0;
            this.btnCargaImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargaImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCargaImagen.Location = new System.Drawing.Point(59, 107);
            this.btnCargaImagen.Name = "btnCargaImagen";
            this.btnCargaImagen.Size = new System.Drawing.Size(127, 38);
            this.btnCargaImagen.TabIndex = 2;
            this.btnCargaImagen.Text = "Cargar imagen";
            this.btnCargaImagen.UseVisualStyleBackColor = false;
            this.btnCargaImagen.Click += new System.EventHandler(this.btnCargaImagen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(417, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha Naci:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido Materno:";
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApeMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeMaterno.Location = new System.Drawing.Point(170, 290);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(137, 24);
            this.txtApeMaterno.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido Paterno:";
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApePaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApePaterno.Location = new System.Drawing.Point(170, 245);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(137, 24);
            this.txtApePaterno.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(170, 199);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(137, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAceptar,
            this.btnCancelar});
            this.menuStrip1.Location = new System.Drawing.Point(336, 334);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.menuStrip1.Size = new System.Drawing.Size(290, 44);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Teal;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Padding = new System.Windows.Forms.Padding(5);
            this.btnAceptar.Size = new System.Drawing.Size(78, 34);
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Teal;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 34);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Modificar.Image")));
            this.Modificar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Modificar.Name = "Modificar";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::_003_CrudConImagenes.Properties.Resources.eliminar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            // 
            // CrtPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRegistro);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.panel1);
            this.Name = "CrtPersona";
            this.Size = new System.Drawing.Size(881, 448);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagenUsuario)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox picImagenUsuario;
        private System.Windows.Forms.Button btnAgregarPnl;
        private System.Windows.Forms.Button btnCargaImagen;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaNaci;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAceptar;
        private System.Windows.Forms.ToolStripMenuItem btnCancelar;
        private System.Windows.Forms.DataGridViewImageColumn Modificar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}
