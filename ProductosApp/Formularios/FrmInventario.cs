using AppCore.Interfaces;
using AppCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Formularios
{
    public partial class FrmInventario : Form
    {
        private IEmpleadoService empleadoServices;
        public FrmInventario(EmpleadoService empleadoServices)
        {
            this.empleadoServices = empleadoServices;
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
