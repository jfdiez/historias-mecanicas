using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HistoriasMecanicas {
    public partial class FormAuto : Form {
        Auto auto;
        public FormAuto(Auto auto) {
            InitializeComponent();
            this.auto = auto;
            cargarDatos();
            cargarArreglos();            
        }

        private void cargarArreglos() {
            listBoxArreglos.Items.Clear();
            foreach (Arreglo c in auto.arreglos) {
                listBoxArreglos.Items.Add(c);
            }
            seleccionarPrimerArreglo();
            bool hayArreglos = listBoxArreglos.Items.Count > 0;
            buttonEliminar.Enabled = hayArreglos;
            textBoxKilometraje.Enabled = hayArreglos;
            textBoxDescripcion.Enabled = hayArreglos;
            textBoxCostoRepuestos.Enabled = hayArreglos;
            textBoxCostoManoObra.Enabled = hayArreglos;
        }

        private void cargarDatos() {
            labelMarcaModelo.Text = auto.marca + " " + auto.modelo;
            labelPatente.Text = "Patente " + auto.patente;
            labelAno.Text = auto.ano;
            labelDueno.Text = auto.dueno;
            labelSinVenir.Text = "Sin venir: " + auto.diasSinVenir();
        }            

        private void buttonNuevoArreglo_Click(object sender, EventArgs e) {
            FormNuevoArreglo form = new FormNuevoArreglo();

            if (form.ShowDialog() == DialogResult.OK) {
                auto.agregarArreglo(form.a);
                cargarArreglos();
            }
            listBoxArreglos.Focus();
        }       

        private void cargarArregloActual() {
            if (listBoxArreglos.Items.Count == 0)
                limpiarCampos();
            else
            {
                int arregloSeleccionado = listBoxArreglos.SelectedIndex;

                Arreglo arreglo = (Arreglo)this.auto.arreglos[arregloSeleccionado];

                textBoxKilometraje.Text = arreglo.kilometraje;
                textBoxDescripcion.Text = arreglo.descripcion;
                textBoxCostoManoObra.Text = arreglo.costo_mano_obra;
                textBoxCostoRepuestos.Text = arreglo.costo_repuesto;
            }
        }

        private void seleccionarPrimerArreglo() {
            if (listBoxArreglos.Items.Count > 0)
                listBoxArreglos.SelectedIndex = 0;
            else
                limpiarCampos();
        }

        private void listBoxArreglos_SelectedIndexChanged(object sender, EventArgs e) {
            cargarArregloActual();  
        }

        private void listBoxArreglos_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyValue == 27) { // Esc
                this.Close();
            }                
        }
        
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere eliminar el arreglo seleccionado?", "",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int arregloSeleccionado = listBoxArreglos.SelectedIndex;
                this.auto.arreglos.RemoveAt(arregloSeleccionado);
                
                cargarArreglos();
            }
        }

        private void limpiarCampos()
        {            
            textBoxKilometraje.Text = "";
            textBoxDescripcion.Text = "";
            textBoxCostoRepuestos.Text = "";
            textBoxCostoManoObra.Text = "";
        }

        private void textBoxKilometraje_TextChanged(object sender, EventArgs e)
        {
            if (auto.arreglos.Count > 0 && textBoxKilometraje.Text != "" )
            {
                int arregloSeleccionado = listBoxArreglos.SelectedIndex;

                Arreglo arreglo = (Arreglo)this.auto.arreglos[arregloSeleccionado];

                arreglo.kilometraje = textBoxKilometraje.Text;
            }
        }

        private void FormAuto_Load(object sender, EventArgs e)
        {

        }                       
    }
}
