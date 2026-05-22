using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> _alumnos;
    public List<Alumno> Alumnos { get => this._alumnos;
                                  set => this._alumnos = value; }
    public CasoList()
    {
        _alumnos = new List<Alumno>();
    }

    #region Agregar Alumno
    public void AgregarAlumno(Alumno alumno)
    {
        _alumnos.Add(alumno);
    }
    public void AgregarAlumno(List<Alumno> agregar)
    {
        foreach (var alumno in agregar)
        {
            _alumnos.Add(alumno);
        }
    }
    #endregion

    #region Buscar Alumno
    public Alumno? BuscarAlumno(string Nombre)
    {
        return _alumnos.FirstOrDefault(a => a.Nombre == Nombre);
    }
    #endregion

    #region Eliminar Alumno
    public bool EliminarAlumno(Alumno alumno)
    {
        Alumno? eliminar = BuscarAlumno(alumno.Nombre);
        if(eliminar == null)
        {
            return false;
        }
        return _alumnos.Remove(eliminar);
    }

    public bool EliminarAlumno(int n)
    {
        try {
            _alumnos.RemoveAt(n);
            return true;
        } catch (ArgumentOutOfRangeException ex)
        {
            return false;
        }
    }
    #endregion
}
