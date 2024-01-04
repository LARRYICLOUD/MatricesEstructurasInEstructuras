using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesEstructurasInEstructuras
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE Y RECONOCIDO");
            //Creamos un estudiante
            Estudiantes estudiante1 = new Estudiantes();
            //Le asignamos nombre y apellido
            estudiante1.Nombre = "LARRYSALSA";
            estudiante1.Apellidos = "SALSA Y TIMBA";

            //Creamos la matriz
            Calificacion[] calificaciones = new Calificacion[3]
            {
                new Calificacion {Materia = "Matematicas", Puntaje = 9},
                new Calificacion {Materia = "Programacion C#", Puntaje = 10},
                new Calificacion {Materia = "Base de datos", Puntaje = 10}
            };

            //Asignamos la matriz "calificaciones" a nuestro estudiante1
            estudiante1.Calificaciones = calificaciones;

            //Mostrar los datos del estudiante y sus calificacione
            Console.WriteLine($"Nombre: {estudiante1.Nombre}{estudiante1.Apellidos}\n");

            foreach (Calificacion elemento in estudiante1.Calificaciones)
            {
                Console.WriteLine($"{elemento.Materia}={elemento.Puntaje}");
            }

        }
    }
    struct Calificacion
    {
        //Campos
        string materia;
        double puntaje;

        public string Materia { get => materia; set => materia = value; }
        public double Puntaje { get => puntaje; set => puntaje = value; }
    }
    struct Estudiantes
    {
        string nombre;
        string apellidos;
        Calificacion[] calificaciones; //matriz

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public Calificacion[] Calificaciones { get => calificaciones; set => calificaciones = value; }
    }

}
