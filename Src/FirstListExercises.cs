using ExercisesLists.SecondLists;

namespace ExercisesLists.FirstLists
{
    public abstract class FirstList : SecondList
    {
        protected Dictionary<string, Action> FirstExerciseList => GetExercises();

        private void FirstExerciseA()
        {
            // a)Os números de 1 a 10 de forma crescente

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{i}");
            }
        }

        private void FirstExerciseB()
        {
            // Os números de 1 a 10 de forma decrescente

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"{i}");
            }
        }

        private void FirstExerciseC()
        {
            // Os números de 1 a 10 de forma crescente, mas apenas aqueles
            // que forem par.

            for (int i = 0; i < 11; i+=2)
            {
                Console.WriteLine($"{i}");
            }
        }

        private void SecondExercise()
        {
            //2)Imprimir a soma dos números inteiros de 1 a 100.
    
            var sum = 0;
            for (int start = 1; start <= 100; start++)
            {
                sum += start;
            }

            Console.WriteLine($"A soma dos números de 1 a 100 é: {sum}");
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
            // Ler 02 números inteiros do teclado. Se o segundo for diferente de 
            // zero, calcular e imprimir o quociente do primeiro pelo segundo. 
            // Caso contrário, imprimir a mensagem: "DIVISÃO POR ZERO".

            Console.WriteLine("Digite o 1º número:");
            var firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º número:");
            var secondNumber = int.Parse(Console.ReadLine());

            if (secondNumber != 0)
            {
                var result = firstNumber / secondNumber;
                Console.WriteLine($"O resultado de {firstNumber} divido por {secondNumber} é {result}");
            }

            else Console.WriteLine("DIVISÃO POR ZERO");
        }

        private void TwelfthExercise()
        {
            // Ler 4 números inteiros e calcular a soma dos que forem pares.

            var sum = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite um número");
                var number = int.Parse(Console.ReadLine());

                if (number % 2 == 0) sum += number;
            }

            Console.WriteLine($"A soma dos pares é: {sum}");
        }

        private void ThirteenthExercise()
        {
            // Ler 10 valores e determinar o maior dentre eles.

            var highestNumber = 0;
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um número:");
                var number = int.Parse(Console.ReadLine());
                
                if (number > highestNumber) highestNumber = number;
            }
            
            Console.WriteLine($"O maior número é: {highestNumber}");
        }

        private void fourteenthExercise()
        {
            // Ler três valores e colocar-lós em ordem.

            Console.WriteLine("Digite o 1º número");
            var firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º número");
            var secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 3º número");
            var thirdNumber = double.Parse(Console.ReadLine());

        }

        private void FifteenthExercise()
        {
            // Ler 10 números e imprimir quantos são múltiplos de 3 e quantos são múltiplos de 5.

            var multipleThree = 0;
            var multipleFive = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um número:");
                var number = double.Parse(Console.ReadLine());

                if (number % 3 == 0) multipleThree++;
                
                if (number % 5 == 0) multipleFive++;
            }

            Console.WriteLine($"Dos números que você digitou apenas {multipleThree} são múltiplos de 3 e apenas {multipleFive} são múltiplos de 5.");
        }

        private void SixteenthExercise()
        {
            // Ler o salário de uma pessoa e imprimir o Salário Líquido de acordo com a redução do imposto descrito ao lado:
            // Menor ou igual a R$ 600,00 - ISENTO de desconto
            // Maior que R$ 600 e menor ou igual a 1.200 - 20% desconto
            // Maior que R$ 1.200 e menor ou igual a R$2.000 - 25% desconto
            // Maior que R$ 2.000,00 - 30% desconto

            Console.WriteLine("Digite o seu salário");
            var salary = double.Parse(Console.ReadLine());

            var salaryDiscount = salary switch
            {
                <= 600.00 => salary,
                > 600 and < 1200 => (20 / 100) * salary,
                > 1200 and <= 2000 => (25 / 100) * salary,
                _ => (30 / 100) * salary
            };

            Console.WriteLine($"O salário ficou {salary}");

            // if (salary <= 600.00)
            // {
            //     Console.WriteLine($"Seu salário ficou: {salary}");
            // }

            // if (salary > 600 && salary < 1200)
            // {
            //     var salaryDiscount = (20 / 100) * salary; 

            //     Console.WriteLine($"Seu salário ficou: {salaryDiscount}");
            // }

            // else if (salary > 1.200 && salary <= 2.000)
            // {
            //     var salaryDiscount = (25 / 100) * salary; 

            //     Console.WriteLine($"Seu salário ficou: {salaryDiscount}");
            // }

            // else
            // {
            //     var salaryDiscount = (30 / 100) * salary; 

            //     Console.WriteLine($"Seu salário ficou: {salaryDiscount}");
            // }
        }

        private void SeventeenthExercise()
        {
            // (╯°□°）╯︵ ┻━┻
            // Imprimir a tabuada de qualquer número fornecido 
            // pelo usuário até que o usuário forneça o valor –1.

            while (true)
            {
                Console.WriteLine("\nDigite a tabuada que você deseja:"); 
                var timeTable = double.Parse(Console.ReadLine());
                if (timeTable == -1) break;

                Console.Write("\n");

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(timeTable * i);
                }
            }
        }

        private void EighteenthExercise()
        {
            // As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se forem compradas 
            // pelo menos 12. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o custo total da compra.

            Console.WriteLine("Quantas maças você quer comprar?");
            var appleQuanty = int.Parse(Console.ReadLine());
            
            if (appleQuanty < 12)
            {
                var applePrice = Math.Round(appleQuanty * 1.30, 2);

                Console.WriteLine($"Preço total das maças: {applePrice}");
            }

            else
            {
                var applePrice = Math.Round(appleQuanty * 1.00, 2);

                Console.WriteLine($"Preço total das maças: {applePrice}");
            }	
        }

        private Dictionary<string, Action> GetExercises()
        {
            return new Dictionary<string, Action>
            {
                { "1A", FirstExerciseA },
                { "1B", FirstExerciseB },
                { "1C", FirstExerciseC },
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
