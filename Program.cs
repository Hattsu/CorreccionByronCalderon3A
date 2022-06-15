namespace Correccion{

    class Program{

        public static void Main(String[] args){
            EstudiantePrimaria estudiante_primaria = new EstudiantePrimaria(5,"Jonathan","Sol","Fe_y_alegria",7856767);
            //estudiante_primaria.mostrar_datos();
            
            EstudianteSecundaria estudiante_secundaria = new EstudianteSecundaria(7,"pepe","Hermandez","Manta",7856767);
            //estudiante_secundaria.mostrar_datos();

            EstudianteUniversitario estudiante_universitario = new EstudianteUniversitario(12,200,"Jose","lopez","Fe_y_alegria",7856767);
            //estudiante_universitario.mostrar_datos();

            List<Estudiante> Estudiantes_lista2 = new List<Estudiante>();
            Estudiantes_lista2.Add(estudiante_primaria);
            Estudiantes_lista2.Add(estudiante_secundaria);
            Estudiantes_lista2.Add(estudiante_universitario);

            foreach(Estudiante Estudiantes in Estudiantes_lista2)
            {
                Estudiantes.mostrar_datos();
            }

            List<ICalcular> Estudiantes_lista = new List<ICalcular>();
            Estudiantes_lista.Add(estudiante_primaria);
            Estudiantes_lista.Add(estudiante_secundaria);
            Estudiantes_lista.Add(estudiante_universitario);

            foreach(ICalcular Estudiantes in Estudiantes_lista)
            {
                Estudiantes.calcular();
            }
        }
    }
}