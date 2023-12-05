using appPlanilla_2023.dao;
using System;
using System.Data;
using System.Windows.Forms;

namespace appPlanilla_2023.ui
{
    public partial class frmSedes : Form
    {
        bean.Sede sede = new bean.Sede();
        dao.SedesDAO sedeDAO = new dao.SedesDAO();
        Util.Util util = new Util.Util();

        DataTable dtRegistros;
        bool bHayRegistros;
        int indexRegistro;
        bool bCombo;


        public frmSedes()
        {
            InitializeComponent();
        }

        private void frmSedes_Load(object sender, EventArgs e)
        {
            getRegistros();
            Navegar(true);

            bCombo = false;
            sedeDAO.getDepartamentos(cboDepartamento, "-- Seleccionar --");
            LimpiarCombo(cboProvincia);
            LimpiarCombo(cboDistritos);
            bCombo = true;
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bCombo && cboDepartamento.SelectedIndex > 0)
            {
                bCombo = false;
                sedeDAO.getProvincias(cboProvincia, cboDepartamento.SelectedValue, "-- Seleccionar --");
                cboDistritos.Items.Clear();
                bCombo = true;
            }
            else LimpiarCombo(cboProvincia);
            LimpiarCombo(cboDistritos);
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bCombo && cboProvincia.SelectedIndex > 0)
            {
                bCombo = false;
                sedeDAO.getDistritos(cboDistritos, cboProvincia.SelectedValue, "-- Seleccionar --");
                bCombo = true;
            }
            else LimpiarCombo(cboDistritos);
        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Navegar(false);
            verRegistro(-1);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvRegistros_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            verRegistro(indexRegistro = e.RowIndex);

        }





        private void getRegistros()
        {
            dtRegistros = sedeDAO.getSedes();
            if (bHayRegistros = dtRegistros != null)
            {
                dgvRegistros.DataSource = dtRegistros;
                dgvRegistros.Columns["id"].Visible = false;
                dgvRegistros.Columns["NombreSede"].Width = dgvRegistros.Width - 5;
            }

        }

        private void Navegar(bool bOnOff)
        {
            btnNuevo.Visible = bOnOff;
            btnEditar.Visible = btnEliminar.Visible = bOnOff && bHayRegistros;
            btnGuardar.Visible = btnCancelar.Visible = !bOnOff;

            dgvRegistros.Enabled = bOnOff && bHayRegistros;
            txtBuscar.Visible = bOnOff && bHayRegistros;
            txtNS.ReadOnly = bOnOff;
            textDirecion.ReadOnly = bOnOff;
            cboDepartamento.Enabled = cboProvincia.Enabled = cboDistritos.Enabled = cboEstado.Enabled = !bOnOff;

            if (!bOnOff) txtNS.Focus();

        }

        private void verRegistro(int index)
        {
            bool blimpiar = index == -1;

            //ir bd registro -> sede

            txtID.Text = blimpiar ? "" : dgvRegistros.Rows[index].Cells["id"].Value.ToString();  //dtRegistros.Rows[indexRegistro]["ID"].ToString()
            txtNS.Text = blimpiar ? "" : dgvRegistros.Rows[index].Cells["NombreSede"].Value.ToString(); //dtRegistros.Rows[indexRegistro]["Detalle"].ToString();
            //textDirecion.Text = blimpiar ? "" : dgvRegistros.Rows[index].Cells["Direccion"].Value.ToString();
            cboDepartamento.SelectedValue = blimpiar ? -1 : sede.idDepartamento;
            cboProvincia.SelectedValue = blimpiar ? -1 : sede.idProvincia;
            cboDistritos.SelectedValue = blimpiar ? -1 : sede.idDistrito;
            cboEstado.SelectedValue = blimpiar ? -1 : sede.idEstado;
        }


        private void LimpiarCombo(ComboBox cbo)
        {
            cbo.DataSource = null;
            cbo.Items.Clear ();
            cbo.Items.Add("-- Seleccionar --");
            cbo.SelectedIndex = 0;
        }

        
    }
}
