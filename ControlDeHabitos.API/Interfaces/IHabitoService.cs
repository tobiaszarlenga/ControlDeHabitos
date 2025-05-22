using ControlDeHabitos.API.Models;

namespace ControlDeHabitos.API.Interfaces
{
    public class IHabitoService
    {
        List<Habito> ObtenerTodos();
        Habito? ObtenerPorId(int id);
        Habito Crear(Habito nuevoHabito);
        bool Actualizar(int id, Habito habitoActualizado);
        bool Eliminar (int id);

    }
}
