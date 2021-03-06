﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        /*a. Se pide crear 3 instancias de la clase Alumno (3 objetos) en la función Main. Colocarle
        nombre, apellido y legajo a cada uno de ellos.
        b. Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
        c. El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
        iguales a 4, caso contrario la inicializará con -1. Para darle un valor a la nota final utilice
        el método de instancia Next de la clase Random.
        d. El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
        mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno
        desaprobado".*/
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_16";
            Alumno juan = new Alumno("Juan", "Perez", 3);
            Alumno rosa = new Alumno("Rosa", "Benitez", 4);
            Alumno raul = new Alumno("Raul", "Castro", 5);

            juan.Estudiar(2, 6);
            rosa.Estudiar(4, 8);
            raul.Estudiar(8, 8);

            juan.Calcularfinal();
            rosa.Calcularfinal();
            raul.Calcularfinal();

            Console.WriteLine(juan.Mostrar());
            Console.WriteLine(rosa.Mostrar());
            Console.WriteLine(raul.Mostrar());

            Console.ReadKey();
        }
    }
}
