using ExercisesLists.ThirdLists;

namespace ExercisesLists.SecondLists
{
    public abstract class SecondList : ThirdList
    {
        protected Dictionary<string, Action> SecondExerciseList => GetExercises();

        private void FirstExercise()
        {
            Console.WriteLine("Hello World!");
        }

        private void SecondExercise()
        {
            Console.WriteLine("Hello World!");
        }

        private void ThirdExercise()
        {
            Console.WriteLine("Hello World!");
        }

        private void FourthExercise()
        {
            Console.WriteLine("Hello World!");
        }

        private void FifthExercise()
        {
            Console.WriteLine("Hello World!");
        }

        private void SixthExercise()
        {
            Console.WriteLine("Hello World!");
        }

        private void ArrayExamples()
        {
            // var purchases = new string[10];
            
            // for (int i = 0; i < purchases.Length; i++)
            // {
            //     Console.WriteLine("Digite o nome do produto que deseja comprar");
            //     purchases[i] = Console.ReadLine();
            // }

            // Console.WriteLine("Lista de compras:");

            // for (int i = 0; i < purchases.Length; i++)
            // {
            //     Console.WriteLine($"{i + 1}. {purchases[i]}");
            // }

            var random = new Random();
            var numbers = new double[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                // Console.WriteLine("Digite um número:");
                // numbers[i] = double.Parse(Console.ReadLine());
                numbers[i] = random.Next(minValue: int.MinValue, maxValue: int.MaxValue);
            }

            Array.Sort(numbers);
            Console.WriteLine("\nNúmeros ordenados:\n");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        private Dictionary<string, Action> GetExercises()
        {
            return new Dictionary<string, Action>
            {
                { "1", FirstExercise },
                { "2", SecondExercise },
                { "3", ThirdExercise },
                { "4", FourthExercise },
                { "5", FifthExercise },
                { "6", SixthExercise },
                { "EX", ArrayExamples }
            };
        }
    }
}
