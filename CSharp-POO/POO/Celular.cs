using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Celular
    {
        double pantalla;
        string color, marca, sistemaOperativo;
        int bateria;
        bool cargaRapida;

        static string procesador;

        public Celular(double pantallaP, string colorP, string marcaP, string sistemaOperativoP, int bateriaP, bool cargaRapidaP)
        {
            pantalla = pantallaP;
            color = colorP;
            marca = marcaP;
            sistemaOperativo = sistemaOperativoP;
            bateria = bateriaP;
            cargaRapida = cargaRapidaP;
        }

        public string Procesador
        {
            get
            {
                return procesador;
            }
            set
            {
                procesador = value;
            }
        }

        public void MostarInformacion()
        {
            Console.WriteLine("Tamaño de pantalla: {0}\" \nColor: {1} \nMarca: {2} \nSistema Operativo: {3} \nBateria: {4} mAh \nCarga rapida: {5} \nProcesador: {6}", pantalla, color, marca, sistemaOperativo, bateria, cargaRapida, procesador);
        }

        public static void MostrarProcesador()
        {
            Console.WriteLine("El nombre del procesador es: {0}", procesador);
        }
    }
}
