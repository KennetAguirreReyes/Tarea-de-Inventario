using AppCore.Interfaces;
using AppCore.Services;
using Domain.Entities.Empleados;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Factories;

namespace ProductosApp.Formularios
{
    public partial class FrmAggEmpleado : Form
    {
        public IEmpleadoService empleadoService;
        public FrmAggEmpleado(IEmpleadoService empleadoService)
        {
            InitializeComponent();
            this.empleadoService = empleadoService;
        }

        public FrmAggEmpleado()
        {
        }

        private void BtnCalcelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Docente()
            {
                Id = empleadoService.GetLastEmpleadoId() + 1,
                Nombres = txtName.Text,
                Codigo = int.Parse(txtCodigo.Text),
                Apellidos = txtLastName.Text,
                Cedula = txtCedula.Text,
                Salario = nudSalario.Value,
                FechaContratacion = dtpContratacion.Value,
            };
            empleadoService.Create(emp);
            PrintEmpleado();
        }
        private void PrintEmpleado()
        {
            Empleado[] empleados = empleadoService.FindAll();
            if (empleados == null)
            {
                richTextBox1.Text = "No hay elementos a mostrar.";
                return;
            }
            richTextBox1.Text = "";
            foreach (Empleado e in empleados)
            {
                richTextBox1.AppendText(e.GetEmpleadoAsString());
                richTextBox1.AppendText($"Salario neto: {SalaryCalcultorFactory.CreateInstance(e).CalculateSalary(e)} \n");
            }
        }
    }
}

