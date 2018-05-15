using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HistoriasMecanicas {
    [Serializable]
    public class Arreglo : IComparable {
        public DateTime fecha;
        public String kilometraje, descripcion, costo_repuesto, costo_mano_obra;

        public Arreglo() {             
        }
        
        //public System.Windows.Forms.ListViewItem generarListViewItem() {
        //    System.Windows.Forms.ListViewItem item;
        //    string[] strs = new String[2];

        //    strs[0] = fecha.Day + "/" + fecha.Month + "/" + fecha.Year;
        //    strs[1] = motivo;
            
        //    item = new System.Windows.Forms.ListViewItem(strs);

        //    return item;
        //}

        public bool reciente()
        {
            return this.fecha.Subtract(DateTime.Now).Days < 180;
        }

        public override string ToString() {
            return fecha.Day + "/" + fecha.Month + "/" + fecha.Year + " por " + descripcion;
        }

        public int costoRepuestos()
        {                            
                return Int32.Parse(costo_repuesto);            
        }

        public int costoManoObra()
        {
            try
            {
                costo_repuesto = costo_repuesto.Replace("$", string.Empty);
                costo_mano_obra = costo_mano_obra.Replace("$", string.Empty);
                return Int32.Parse(costo_mano_obra);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        // Implement the IComparable interface. 
        public int CompareTo(object obj) {
            Arreglo a;
            a = (Arreglo)obj;
            return a.fecha.CompareTo(fecha);            
        } 
    }    
}
