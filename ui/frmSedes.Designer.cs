namespace appPlanilla_2023.ui
{
    partial class frmSedes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSedes));
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.cboDistritos = new System.Windows.Forms.ComboBox();
            this.txtNS = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNombreSede = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblDepa = new System.Windows.Forms.Label();
            this.lblProv = new System.Windows.Forms.Label();
            this.lblDis = new System.Windows.Forms.Label();
            this.lblEstad = new System.Windows.Forms.Label();
            this.textDirecion = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            resources.ApplyResources(this.cboDepartamento, "cboDepartamento");
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            resources.ApplyResources(this.cboProvincia, "cboProvincia");
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.SelectedIndexChanged += new System.EventHandler(this.cboProvincia_SelectedIndexChanged);
            // 
            // cboDistritos
            // 
            this.cboDistritos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistritos.FormattingEnabled = true;
            resources.ApplyResources(this.cboDistritos, "cboDistritos");
            this.cboDistritos.Name = "cboDistritos";
            // 
            // txtNS
            // 
            resources.ApplyResources(this.txtNS, "txtNS");
            this.txtNS.Name = "txtNS";
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
            // 
            // lblNombreSede
            // 
            resources.ApplyResources(this.lblNombreSede, "lblNombreSede");
            this.lblNombreSede.Name = "lblNombreSede";
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.Name = "lblID";
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            resources.ApplyResources(this.btnEliminar, "btnEliminar");
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            resources.ApplyResources(this.btnEditar, "btnEditar");
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            resources.ApplyResources(this.btnNuevo, "btnNuevo");
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtBuscar
            // 
            resources.ApplyResources(this.txtBuscar, "txtBuscar");
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToDeleteRows = false;
            this.dgvRegistros.AllowUserToResizeColumns = false;
            this.dgvRegistros.AllowUserToResizeRows = false;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.ColumnHeadersVisible = false;
            resources.ApplyResources(this.dgvRegistros, "dgvRegistros");
            this.dgvRegistros.MultiSelect = false;
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.RowHeadersVisible = false;
            this.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistros.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellEnter);
            // 
            // lblDireccion
            // 
            resources.ApplyResources(this.lblDireccion, "lblDireccion");
            this.lblDireccion.Name = "lblDireccion";
            // 
            // lblDepa
            // 
            resources.ApplyResources(this.lblDepa, "lblDepa");
            this.lblDepa.Name = "lblDepa";
            // 
            // lblProv
            // 
            resources.ApplyResources(this.lblProv, "lblProv");
            this.lblProv.Name = "lblProv";
            // 
            // lblDis
            // 
            resources.ApplyResources(this.lblDis, "lblDis");
            this.lblDis.Name = "lblDis";
            // 
            // lblEstad
            // 
            resources.ApplyResources(this.lblEstad, "lblEstad");
            this.lblEstad.Name = "lblEstad";
            // 
            // textDirecion
            // 
            resources.ApplyResources(this.textDirecion, "textDirecion");
            this.textDirecion.Name = "textDirecion";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            resources.ApplyResources(this.cboEstado, "cboEstado");
            this.cboEstado.Name = "cboEstado";
            // 
            // frmSedes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textDirecion);
            this.Controls.Add(this.txtNS);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblEstad);
            this.Controls.Add(this.lblDis);
            this.Controls.Add(this.lblProv);
            this.Controls.Add(this.lblDepa);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombreSede);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.cboDistritos);
            this.Controls.Add(this.cboProvincia);
            this.Controls.Add(this.cboDepartamento);
            this.Name = "frmSedes";
            this.Load += new System.EventHandler(this.frmSedes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.ComboBox cboDistritos;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNombreSede;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblDepa;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.Label lblDis;
        private System.Windows.Forms.Label lblEstad;
        private System.Windows.Forms.TextBox textDirecion;
        private System.Windows.Forms.ComboBox cboEstado;
    }
}