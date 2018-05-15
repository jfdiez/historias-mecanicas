using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HistoriasMecanicas {
    public partial class FormPrincipal : Form {
        public FormPrincipal() {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e) {
            if (!BaseDatos.copiaLegal())
                Application.Exit();
            BaseDatos.levantarBaseDatos();
            llenarListBox();
            comprobarAntiguedad();
        }

        private void comprobarAntiguedad()
        {
            foreach (Auto auto in BaseDatos.instancia.autos)
            {
                if (!auto.tieneArreglosRecientes())
                    MessageBox.Show(auto + " no tiene arreglos recientes.");
            }
        }

        private void llenarListBox() {
            listBoxAutos.Items.Clear();
            foreach (Auto a in BaseDatos.instancia.autos) {
                listBoxAutos.Items.Add(a);                                
            }
            if (listBoxAutos.Items.Count > 0)
                listBoxAutos.SelectedIndex = 0;
            labelCantidad.Text = "Cantidad de autos: " + listBoxAutos.Items.Count;
        }

        private void button1_Click(object sender, EventArgs e) {

            NuevoAuto form = new NuevoAuto();

            if (form.ShowDialog() == DialogResult.OK) {
                BaseDatos.agregarAuto(form.auto);
                llenarListBox(); 
            }
            listBoxAutos.Focus();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e) {
            AbrirFormularioAutoActual();
        }

        private void buttonEliminar_Click(object sender, EventArgs e) {
            Auto p = autoActual();
            
            if (MessageBox.Show("Está seguro que quiere eliminar el auto " + p.marca + " " + p.modelo, "",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {

                BaseDatos.eliminarAuto(listBoxAutos.SelectedIndex);
                llenarListBox();
                listBoxAutos.Focus();
            }
        }

        private Auto autoActual() {
            Auto a = (Auto) listBoxAutos.Items[listBoxAutos.SelectedIndex];
            Auto b = (Auto)BaseDatos.instancia.autos[listBoxAutos.SelectedIndex];
            return a;
        }

        private void listBox1_KeyUp(object sender, KeyEventArgs e) {                      

            if (e.KeyValue == 46) {// Delete
                buttonEliminar_Click(null, null);
            }

            if (e.KeyValue == 13) {// Enter
                AbrirFormularioAutoActual();
            }
        }

        private void AbrirFormularioAutoActual() {
            FormAuto form;

            form = new FormAuto(autoActual());
            form.ShowDialog();
            BaseDatos.guardarBaseDatos();
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {            
            String elegido = listBoxAutos.SelectedItem.ToString();

            saveFileDialog.FileName = elegido;
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            // Get file name.
            string name = saveFileDialog.FileName;

            Auto auto = autoActual();
            string lines = "Fecha;Kilometraje;Descripcion;Costo Repuestos;Costo Mano Obra\r\n";
            foreach (Arreglo arreglo in auto.arreglos)
            {
                lines = lines + arreglo.fecha + ";" + arreglo.kilometraje + ";" + arreglo.descripcion + ";" + arreglo.costo_repuesto + ";" + arreglo.costo_mano_obra + "\r\n";
            }            

            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter(name);
            file.WriteLine(lines);

            file.Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            NuevoAuto form = new NuevoAuto();
            Auto auto = autoActual();
            form.cargarDatosAuto(auto);

            if (form.ShowDialog() == DialogResult.OK)
            {
                BaseDatos.guardarBaseDatos();
                llenarListBox();
            }            
        }

        private void buttonInforme_Click(object sender, EventArgs e)
        {
            FormInforme form = new FormInforme();

            form.ShowDialog();
        }

        private void listBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
