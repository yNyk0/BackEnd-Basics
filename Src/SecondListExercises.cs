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

        private Dictionary<string, Action> GetExercises()
        {
            return new Dictionary<string, Action>
            {
                { "1", FirstExercise },
                { "2", SecondExercise },
                { "3", ThirdExercise },
                { "4", FourthExercise },
                { "5", FifthExercise },
                { "6", SixthExercise }
            };
        }
    }
}
