using System;
using System.Windows.Forms;

namespace appPlanilla_2023.ui
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            bean.Empleados empleado = new bean.Empleados();
            dao.EmpleadoDAO empleadoDAO = new dao.EmpleadoDAO();

            empleado.Dni = txtDni.Text;
            empleado.Passwordd = txtPassword.Text;
            if (empleadoDAO.Login(empleado))
            {
                MessageBox.Show(empleado.Nombres);
            }else MessageBox.Show("Usuario y/o password");
        }
    }
}
