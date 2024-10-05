using Spectre.Console;

namespace Exercise_Tracker.Challenge.Controllers;

public class ApplicationController
{
    private readonly UserInput _userInput;
    private readonly CardioController _cardioController;
    public ApplicationController(UserInput userInput, CardioController cardioController)
    {
       _userInput = userInput; 
       _cardioController = cardioController;
    }
    public async Task Run()
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
                    await _cardioController.Run();
                    break;

                case "Exit":
                    exitApp = true;
                    break;
            }
            

        }
    }
}
