using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_2do_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de FamilyTree (Árbol Genealógico)
            FamilyTree tree = new FamilyTree();

            // Variable para controlar si continuar o no con el menú
            bool continuar = true; // Cambié 'continue' a 'continuar' para evitar la palabra reservada

            // Bucle principal que se ejecuta mientras 'continuar' sea verdadero
            do
            {
                // Mostrar el menú de opciones
                Console.WriteLine("\nMenú:");
                Console.WriteLine("1. Agregar un miembro a la familia");
                Console.WriteLine("2. Ver padres de alguien");
                Console.WriteLine("3. Mostrar el árbol");
                Console.WriteLine("4. Salir del programa");

                // Leer la opción seleccionada por el usuario
                string option = Console.ReadLine();

                // Ejecutar acción según la opción seleccionada
                switch (option)
                {
                    case "1":
                        // Opción 1: Agregar un miembro a la familia
                        Console.WriteLine("Nombre del hijo: ");
                        string son = Console.ReadLine();
                        Console.WriteLine("Nombre del padre: ");
                        string father = Console.ReadLine();
                        Console.WriteLine("Nombre de la madre:");
                        string mother = Console.ReadLine();
                        tree.AddMember(son, father, mother);
                        Console.WriteLine("Miembro agregado con éxito");
                        break;

                    case "2":
                        // Opción 2: Ver los padres de alguien
                        Console.WriteLine("Ingrese el nombre: ");
                        string name = Console.ReadLine();
                        tree.FindMembers(name);
                        break;

                    case "3":
                        // Opción 3: Mostrar el árbol genealógico completo
                        tree.PrintTree();
                        break;

                    case "4":
                        // Opción 4: Salir del programa
                        Console.WriteLine("Saliendo...");
                        continuar = false; // Cambié 'return' a 'continuar = false' para continuar con el flujo
                        break;

                    default:
                        // Opción inválida, si el usuario ingresa una opción no válida
                        Console.WriteLine("Opción no válida. Intente nuevamente");
                        break;
                }

                // Preguntar si el usuario quiere realizar otra acción o salir
                if (continuar)
                {
                    Console.WriteLine("\n¿Desea realizar alguna otra acción? (S/N)");
                    string answer = Console.ReadLine();

                    // Si el usuario no responde "S", cambiar 'continuar' a false para salir
                    if (answer.ToUpper() != "S")
                    {
                        continuar = false; // Cambiar a false para salir del bucle
                    }
                }

            } while (continuar); // Continuar el bucle mientras 'continuar' sea verdadero

            // Mensaje de cierre del programa
            Console.WriteLine("Programa finalizado.");
        }
    }
}
