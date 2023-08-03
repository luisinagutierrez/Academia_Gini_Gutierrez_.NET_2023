using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDesktop
{
    public partial class frmUserPasswordChange : Form
    {
        public frmUserPasswordChange()
        {
            InitializeComponent();
        }

        private void btnUserNewPasswordCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUserNewPasswordAcept_Click(object sender, EventArgs e)
        {
            // consulta para verificar que sea el mismo nombre de usuario y mail y dejarle ingresar la nueva contra y cambiarla por la vieja y actualizar el atributo de contraseña cambiada
            this.Close();
        }
    }
}
