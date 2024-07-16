using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrueba1
{
    internal class Vivienda
    {
        float amb, alquiler, aContrato, aContruccion;
        string direccion,luz,agua,gas;

        public Vivienda()
        {
            amb = 0;
            alquiler = 0;
            aContrato = 0;
            aContruccion = 0;
            direccion = "";
            luz = "";
            agua = "";
            gas = "";
        }

        public float Amb { get => amb; set => amb = value; }
        public float Alquiler { get => alquiler; set => alquiler = value; }
        public float AContrato { get => aContrato; set => aContrato = value; }
        public float AContruccion { get => aContruccion; set => aContruccion = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Luz { get => luz; set => luz = value; }
        public string Agua { get => agua; set => agua = value; }
        public string Gas { get => gas; set => gas = value; }

        public float CalcularExpensas()
        {
            float expensa1, expensa2, expensa3;
            float totalExpensas = 0;
            if (luz == "SI")
            {
                expensa1 = (alquiler * 5) / 100;
                totalExpensas=totalExpensas+ expensa1;
                
            }
            if (agua == "SI")
            {
                expensa2 = (alquiler * 2) / 100;
                totalExpensas = totalExpensas + expensa2;

            }
            if (gas=="SI")  
            {
                expensa3 = (alquiler * 8) / 100;
                totalExpensas = totalExpensas + expensa3;
            }
            
            return totalExpensas;
        }

        public string IndicarTipo()
        {
            if (amb < 3)
            {
                return "Monoambiente";

            }
            else
            {
                if(amb>2 && amb<6)
                {
                    return "Departamento";
                }
                else
                {
                    return "Casa";
                }
            }
        }
        public float CalcularGastosExtras()
        {
            float gastosExtras= 0;
            if(amb < 3)
            {
                gastosExtras = (alquiler * 8) / 100;
            }
            else
            {
                if(amb>2 && amb < 6)
                {
                    gastosExtras = (alquiler * 10) / 100;

                }
                else
                {
                    gastosExtras = (alquiler * 14) / 100;
                }

            }
            return gastosExtras;
        }

        public float CalcularAntiguedad()
        {
            float antiguedad = 0;
            antiguedad = 2023 - aContruccion;
            return antiguedad;
        }
    }
}
