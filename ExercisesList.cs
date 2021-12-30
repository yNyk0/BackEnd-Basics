using ExercisesLists.FirstLists;

namespace ExercisesLists
{
    public class Exercises : FirstList
    {
        public void Start()
        {
            start:
            
            for (int exerciseListIndex = 1; exerciseListIndex <= 3; exerciseListIndex++)
            {
                Console.WriteLine($"Digite {exerciseListIndex}) para ver as opções da {exerciseListIndex}ª lista de exercícios");
            }

            var chosenExerciseList = Console.ReadLine() ?? "Valor inválido";
            if (chosenExerciseList == "Valor inválido") 
            {
                Console.WriteLine(chosenExerciseList.Concat("\n"));
                goto start;
            }

            var selectedExerciseList = chosenExerciseList switch
            {
                "1" => FirstExerciseList,
                "2" => SecondExerciseList,
                _ => ThirdExerciseList
            };

            foreach (var item in selectedExerciseList)
            {
                Console.WriteLine($"Digite {item.Key} para executar o exercício {item.Value.Method.Name}");
            }
            var chosenExercise = Console.ReadLine();

            try
            {
                selectedExerciseList[chosenExercise]();
                
                Console.WriteLine("\nDeseja executar outro exercício? Tecle (S) para sim, tecle (R) para repetir exercício ou (N) para encerrar");
                var afterExercise = Console.ReadLine().ToLower();
                
                if (afterExercise == "s") goto start;
                else if (afterExercise == "r") selectedExerciseList[chosenExercise]();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao executar o exercício. Exception: {ex.Message}");
            }
        }
    }
}
