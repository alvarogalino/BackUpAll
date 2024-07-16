using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Alumno
    {
        private string nombre, apellido, dni;        

        private float nota1, nota2, nota3;

        public Alumno(float nota1, float nota2, float nota3)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public Alumno(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public override bool Equals(object obj)
        {
            return obj is Alumno alumno &&
                   nombre == alumno.nombre &&
                   apellido == alumno.apellido &&
                   dni == alumno.dni &&
                   nota1 == alumno.nota1 &&
                   nota2 == alumno.nota2 &&
                   nota3 == alumno.nota3;
        }

        public override int GetHashCode()
        {
            int hashCode = -526515948;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(apellido);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(dni);
            hashCode = hashCode * -1521134295 + nota1.GetHashCode();
            hashCode = hashCode * -1521134295 + nota2.GetHashCode();
            hashCode = hashCode * -1521134295 + nota3.GetHashCode();
            return hashCode;
        }

        public float CalcularPromedio
        {
            get
            {
                float promedio;
                promedio = (nota1 + nota2 + nota3) / 3;
                return promedio;
            }
        }
    }

}
