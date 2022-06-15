using System;
namespace Correccion{

        public class Estudiante{

        public string nombre {set; get;}
        public string apellido {set; get;}
        public string nombre_institucion {set;get;}
        public int cedula{set; get;}

        public Estudiante(string nombre, string apellido, string nombre_institucion, int cedula){
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombre_institucion = nombre_institucion;
            this.cedula = cedula;
        }
        public void mostrar_datos(){
                Console.WriteLine("Nombre: "+nombre);
                Console.WriteLine("Apellido:"+ apellido);
                Console.WriteLine("Institucion: "+nombre_institucion);
                Console.WriteLine("Cedula de identidad: "+cedula);
        }
    }
}