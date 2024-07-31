using AcademiaFacil.Models.Tipos;

namespace AcademiaFacil.Models.View;

public class ExercicioViewModel
{
    public ExercicioViewModel() { }

    public ExercicioViewModel(Exercicio? exercicio, List<TipoExercicio>? tiposExercicio, List<Equipamento> equipamentos)
    {
        Exercicio = exercicio;
        TiposExercicio = tiposExercicio;
        Equipamentos = equipamentos;
    }

    public Exercicio? Exercicio { get; set; }
    public List<TipoExercicio>? TiposExercicio { get; set; }
    public List<Equipamento>? Equipamentos { get; set; }
}
