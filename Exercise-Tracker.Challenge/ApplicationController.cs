using Spectre.Console;

namespace Exercise_Tracker.Challenge;

public class ApplicationController
{
    private readonly UserInput _userInput;
    public ApplicationController(UserInput userInput)
    {
       _userInput = userInput; 
    }
    public void Run()
    {
        bool exitApp = false;

        while(!exitApp)
        {
            Console.Clear();
            View.RenderTitle("Exercise-Tracker (Challenge)", Color.DarkSeaGreen3, Color.Fuchsia, "APPLICATION", "blue3", BoxBorder.Double);
            
            var option = _userInput.ChooseExerciseType();

            switch(option)
            {
                case "Weights (EF Core)":
                    break;

                case "Cardio (Raw SQL)":
                    break;

                case "Exit":
                    exitApp = true;
                    break;
            }
            

        }
    }
}
