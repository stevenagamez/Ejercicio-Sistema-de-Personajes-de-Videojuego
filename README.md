# Sistema de Personajes de Videojuego

## Descripción

Este proyecto consiste en desarrollar un pequeño sistema de personajes de videojuego utilizando **Programación Orientada a Objetos (POO) en C#**.

El programa permite crear diferentes personajes, mostrar su información y realizar acciones básicas como atacar, recibir daño, curarse y subir de nivel.

El objetivo principal es comprender cómo una **clase funciona como un molde para crear objetos** y cómo cada objeto puede tener su propio estado.

## Tecnologías utilizadas

* C#
* .NET
* Visual Studio
* Programación Orientada a Objetos

## Conceptos utilizados

En este ejercicio se aplican los siguientes conceptos:

* Clases
* Objetos
* Atributos
* Métodos
* Métodos con parámetros
* Métodos con retorno
* Constructores
* Sobrecarga de constructores
* Uso de `this`
* Creación de objetos con `new`
* Modificación del estado de los objetos

## Estructura del proyecto

El proyecto está desarrollado utilizando un solo archivo:

```text
Proyecto
│
└── Program.cs
```

Dentro de `Program.cs` se encuentran las clases `Personaje` y `Program`.

## Clase Personaje

La clase `Personaje` contiene los siguientes atributos:

```text
nombre
vida
nivel
ataque
```

También cuenta con tres constructores diferentes:

### Constructor sin parámetros

Crea un personaje con valores predeterminados:

```text
Vida: 100
Nivel: 1
Ataque: 10
```

### Constructor con nombre

Permite crear un personaje indicando solamente su nombre.

### Constructor con todos los datos

Permite indicar:

* Nombre
* Vida
* Nivel
* Ataque

## Métodos principales

### MostrarInformacion()

Muestra en consola la información actual del personaje.

### RecibirDanio(int cantidad)

Reduce la vida del personaje según el daño recibido. La vida no puede ser menor que cero.

### Curar(int cantidad)

Aumenta la vida del personaje según la cantidad indicada.

### SubirNivel()

Aumenta el nivel en 1 y aumenta el ataque en 5 puntos.

### Atacar(Personaje enemigo)

Permite que un personaje ataque a otro personaje.

El personaje atacado pierde una cantidad de vida igual al ataque del personaje atacante.

Ejemplo:

```csharp
kratos.Atacar(mario);
```

### ObtenerVida()

Retorna la cantidad de vida actual del personaje.

### EstaVivo()

Retorna `true` si el personaje tiene más de 0 puntos de vida y `false` si su vida llegó a 0.

## Personajes utilizados

En el programa se crean tres personajes:

```csharp
Personaje kratos = new Personaje();

Personaje mario = new Personaje("Mario");

Personaje link = new Personaje("Link", 110, 2, 18);
```

De esta forma se utilizan los diferentes constructores de la clase.

## Funcionamiento del programa

Durante la ejecución se realizan diferentes acciones:

1. Se muestra el estado inicial de los personajes.
2. Kratos ataca a Mario.
3. Mario ataca a Kratos.
4. Link ataca a Kratos.
5. Kratos recupera vida.
6. Link sube de nivel.
7. Se muestra nuevamente el estado de los personajes.
8. Se verifica si cada personaje continúa con vida.

## Ejemplo de interacción

```text
================================
        ESTADO INICIAL
================================

KRATOS
Nombre: Personaje
Vida: 100
Nivel: 1
Ataque: 10

MARIO
Nombre: Mario
Vida: 100
Nivel: 1
Ataque: 10

LINK
Nombre: Link
Vida: 110
Nivel: 2
Ataque: 18

================================
           COMBATE
================================

Personaje atacó a Mario.
Mario recibió 10 puntos de daño.

Mario atacó a Personaje.
Personaje recibió 10 puntos de daño.

Link atacó a Personaje.
Personaje recibió 18 puntos de daño.

Personaje recuperó 10 puntos de vida.

Link subió de nivel.
```

## ¿Qué se aprendió?

Con este ejercicio se puede entender que una clase como `Personaje` funciona como un molde para crear diferentes objetos.

Cada objeto mantiene sus propios valores de vida, nivel y ataque.

Por ejemplo:

```csharp
kratos.Atacar(mario);
```

permite que un objeto interactúe con otro objeto mediante un método.

También se puede observar cómo los métodos modifican el estado de cada personaje durante la ejecución del programa.

## Cómo ejecutar el proyecto

1. Abrir el proyecto en **Visual Studio**.
2. Abrir el archivo `Program.cs`.
3. Verificar que el código esté completo.
4. Ejecutar el programa utilizando:

```text
Ctrl + F5
```

o presionando el botón de ejecución de Visual Studio.

## Autor

**Steven Agamez**

Proyecto académico desarrollado para practicar los conceptos básicos de **Programación Orientada a Objetos en C#**.
