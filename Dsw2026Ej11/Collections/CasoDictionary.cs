using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> _dicAlumnos;
    public Dictionary<int, Alumno> DicAlumnos { get => _dicAlumnos; }

    public CasoDictionary()
    {
        _dicAlumnos = new Dictionary<int, Alumno>();
    }

    #region Agregar Alumno
    public bool AgregarAlumno(Alumno alumno)
    {
        return _dicAlumnos.TryAdd(alumno.Id, alumno);
    }
    #endregion

    #region Buscar Alumno
    public Alumno? BuscarAlumno(int legajo)
    {
        return _dicAlumnos.FirstOrDefault(a => a.Key == legajo).Value;
    }
    #endregion

    #region Eliminar Alumno
    public bool EliminarAlumno(int legajo)
    {
        return _dicAlumnos.Remove(legajo);
    }
    #endregion
}
