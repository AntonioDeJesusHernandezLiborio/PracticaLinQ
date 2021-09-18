using System;
using System.Collections.Generic;
using System.Linq;

namespace Dummy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> Personas = new List<Persona> {
                new Persona { 
                        Id = 1, 
                        Nombre = "Antonio",
                        Edad=22,
                        Cuidad ="Huejutla", 
                        Estado = "Hidalgo",
                        Universidad = new Universidad
                        {
                            Id =1,
                            Nombre= "UTHH",
                            Materias = new List<Materia>{
                                new Materia {   Id=1,
                                                Nombre= "Matematicas",
                                                Calificacion = 8.9
                                },
                                new Materia {   Id=2,
                                                Nombre= "Programacion",
                                                Calificacion = 9.1
                                },
                                new Materia {   Id=1,
                                                Nombre= "Historia",
                                                Calificacion = 6
                                },
                                new Materia {   Id=1,
                                                Nombre= "Circuitos electricos",
                                                Calificacion = 7.7
                                },
                            },
                        },
                        Habilidades = new List<Habilidad>
                        {
                           new Habilidad { Nombre = "Nadar" }
                        }
                },
                
                new Persona {
                        Id = 2,
                        Nombre = "Angela",
                        Edad=22,
                        Cuidad ="Hernandarias",
                        Estado = "Alto Paraná",
                        Universidad = new Universidad
                        {
                            Id = 2,
                            Nombre= "Universidad Intercontinental",
                            Materias = new List<Materia>{
                                    new Materia {   
                                            Id=1,
                                            Nombre= "Matematicas",
                                            Calificacion = 9
                                    }
                            },
                        },
                        Habilidades = new List<Habilidad>
                        {
                           new Habilidad { Nombre = "Nadar" }
                        }
                },
                //new Persona { Id = 3, Nombre = "Alfredo", Cuidad ="Tantoyuca", Edad=25,  Estado = "Veracruz" },
                //new Persona { Id = 4, Nombre = "Juan", Cuidad ="Huejutla", Edad=24, Estado = "Hidalgo" },
                //new Persona { Id = 5, Nombre = "Raul", Cuidad ="Platon Sanchez", Edad=24,  Estado = "Veracruz" },
                //new Persona { Id = 6, Nombre = "Eusebio", Cuidad ="Hautla", Edad=33, Estado = "Hidalgo" },
                //new Persona { Id = 7, Nombre = "Guillermo", Cuidad ="Juarez", Edad=26,  Estado = "Chihuahua" }
            };


            Console.ReadKey();
        }
    }

   
}
