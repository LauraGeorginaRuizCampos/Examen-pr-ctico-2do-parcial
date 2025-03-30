using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_2do_p
{
    // Clase Node, que representa un miembro de la familia en el árbol genealógico
    internal class Nodes
    {
        public string Son;   // Nombre del hijo
        public Nodes Father; // Nodo que representa al padre del hijo
        public Nodes Mother; // Nodo que representa a la madre del hijo

        // Constructor de la clase Node. Inicializa el nombre del hijo y asigna null a los padres.
        public Nodes(string son)
        {
            Son = son;  // Asigna el nombre al hijo
            Father = null;  // Inicializa el padre como null
            Mother = null;  // Inicializa la madre como null
        }

        // Método para asignar los padres a un hijo
        public void AddParents(Nodes Father, Nodes Mother)
        {
            this.Father = Father;  // Asigna el padre usando 'this' para evitar confusión con el parámetro
            this.Mother = Mother;  // Asigna la madre
        }

        // Método para mostrar los padres de un hijo
        public void GetParents()
        {
            Console.WriteLine($"Padres de {Son}: "); // Muestra el nombre del hijo
            if (Father != null) // Si el padre no es null, imprime el nombre del padre
                Console.WriteLine($"Padre: {Father.Son}");
            if (Mother != null) // Si la madre no es null, imprime el nombre de la madre
                Console.WriteLine($"Madre: {Mother.Son}");

            // Si tanto el padre como la madre son null, significa que no se han asignado padres
            if (Father == null && Mother == null)
                Console.WriteLine("Esos padres no existen :(");
        }

        // Método para imprimir el árbol genealógico en preorden
        public void PrintPreOrder()
        {
            Console.WriteLine(Son);  // Primero, imprime el nombre del hijo (el nodo actual)

            // Luego recursivamente imprime a los padres (si existen), en orden preorden
            if (Father != null) // Si existe un padre, recursivamente imprime el árbol del padre
                Father.PrintPreOrder();
            if (Mother != null) // Si existe una madre, recursivamente imprime el árbol de la madre
                Mother.PrintPreOrder();
        }
    }
}

