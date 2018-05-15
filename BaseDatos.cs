using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;


namespace HistoriasMecanicas {
    [Serializable]
    class BaseDatos {

        public ArrayList autos;
        public static BaseDatos instancia;

        public static void agregarAuto(Auto p) {
            instancia.autos.Add(p);
            instancia.autos.Sort();
            guardarBaseDatos();
        }

        public static void eliminarAuto(int index) {
            instancia.autos.RemoveAt(index);
            guardarBaseDatos();
        }

        public static void levantarBaseDatos() {
            Stream str = null;
            try {
                str = File.OpenRead("base_datos");
                BinaryFormatter formatter = new BinaryFormatter();
                SoapFormatter formatterSoap = new SoapFormatter();

                instancia = (BaseDatos)formatter.Deserialize(str);
                
                str.Close();
            }
            catch (Exception) {
                probarLevantar("respaldo_base");
            }
            finally {
                if (str != null)
                    str.Close();
            }            
        }

        private static void probarLevantar(String nombreArchivo) {
            try
            {
                Stream str = File.OpenRead(nombreArchivo);
                BinaryFormatter formatter = new BinaryFormatter();

                instancia = (BaseDatos)formatter.Deserialize(str);

                str.Close();
            }
            catch (Exception)
            {
                crearBasePorPrimeraVez();
            }
        }

        public static void crearBasePorPrimeraVez() {
            BaseDatos.instancia = new BaseDatos();
            BaseDatos.instancia.autos = new ArrayList();            
        }

        public static void guardarBaseDatos() {
            guardarEnArchivo("respaldo_base");
            guardarEnArchivo("base_datos");
        }

        private static void guardarEnArchivo(String nombreArchivo) {
            Stream str = File.OpenWrite(nombreArchivo);
            Stream strSoap = File.OpenWrite(nombreArchivo + "Soap.xml");
            BinaryFormatter formatter = new BinaryFormatter();
            SoapFormatter formatterSoap = new SoapFormatter();
            formatter.Serialize(str, instancia);
            formatterSoap.Serialize(strSoap, instancia);
            str.Close();
            strSoap.Close();
        }

        internal static bool copiaLegal() {
            return true;
            // return System.IO.File.Exists("c:\\wincfg.sys");
        }
    }
}