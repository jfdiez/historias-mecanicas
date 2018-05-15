using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HistoriasMecanicas {
    public partial class NuevoAuto : Form {

        public Auto auto;
        public NuevoAuto() {
            InitializeComponent();
        }

        public void cargarDatosAuto(Auto auto)
        {
            textBoxMarca.Text = auto.marca;
            textBoxModelo.Text = auto.modelo;
            textBoxAno.Text = auto.ano;
            textBoxDueno.Text = auto.dueno;
            textBoxPatente.Text = auto.patente;
            textBoxChasis.Text = auto.chasis;
            this.auto = auto;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBoxMarca.Text == "" || textBoxModelo.Text == "" || textBoxAno.Text == "" || textBoxDueno.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                if (this.auto == null)
                    this.auto = new Auto(textBoxMarca.Text, textBoxModelo.Text, textBoxAno.Text, textBoxPatente.Text, textBoxChasis.Text, textBoxDueno.Text);
                else
                {
                    this.auto.marca = textBoxMarca.Text;
                    this.auto.modelo = textBoxModelo.Text;
                    this.auto.ano = textBoxAno.Text;
                    this.auto.patente = textBoxPatente.Text;
                    this.auto.chasis = textBoxChasis.Text;
                    this.auto.dueno = textBoxDueno.Text;
                }
            }
        }                                     
    }
}
