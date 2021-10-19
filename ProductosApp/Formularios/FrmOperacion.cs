using Domain.Entities.Inventario;
using Domain.Enums;
using Infraestructure.Inventario;
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
    public partial class FrmOperacion : Form
    {
        public InventarioModel inv = new PEPS();
        public FrmOperacion()
        {
            this.CenterToScreen();
            InitializeComponent();
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            Registros p = new Registros()
            {
                FechaRegistro = dtpFechaIngreso.Value,
                Existencia = (int)nudExistencia.Value,
                ValorUnidad = nudValor.Value,
                ValorTotal = (int)nudExistencia.Value * nudValor.Value,
                Especie = (Especie)cmbEspecie.SelectedIndex
            };

            inv.Create(p);

            Dispose();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
