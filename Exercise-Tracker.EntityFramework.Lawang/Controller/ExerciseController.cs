using Exercise_Tracker.EntityFramework.Lawang.Services;

namespace Exercise_Tracker.EntityFramework.Lawang.Controller;

public class ExerciseController
{
    private readonly IExerciseService _exerciseService;
    public ExerciseController(IExerciseService exerciseService)
    {
        _exerciseService = exerciseService;
    }

    
}
