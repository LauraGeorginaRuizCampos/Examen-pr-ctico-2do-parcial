using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_2do_p
{
    // Clase FamilyTree que maneja la estructura del árbol genealógico
    internal class FamilyTree
    {
        string name;  // Nombre del árbol genealógico (no se usa en el código actual)

        // Lista de miembros del árbol genealógico, donde cada miembro es un nodo (hijo)
        private List<Nodes> members = new List<Nodes>();

        // Método privado para encontrar un nodo por su nombre (el nombre del hijo)
        private Nodes FindNode(string name)
        {
            // Recorre todos los miembros del árbol
            foreach (Nodes node in members)
            {
                // Si el nombre del hijo coincide, devuelve el nodo
                if (node.Son == name)
                    return node;
            }
            // Si no se encuentra el nodo, devuelve null
            return null;
        }

        // Método público para agregar un nuevo miembro (hijo) al árbol genealógico
        public void AddMember(string son, string Father, string Mother)
        {
            // Busca si ya existe el hijo con el nombre dado
            Nodes Son = FindNode(son);
            if (Son == null)
            {
                // Si el hijo no existe, crea un nuevo nodo para el hijo y lo agrega a la lista de miembros
                Son = new Nodes(son);
                members.Add(Son);
            }

            // Busca y agrega al padre, si se proporciona un nombre de padre
            Nodes father = null;
            if (!string.IsNullOrEmpty(Father))
            {
                father = FindNode(Father);
                if (father == null)
                {
                    // Si el padre no existe, crea un nuevo nodo para el padre y lo agrega a la lista
                    father = new Nodes(Father);
                    members.Add(father);
                }
            }

            // Busca y agrega a la madre, si se proporciona un nombre de madre
            Nodes mother = null;
            if (!string.IsNullOrEmpty(Mother))
            {
                mother = FindNode(Mother);
                if (mother == null)
                {
                    // Si la madre no existe, crea un nuevo nodo para la madre y lo agrega a la lista
                    mother = new Nodes(Mother);
                    members.Add(mother);
                }
            }

            // Asigna al hijo sus padres (si se encontraron o crearon)
            Son.AddParents(father, mother);
        }

        // Método público para encontrar a los padres de un miembro (hijo) por su nombre
        public void FindMembers(string name)
        {
            // Busca el nodo (miembro) por su nombre
            Nodes node = FindNode(name);
            if (node != null)
                // Si el miembro se encuentra, muestra sus padres
                node.GetParents();
            else
                // Si no se encuentra, muestra un mensaje de error
                Console.WriteLine("No se pudo encontrar a ese miembro :(");
        }

        // Método público para imprimir el árbol genealógico en un recorrido preorden
        public void PrintTree()
        {
            Console.WriteLine("Árbol genealógico perrón: ");

            // Recorre todos los miembros del árbol
            foreach (Nodes member in members)
            {
                // Si un miembro no tiene padre ni madre, es considerado la raíz del árbol genealógico
                if (member.Father == null && member.Mother == null)
                {
                    // Imprime el árbol genealógico a partir de ese miembro en un recorrido preorden
                    member.PrintPreOrder();
                    Console.WriteLine();  // Salto de línea después de imprimir el árbol
                }
            }
        }
    }
}

