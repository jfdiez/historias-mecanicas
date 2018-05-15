using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HistoriasMecanicas {
    public partial class FormNuevoArreglo : Form {

        public Arreglo a;

        public FormNuevoArreglo() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
                       
            a = new Arreglo();
            a.fecha = dateTimePicker1.Value;
            a.kilometraje = textBoxKilometraje.Text;
            if (a.kilometraje == "")
            {
                MessageBox.Show("Ingrese el kilometraje", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
            }
            a.descripcion = textBoxDescripcion.Text;
            if (a.descripcion == "")
            {
                MessageBox.Show("Ingrese la descripción", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
            }
            
            a.costo_repuesto = textBoxRespuestos.Text;
            int number;

            if (!Int32.TryParse(a.costo_repuesto, out number))
            {
                MessageBox.Show("El costo repuestos no es un número válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
            }

            a.costo_mano_obra = textBoxManoObra.Text;
            if (!Int32.TryParse(a.costo_mano_obra, out number))
            {
                MessageBox.Show("El costo de mano de obra no es un número válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
            }

        }

        private void FormNuevaConsulta_Shown(object sender, EventArgs e) {
            textBoxKilometraje.Focus();
        }
                
    }
}
