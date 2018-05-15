using System;


namespace HistoriasMecanicas
{
    public class Movimiento : IComparable
    {
        private Auto auto;
        private DateTime fecha;
        private String manoObra;
        private String repuestos;


        public Movimiento(Auto auto, DateTime fecha, String manoObra, String repuestos)
        {
            this.auto = auto;
            this.fecha = fecha;
            this.manoObra = manoObra;
            this.repuestos = repuestos;
        }

        // Implement the IComparable interface. 
        public int CompareTo(object obj)
        {
            Movimiento m;
            m = (Movimiento)obj;

            return this.fecha.CompareTo(m.fecha);
        }

        public string textoFacturacion()
        {
            return fechaLinda() + " $" + manoObra;
        }

        private string fechaLinda() {
            return fecha.Day + "/" + fecha.Month + "/" + fecha.Year;
        }

        public override string ToString()
        {            
            return auto + " (" + fechaLinda() + ")  Mano de obra $" + manoObra + " y $" + repuestos + " de repuestos";
        }
    }


}
