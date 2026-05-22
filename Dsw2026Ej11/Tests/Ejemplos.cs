using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos

    #region EjemploList
    public static void EjemploList()
    {
        var ejemploUno = new CasoList();
        var alumnos = new List<Alumno>()
        {
            new Alumno(101, "Anny", 7.5),
            new Alumno(102, "Juan", 3.4),
            new Alumno(103, "Pedro", 8.9)
        };
        ejemploUno.AgregarAlumno(alumnos);

        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("           EJEMPLOS LIST");
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine();

        Console.WriteLine("LISTADO DE ALUMNOS:");
        foreach (var alumno in ejemploUno.Alumnos)
        {
            Console.WriteLine(alumno.ToString());
        }
        Console.WriteLine();

        Console.WriteLine("BUSCANDO ALUMNO EXISTENTE: Juan");
        var a = ejemploUno.BuscarAlumno("Juan");
        if (a != null) Console.WriteLine("Encontrado - " + a.Nombre);
        else Console.WriteLine("No encontrado.");
        Console.WriteLine();

        Console.WriteLine("BUSCANDO ALUMNO INEXISTENTE: Kevin");
        var b = ejemploUno.BuscarAlumno("Kevin");
        if (b != null) Console.WriteLine("Encontrado - " + b.Nombre);
        else Console.WriteLine("No encontrado.");
        Console.WriteLine();

        Console.WriteLine("ELIMINANDO ALUMNO: Anny");
        ejemploUno.EliminarAlumno(new Alumno(101,"Anny",7.5));
        Console.WriteLine();

        Console.WriteLine("LISTADO DE ALUMNOS:");
        foreach (var alumno in ejemploUno.Alumnos)
        {
            Console.WriteLine(alumno.ToString());
        }
        Console.WriteLine();

        Console.WriteLine("ELIMINAR EL PRIMER ELEMENTO:");
        ejemploUno.EliminarAlumno(ejemploUno.Alumnos.First());
        foreach (var alumno in ejemploUno.Alumnos)
        {
            Console.WriteLine(alumno.ToString());
        }
        Console.WriteLine();
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine();
    }
    #endregion

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    #region EjemploDictionary
    public static void EjemploDictionary()
    {
        var ejemploDos = new CasoDictionary();
        var alumnos = new List<Alumno>()
        {
            new Alumno(104, "Diego", 6.8),
            new Alumno(105, "Ayline", 7.1),
            new Alumno(103, "Mateo", 3.2)
        };
        foreach(var al in alumnos)
        {
            ejemploDos.AgregarAlumno(al);
        }

        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("           EJEMPLOS DICTIONARY");
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine();

        Console.WriteLine("LISTADO DE ALUMNOS:");
        foreach(var al in ejemploDos.DicAlumnos)
        {
            Console.WriteLine(al.Value.ToString());
        }
        Console.WriteLine();

        Console.WriteLine("BUSCANDO ALUMNO EXISTENE: Legajo 104");
        var a = ejemploDos.BuscarAlumno(104);
        if (a != null) Console.WriteLine("Encontrado - " + a.Nombre);
        else Console.WriteLine("No encontrado.");
        Console.WriteLine();

        Console.WriteLine("BUSCANDO ALUMNO INEXISTENTE: Legajo 107");
        var b = ejemploDos.BuscarAlumno(107);
        if (b != null) Console.WriteLine("Encontrado - " + b.Nombre);
        else Console.WriteLine("No existe.");
        Console.WriteLine();

        Console.WriteLine("ELIMINANDO ALUMNO: Legajo 104");
        ejemploDos.EliminarAlumno(104);
        Console.WriteLine();

        Console.WriteLine("LISTADO DE ALUMNOS:");
        foreach (var alumno in ejemploDos.DicAlumnos)
        {
            Console.WriteLine(alumno.Value.ToString());
        }
        Console.WriteLine();
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine();
    }
    #endregion

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    #region EjemploLinq
    public static void EjemploLinq()
    {
        CasoLinq ejemploTres = new CasoLinq();

        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("           EJEMPLOS DICTIONARY");
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine();

        Console.WriteLine("Primer Libro - " + ejemploTres.GetPrimero());
        Console.WriteLine("Ultimo Libro - " + ejemploTres.GetUltimo());
        Console.WriteLine("Total Precios - " + ejemploTres.GetTotalPrecios());
        Console.WriteLine("Promedio de Precios - " + ejemploTres.GetPromedioPrecios());
        Console.WriteLine();
        Console.WriteLine("Libros con ID mayor a 15:");
        foreach(var libro in ejemploTres.GetListById())
        {
            Console.WriteLine(libro.ToString());
        }
        Console.WriteLine();

        Console.WriteLine("Libros:");
        foreach(var libro in ejemploTres.GetLibros())
        {
            Console.WriteLine(libro);
        }
        Console.WriteLine();
        
        Console.WriteLine("Precio más alto: " + ejemploTres.GetMayorPrecio()?.Precio);
        Console.WriteLine("Precio más bajo: " + ejemploTres.GetMenorPrecio()?.Precio);
        Console.WriteLine();

        Console.WriteLine("Libros con precio mayor al promedio:");
        foreach (var libro in ejemploTres.GetMayorPromedio())
        {
            Console.WriteLine(libro.ToString());
        }
        Console.WriteLine();

        Console.WriteLine("Libros ordenados por título en orden descendiente:");
        foreach (var libro in ejemploTres.GetOrdenDescendiente())
        {
            Console.WriteLine(libro.ToString());
        }
        Console.WriteLine();
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine();
    }
    #endregion
}
