using System;
using CoreSchool.Entities;

namespace CoreSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto y asignar valores a sus atributos
            /* var school = new School("Platzi Academy", 2012);
            school.Country = "Colombia";
            school.City = "Bogotá";
            school.SchoolType = SchoolType.Primaria; */

            // Crear un objeto y enviar parametros opcionales
            var school = new School("Platzi Academy", 2012, SchoolType.Primaria, city: "Bogotá");

            Console.WriteLine(school);
        }
    }
}
