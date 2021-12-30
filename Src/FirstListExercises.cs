using ExercisesLists.SecondLists;

namespace ExercisesLists.FirstLists
{
    public abstract class FirstList : SecondList
    {
        protected Dictionary<string, Action> FirstExerciseList => GetExercises();

        private void FirstExercise()
        {
            Console.WriteLine("Hello World!");
        }

        private void SecondExercise()
        {
            //2)Imprimir a soma dos números inteiros de 1 a 100.
    
            var sum = 0;
            for (int start = 1; start <= 100; start++)
            {
                sum += start;
            }

            System.Console.WriteLine($"A soma dos números de 1 a 100 é: {sum}");
        }

        private void ThirdExercise()
        {
            //3)Imprimir todo os números ímpares menores de 200.

            for (int counter = 1; counter < 200; counter += 2)
            {
                System.Console.WriteLine(counter);
            }
        }

        private void FourthExercise()
        {
            //Calcular a média de idade de uma turma qualquer. 
            //O algoritmo deve parar quando for digitada a idade igual a zero.

            var counter = 0;
            for (int entry = 0; true; entry++)
            {
                Console.WriteLine("Digite uma idade:");
                var age = int.Parse(Console.ReadLine());
                counter += age;

                if (age == 0) 
                {
                    Console.WriteLine($"A média da turma é: {counter / entry}");
                    break;
                }
            } 
        }

        private void FifthExercise()
        {
            // 5)Criar um algoritmo que peça o nome e a idade de 5 mulheres. Após informar estes dados, 
            // o programa deve mostrar apenas porcentagem de mulheres que estão com idade entre 18 e 35.

            var counter = 0;
            var i = 0;
            for (; i < 5; i++)
            {
                Console.WriteLine("Digite a idade de uma mulher");
                var age = int.Parse(Console.ReadLine());

                if (age > 17 && age < 36)
                {
                    counter++;
                }
            }
            
            var percentage = (double)counter / i * 100;
            Console.WriteLine($"A percentagem de mulheres que tem a idade entre 18 e 35 é {percentage}%");
        }

        private void SixthExercise()
        {
            // Criar um algoritmo que simule uma urna eletrônica. Esta urna deve possuir dois candidatos
            // e possui três modos. O primeiro é o modo de CADASTRO, onde o sistema
            // cadastrar um candidato na urna o sistema deve solicitar ao usuário a senha para poder ter
            // acesso(a senha do sistema é Pa$$w0rd). O segundo modo é o modo de votos, onde o usuário 
            // pergunta o nome de cada um dos dois candidatos. Por medidas de segurança, para poder
            // informa 1 para votar no primeiro candidato e 2 para votar no segundo candidato. O terceiro modo,
            // é o modo de apuração de votos, onde o sistema verifica qual candidato tem mais votos. Caso o 
            // número de votos seja igual, o sistema deve imprimir a mensagem "SEGUNDO TURNO",
            // caso contrário deve imprimir o nome do candidato vencedor e o número de votos que ele obteve.

            (string? name, int vote) firstCandidate = (null, 0);
            (string? name, int vote) secondCandidate = (null, 0);

            while (true)
            {
                Console.WriteLine("Selecione um dos modos abaixo:");
                Console.WriteLine("1) Cadastro");
                Console.WriteLine("2) Votos");
                Console.WriteLine("3) Apuração de votos");     
                var mode = int.Parse(Console.ReadLine());

                if (mode == 1)
                {
                    var password = "";
                    do
                    {
                        Console.WriteLine("Digita sua senha:");
                        password = Console.ReadLine();
                    } while (password != "Pa$$w0rd");

                    Console.WriteLine("Digite o nome do 1º candidato");
                    firstCandidate.name = Console.ReadLine();

                    Console.WriteLine("Digite o nome do 2º candidato");
                    secondCandidate.name = Console.ReadLine();

                }

                else if (mode == 2)
                {
                    Console.WriteLine($"Digite 1 para o candidato {firstCandidate.name}");
                    Console.WriteLine($"Digite 2 para o candidato {secondCandidate.name}");
                    var candidateToVote = int.Parse(Console.ReadLine());

                    if (candidateToVote == 1) firstCandidate.vote++;
                    
                    else if (candidateToVote == 2) secondCandidate.vote++;
                }

                else if (true)
                {
                    if (firstCandidate.vote > secondCandidate.vote)
                    {
                        Console.WriteLine($"O candidato {firstCandidate.name} ganhou de {secondCandidate.name} com o total de {firstCandidate.vote} votos");
                    }

                    else if (firstCandidate.vote < secondCandidate.vote)
                    {
                        Console.WriteLine($"O candidato {secondCandidate.name} ganhou de {firstCandidate.name} com o total de {secondCandidate.vote} votos");
                    }

                    else
                    {
                        Console.WriteLine("Segundo turno");
                        continue;
                    }

                    break;
                }
            }
        }

        private void SeventhExercise()
        {
            // 7)Calcular a quantidade de dinheiro gasta por um fumante. 
            // Dados: o número de anos que ele fuma, o nº de cigarros fumados por dia e o preço de uma carteira.

            const int cigaretteAmountInWallet = 20;

            Console.WriteLine("Por quantos anos você fuma?");
            var years = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos cigarros você fuma por dia?");
            var cigaretteAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preço da carteira de cigarros?");
            var price = double.Parse(Console.ReadLine());

            var yearsSmoking = years * 365;
            var cigarettesSmokedPerYear = yearsSmoking * cigaretteAmount;
            var total = cigarettesSmokedPerYear / cigaretteAmountInWallet;

            Console.WriteLine($"Você gastou {total} reais em cigarro.");
        }

        private void EighthExercise()
        {
            // (╯°□°）╯︵ ┻━┻
            // Ler dois números inteiros, X e Y, e apresentar mensagem informando se o X é múltiplo de Y.
            // if (firstNumber % secondNumber == 0) Console.WriteLine($"{firstNumber} é múltiplo de {secondNumber}
            // else Console.WriteLine($"{firstNumber} não é múltiplo de {secondNumber}");

            Console.WriteLine("Digite o 1º número:");
            var firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º número:");
            var secondNumber = double.Parse(Console.ReadLine());

            var isMultiple = (firstNumber % secondNumber == 0)
                ? "é"
                : "não é";
                
            Console.WriteLine($"{firstNumber} {isMultiple} múltiplo de {secondNumber}");
        }

        private void NinthExercise()
        {
            //9)Fazer um algoritmo para ler 03 números reais do teclado e verificar se o 
            //primeiro é maior que a soma dos outros dois.
            
            Console.WriteLine("Digite o 1º número");
            var firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite 2º número");
            var secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite 3º número");
            var thirdNumber = int.Parse(Console.ReadLine());
            
            var isBigger = firstNumber > (secondNumber + thirdNumber)
                ? "maior"
                : "menor";
            Console.WriteLine($"{firstNumber} é {isBigger} que a soma de {secondNumber} com {thirdNumber}");
        }

        private void TenthExercise()
        {
            // 10)Ler 02 números reais do teclado (A e B), verificar e imprimir qual 
            // deles é maior, ou a mensagem "A = B" caso sejam iguais.

            Console.WriteLine("Digite o 1º número:");
            var firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º número:");
            var secondNumber = double.Parse(Console.ReadLine());

            var isBigger = firstNumber > secondNumber
                ? "maior"
                : "menor";

            Console.WriteLine($"{firstNumber} é {isBigger} que {secondNumber}");

            if (firstNumber == secondNumber) Console.WriteLine($"{firstNumber} = {secondNumber}");
        }

        private void EleventhExercise()
        {
            Console.WriteLine("Hello World!");
        }

        private void TwelfthExercise()
        {
            Console.WriteLine("Hello World!");
        }

        private void ThirteenthExercise()
        {
            Console.WriteLine("Hello World!");
        }

        private void fourteenthExercise()
        {
            Console.WriteLine("Hello World!");
        }

        private void FifteenthExercise()
        {
            Console.WriteLine("Hello World!");
        }

        private void SixteenthExercise()
        {
            Console.WriteLine("Hello World!");
        }

        private void SeventeenthExercise()
        {
            Console.WriteLine("Hello World!");
        }

        private void EighteenthExercise()
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
                { "6", SixthExercise },
                { "7", SeventhExercise },
                { "8", EighthExercise },
                { "9", NinthExercise },
                { "10", TenthExercise },
                { "11", EleventhExercise },
                { "12", TwelfthExercise },
                { "13", ThirteenthExercise },
                { "14", fourteenthExercise },
                { "15", FifteenthExercise },
                { "16", SixteenthExercise },
                { "17", SeventeenthExercise },
                { "18", EighteenthExercise }
            };
        }
    }
}
