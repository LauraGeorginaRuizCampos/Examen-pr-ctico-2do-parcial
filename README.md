Árbol Genealógico - Examen Práctico
Descripción del Proyecto y Objetivos

Este proyecto implementa un sistema de árbol genealógico utilizando C#. Su objetivo principal es modelar relaciones familiares mediante nodos, representando personas y sus conexiones parentales.
Estructura del Proyecto

    Nodes.cs:

        Define la clase Node con atributos como:

            Name: Nombre de la persona.

            Age: Edad de la persona.

            Parents y Children: Listas que establecen relaciones parentales.

        Métodos principales:

            AddChild(Node child): Agrega un hijo al nodo actual.

            AddParent(Node parent): Agrega un padre al nodo actual.

    FamilyTree.cs:

        Administra y gestiona los nodos.

        Métodos clave:

            AddPerson(string name, int age): Agrega una nueva persona al árbol.

            SetParentChildRelation(string parentName, string childName): Establece relaciones padre-hijo.

            DisplayFamilyTree(): Muestra el árbol genealógico de forma estructurada.

    Program.cs:

        Controla el flujo del programa.

        Presenta un menú interactivo en la consola para:

            Agregar personas.

            Definir relaciones familiares.

            Visualizar el árbol genealógico.

Instrucciones de Instalación y Uso

    Clonar el repositorio:

    git clone https://github.com/LauraGeorginaRuizCampos/Examen-pr-ctico-2do-parcial.git

    Abrir el proyecto en Visual Studio.

    Compilar (Ctrl + Shift + B) y ejecutar (F5).

    Interactuar a través del menú en consola.

Ejemplos de Entrada y Salida

Entrada:

Agregar persona: Juan, 50 años
Agregar persona: Pedro, 25 años
Definir relación: Juan es padre de Pedro
Ver Árbol Genealógico

Salida Esperada:

Juan (50 años)
  └── Pedro (25 años)

Explicación del Algoritmo y Complejidad

    Búsqueda:

        La búsqueda de nodos se realiza con un recorrido lineal (O(n)).

    Inserción:

        Agregar un nodo tiene complejidad O(1) si no existen restricciones adicionales.

    Visualización:

        La impresión del árbol utiliza una búsqueda en profundidad (O(n)).
