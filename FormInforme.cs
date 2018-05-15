using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace HistoriasMecanicas
{
    public partial class FormInforme : Form
    {
        public FormInforme()
        {
            InitializeComponent();
        }

       
 
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            int total = 0;
            int totalRepuestos = 0;
            ArrayList movimientos = new ArrayList();

            foreach (Auto auto in BaseDatos.instancia.autos)
            {
                total = total + auto.totalManoObraMes(dateTimePicker.Value.Year, dateTimePicker.Value.Month);
                totalRepuestos = totalRepuestos + auto.totalRepuestosMes(dateTimePicker.Value.Year, dateTimePicker.Value.Month);
                movimientos.AddRange(auto.movimientos(dateTimePicker.Value.Year, dateTimePicker.Value.Month));
            }
            movimientos.Sort();
            labelMensaje.Text = "Total de mano de obra: $" + total;
            labelRepuestos.Text = "Total de repuestos: $" + totalRepuestos;
            textBox.Clear();
            
            foreach (Movimiento m in movimientos) {
                if (checkBoxFacturacion.Checked)
                    textBox.Text = textBox.Text + m.textoFacturacion() + "\r\n";
                else
                    textBox.Text = textBox.Text + m + "\r\n";
            }
        }

        private void FormInforme_Load(object sender, EventArgs e)
        {
            dateTimePicker_ValueChanged(null, null);
        }      

        private void checkBoxFacturacion_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker_ValueChanged(null, null);
        }

        private int movimientosEnMesDe(int ano, int mes)
        {
            ArrayList movimientos = new ArrayList();
            foreach (Auto auto in BaseDatos.instancia.autos)
            {                
                movimientos.AddRange(auto.movimientos(ano, mes));
            }

            return movimientos.Count;
        }

        private int primerNumeroFacturaMes(int ano, int mes)
        {
            if (ano == 2018)
            {
                if (mes == 4)
                    return 275;
                else
                    if (mes > 4)
                        return primerNumeroFacturaMes(2018, mes - 1) + movimientosEnMesDe(2018, mes - 1);
                    else
                        return 0;
            }
            else            
                return 0;
            
        }

    }
}
