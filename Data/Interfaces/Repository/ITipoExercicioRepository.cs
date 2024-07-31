using AcademiaFacil.Models.Tipos;

namespace AcademiaFacil.Data.Interfaces.Repository
{
    public interface ITipoExercicioRepository
    {
        TipoExercicio CadastrarTipoExercicio(TipoExercicio tipoExercicio);
        TipoExercicio AtualizarTipoExercicio(TipoExercicio tipoExercicio);
        TipoExercicio? BuscarTipoExercicioPorId(int id);
        List<TipoExercicio> ListaTiposExercicio();
        bool DeletarTipoExercicio(int id);
    }
}