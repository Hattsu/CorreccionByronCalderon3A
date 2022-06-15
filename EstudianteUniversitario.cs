using System;
namespace Correccion{

class EstudianteUniversitario:Estudiante,ICalcular{
    public int cantidad_credito {set; get;}
    public int precop_credito {set;get;}

    public EstudianteUniversitario(int cantidad_credito,int precop_credito ,string nombre, string apellido,string nombre_institucion,int cedula):base(nombre, apellido, nombre_institucion,cedula){
        this.cantidad_credito = cantidad_credito;
        this.precop_credito = precop_credito;
    }
    public void mostrar_datos(string nombre, string apellido, string nombre_institucion, int cedula){}
    public void calcular(){
        int operacion;
        operacion = cantidad_credito * precop_credito;
        Console.WriteLine("La Matricula de un universitario es");
        Console.WriteLine("cantidad de creditos es "+cantidad_credito + "");
        Console.WriteLine("el calculo final es "+operacion);

    }
}
    
}