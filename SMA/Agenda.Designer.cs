namespace SMA
{
    partial class Agenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.dtgAgenda = new System.Windows.Forms.DataGridView();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbConsultar = new System.Windows.Forms.ComboBox();
            this.txtConsultaPorNombre = new System.Windows.Forms.TextBox();
            this.lblConsultaNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtIdentificacionAux = new System.Windows.Forms.TextBox();
            this.txtNombreAux = new System.Windows.Forms.TextBox();
            this.txtEmailAux = new System.Windows.Forms.TextBox();
            this.txtEliminarAux = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAgenda
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            this.dtgAgenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgAgenda.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificacion,
            this.Nombres,
            this.Email,
            this.Telefono});
            this.dtgAgenda.Location = new System.Drawing.Point(28, 221);
            this.dtgAgenda.Name = "dtgAgenda";
            this.dtgAgenda.Size = new System.Drawing.Size(563, 125);
            this.dtgAgenda.TabIndex = 0;
            this.dtgAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgAgenda_CellContentClick);
            // 
            // Identificacion
            // 
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.MaxInputLength = 38888;
            this.Identificacion.Name = "Identificacion";
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 120;
            // 
            // cmbConsultar
            // 
            this.cmbConsultar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbConsultar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbConsultar.FormattingEnabled = true;
            this.cmbConsultar.Items.AddRange(new object[] {
            "Todos",
            "Hombres",
            "Mujeres"});
            this.cmbConsultar.Location = new System.Drawing.Point(400, 43);
            this.cmbConsultar.Name = "cmbConsultar";
            this.cmbConsultar.Size = new System.Drawing.Size(144, 21);
            this.cmbConsultar.TabIndex = 1;
            // 
            // txtConsultaPorNombre
            // 
            this.txtConsultaPorNombre.Location = new System.Drawing.Point(405, 144);
            this.txtConsultaPorNombre.Name = "txtConsultaPorNombre";
            this.txtConsultaPorNombre.Size = new System.Drawing.Size(139, 20);
            this.txtConsultaPorNombre.TabIndex = 2;
            // 
            // lblConsultaNombre
            // 
            this.lblConsultaNombre.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblConsultaNombre.AutoSize = true;
            this.lblConsultaNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblConsultaNombre.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaNombre.ForeColor = System.Drawing.Color.Blue;
            this.lblConsultaNombre.Location = new System.Drawing.Point(401, 110);
            this.lblConsultaNombre.Name = "lblConsultaNombre";
            this.lblConsultaNombre.Size = new System.Drawing.Size(142, 19);
            this.lblConsultaNombre.TabIndex = 3;
            this.lblConsultaNombre.Text = "Consulta Por Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(401, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consulta Por Tipo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Blue;
            this.btnEliminar.Image = global::SMA.Properties.Resources.delete_delete_deleteusers_delete_male_user_maleclient_2348;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(289, 9);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 81);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Blue;
            this.btnModificar.Image = global::SMA.Properties.Resources.edit_icon_icons_com_66118;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.Location = new System.Drawing.Point(289, 96);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 94);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // txtIdentificacionAux
            // 
            this.txtIdentificacionAux.Location = new System.Drawing.Point(146, 34);
            this.txtIdentificacionAux.Name = "txtIdentificacionAux";
            this.txtIdentificacionAux.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificacionAux.TabIndex = 7;
            // 
            // txtNombreAux
            // 
            this.txtNombreAux.Location = new System.Drawing.Point(146, 70);
            this.txtNombreAux.Name = "txtNombreAux";
            this.txtNombreAux.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAux.TabIndex = 8;
            // 
            // txtEmailAux
            // 
            this.txtEmailAux.Location = new System.Drawing.Point(146, 109);
            this.txtEmailAux.Name = "txtEmailAux";
            this.txtEmailAux.Size = new System.Drawing.Size(100, 20);
            this.txtEmailAux.TabIndex = 9;
            // 
            // txtEliminarAux
            // 
            this.txtEliminarAux.Location = new System.Drawing.Point(146, 144);
            this.txtEliminarAux.Name = "txtEliminarAux";
            this.txtEliminarAux.Size = new System.Drawing.Size(100, 20);
            this.txtEliminarAux.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(24, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(24, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(24, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(24, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Identificacion";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Image = global::SMA.Properties.Resources.go_back256_248561;
            this.btnVolver.Location = new System.Drawing.Point(28, 352);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(60, 40);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMA.Properties.Resources.estampado_dentista_diseno_plano_23_2148110792;
            this.ClientSize = new System.Drawing.Size(603, 414);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEliminarAux);
            this.Controls.Add(this.txtEmailAux);
            this.Controls.Add(this.txtNombreAux);
            this.Controls.Add(this.txtIdentificacionAux);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConsultaNombre);
            this.Controls.Add(this.txtConsultaPorNombre);
            this.Controls.Add(this.cmbConsultar);
            this.Controls.Add(this.dtgAgenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agenda";
            this.Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAgenda;
        private System.Windows.Forms.ComboBox cmbConsultar;
        private System.Windows.Forms.TextBox txtConsultaPorNombre;
        private System.Windows.Forms.Label lblConsultaNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtIdentificacionAux;
        private System.Windows.Forms.TextBox txtNombreAux;
        private System.Windows.Forms.TextBox txtEmailAux;
        private System.Windows.Forms.TextBox txtEliminarAux;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Button btnVolver;
    }
}