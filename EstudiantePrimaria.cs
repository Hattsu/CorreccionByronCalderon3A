using System;
namespace Correccion{

 public class EstudiantePrimaria:Estudiante,ICalcular{
        public int valor_fijo {set; get;}
        public int anual {set; get;}

        public EstudiantePrimaria(int anual,string nombre, string apellido,string nombre_institucion,int cedula):base(nombre, apellido, nombre_institucion,cedula){
            this.valor_fijo = 100;
            this.anual = anual;
        }

        public void mostrar_datos(string nombre, string apellido, string nombre_institucion, int anual, int cedula){}
        public void calcular(){
                int operacion;
                operacion = anual * this.valor_fijo;
                Console.WriteLine("La Matricula de un Estudiante de primaria");
                Console.WriteLine("Por "+anual+ " anios se calculo un valor "+operacion);
        }
    }
}