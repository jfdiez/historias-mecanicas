using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HistoriasMecanicas {
    [Serializable]
    public class Auto : IComparable {
        public String marca;
        public String modelo;
        public String ano;
        public String patente;
        public String chasis;
        public String dueno;
        public ArrayList arreglos;


        public Auto(String marca, String modelo, String ano, String patente, String chasis, String dueno) {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this.patente = patente;
            this.chasis = chasis;
            this.dueno = dueno;
            
            arreglos = new ArrayList();            
        }      
        
        public override string ToString() {
            if (patente != null)
                return marca + " " + modelo + " " + patente + " de " + dueno;
            else
                return marca + " " + modelo + " de " + dueno;
        }

        public Arreglo ultimoArreglo() {
            return (Arreglo)arreglos[arreglos.Count - 1];
        }

        public bool tieneArreglosRecientes()
        {
            bool resultado = false;

            foreach (Arreglo arreglo in arreglos)
                if (arreglo.reciente())
                    resultado = true;
            
            return resultado;
        }

        public ArrayList movimientos(int ano, int mes)
        {
            ArrayList movimientos = new ArrayList();

            foreach (Arreglo arreglo in arreglos)
            {
                if (arreglo.fecha.Year == ano && arreglo.fecha.Month == mes)
                {
                    Movimiento m = new Movimiento(this, arreglo.fecha, arreglo.costo_mano_obra, arreglo.costo_repuesto);
                    movimientos.Add(m);
                }
            }
            return movimientos;
        }

        public int totalRepuestosMes(int ano, int mes)
        {
            int total = 0;
            foreach (Arreglo arreglo in arreglos)
            {
                if (arreglo.fecha.Year == ano && arreglo.fecha.Month == mes)
                {
                    total = total + arreglo.costoRepuestos();
                }
            }
            return total;
        }

        public int totalManoObraMes(int ano, int mes)
        {
            int total = 0;
            foreach (Arreglo arreglo in arreglos)
            {
                if (arreglo.fecha.Year == ano && arreglo.fecha.Month == mes)
                {
                    total = total + arreglo.costoManoObra();
                }
            }
            return total;
        }

        public int diasSinVenir()
        {
            int resultado = 9999;

            foreach (Arreglo a in this.arreglos) {
                int diferencia = DateTime.Today.Subtract(a.fecha).Days;
                if (diferencia < resultado)
                    resultado = diferencia;
            }

            return resultado;
        }

        public void agregarArreglo(Arreglo c) {
            this.arreglos.Add(c);
            this.arreglos.Sort();
        }

        // Implement the IComparable interface. 
        public int CompareTo(object obj) {
            Auto a;
            a = (Auto)obj;
            
            return this.ToString().CompareTo(a.ToString());
        } 
    }
}
