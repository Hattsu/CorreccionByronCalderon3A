using System;
namespace Correccion{

class EstudianteSecundaria:Estudiante,ICalcular{
    public int nive_cursado {set; get;}
    public int precioi_fijo{set;get;}

        public EstudianteSecundaria(int nive_cursado ,string nombre, string apellido,string nombre_institucion,int cedula):base(nombre, apellido, nombre_institucion,cedula){
            this.nive_cursado = nive_cursado;
            this.precioi_fijo = 20;
        }
        public void mostrar_datos(string nombre, string apellido, string nombre_institucion, int cedula){}
        public void calcular(){
            int operacion;
            operacion = nive_cursado * this.precioi_fijo;
            Console.WriteLine("La Matricula de un Estudiante Secundaria");
            Console.WriteLine("Por "+nive_cursado+ " nivel se calculo un valor "+operacion);
        }
    }
}