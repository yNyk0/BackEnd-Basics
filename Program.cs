static void Excercise1A()
{
    //1)Crie um programa que imprima:
    //Os números de 1 a 10 de forma crescente
    
    for (int counter = 1; counter < 10; counter++)
    {
        System.Console.WriteLine(counter);
    }
}

static void Excercise1B()
{
    //1)Crie um programa que imprima:
    //Os números de 1 a 10 de forma decrescente

    for (int counter = 10; counter > 0; counter--)
    {
        System.Console.WriteLine(counter);
    }

}

static void Excercise1C()
{
    //1)Crie um programa que imprima:
    //Os números de 1 a 10 de forma crescente, mas apenas aqueles que forem par.

    for (int counter = 2; counter < 11; counter+=2)
    {
        System.Console.WriteLine(counter);
    }

}

static void Excercise2()
{
    //2)Imprimir a soma dos números inteiros de 1 a 100.
    
    int sum = 0;
    for (int start = 1; start <= 100; start++)
    {
        sum += start;
    }
    System.Console.WriteLine($"A soma dos números de 1 a 100 é: {sum}");

}

static void Excercise3()
{
    //3)Imprimir todo os números ímpares menores de 200.

    for (int counter = 1; counter < 200; counter += 2)
    {
        System.Console.WriteLine(counter);
    }
}

static void Excercise4()
{
    //Calcular a média de idade de uma turma qualquer. 
    //O algoritmo deve parar quando for digitada a idade igual a zero.

    int counter = 0;

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

static void Excercise5()
{
    // 5)Criar um algoritmo que peça o nome e a idade de 5 mulheres. Após informar estes dados, 
    // o programa deve mostrar apenas porcentagem de mulheres que estão com idade entre 18 e 35.

    var counter = 0;
    int i = 0;
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

static void Excercise6()
{
    //     Criar um algoritmo que simule uma urna eletrônica. Esta urna deve possuir dois candidatos
    //     e possui três modos. O primeiro é o modo de CADASTRO, onde o sistema
    //     pergunta o nome de cada um dos dois candidatos. Por medidas de segurança, para poder
    //     cadastrar um candidato na urna o sistema deve solicitar ao usuário a senha para poder ter
    //     acesso(a senha do sistema é Pa$$w0rd). O segundo modo é o modo de votos, onde o usuário 
    //     informa 1 para votar no primeiro candidato e 2 para votar no segundo candidato. O terceiro modo,
    //    é o modo de apuração de votos, onde o sistema verifica qual candidato tem mais votos. Caso o 
    //     número de votos seja igual, o sistema deve imprimir a mensagem "SEGUNDO TURNO",
    //    caso contrário deve imprimir o nome do candidato vencedor e o número de votos que ele obteve.

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

static void Excercise7()
{
    
}

static void Excercise9()
{
    //9)Fazer um algoritmo para ler 03 números reais do teclado e verificar se o 
    //primeiro é maior que a soma dos outros dois.
    
    // if (firstNumber > (secondNumber + thirdNumber))
    // {
    //     Console.WriteLine($"{firstNumber} é maior que a soma de {secondNumber} e {thirdNumber}");
    // }
    // else
    // {
    //     Console.WriteLine($"{firstNumber} é menor que a soma de {secondNumber} e {thirdNumber}");
    // }
    
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

Excercise6();