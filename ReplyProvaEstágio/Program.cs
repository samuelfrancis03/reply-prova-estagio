

using ReplyProvaEstágio;
using System;

Menu();

static void Menu() {
    int opcao;

    Console.WriteLine("\n>>>>>>> MENU <<<<<<<");
    Console.WriteLine("Processo seletivo Reply: Estágio Desenvolvimento.");
    Console.WriteLine("Selecione a questão: ");
    Console.WriteLine("1 - Questão 1;" +
                      "\n2 - Questão 2;" +
                      "\n3 - Questão 3;" +
                      "\n4- Questão 4;" +
                      "\n5 - Questão 5;" +
                      "\n6 - Questão 6;" +
                      "\n7 - Questão 7;" +
                      "\n8 - Questão 8;" +
                      "\n0 - Sair.");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao) {
        case 0:
            break;

        case 1:
            Question1();
            
            break;

        case 2:
            Question2();

            break;

        case 3:
            Question3();

            break;

        case 4:
            Question4();

            break;

        case 5:
            Question5();

            break;

        case 6:
            Question6();

            break;

        case 7:
            Question7();

            break;

        case 8:
            Question8();

            break;


    }
}


static void Question1() {
    int loop = 1, option;

    while (loop == 1)
    {
        
        Console.WriteLine("\nEnter:  " +
            "\n1 - Cotinue;" +
            "\n2 - Exit.");

        option = int.Parse(Console.ReadLine());

        if (option == 1)
        {
            Console.WriteLine("\nAnswer Question 1");
            Console.WriteLine("1) Letra C");
        }
        else if (option == 2)
        {
            loop = 0;
        }
        else 
        {
            Console.WriteLine("Invalid Option!");
        }
    }

    Menu();

}


static void Question2() {

    int loop = 1, option;

    while (loop == 1)
    {
        
        Console.WriteLine("\nEnter:  " +
            "\n1 - Cotinue;" +
            "\n2 - Exit.");
        option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                int trade = 0;
                int a = 10;
                int b = 20;
                Console.WriteLine("\nWelcome Progam of Trade");
                Console.WriteLine("\nThe value of A:  " + a + "\nThe value of B: " + b);
                Console.WriteLine("\nExchangin values");


                trade = a;
                a = b;
                b = trade;

                Console.WriteLine("\nThe new value of A:  " + a + "\nThe new value of B: " + b);

                break;

            case 2:
                loop = 0;

                break;

            default:
                    Console.WriteLine("Ivalid option!");

                break;
        }
    }
    
    Menu();

}

static void Question3()
{

    int loop = 1, option;

    while (loop == 1)
    {
        
        Console.WriteLine("\nEnter:  " +
            "\n1 - Cotinue;" +
            "\n2 - Exit.");
        option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                double wage, readjustment, newWage;
                Console.WriteLine("\nWelcome Progam of Salary Readjustment");
                Console.WriteLine("\nEnter your wage: ");
                wage = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the adjustment percentage: ");
                readjustment = double.Parse(Console.ReadLine());


                newWage = ((readjustment / 100) * wage) + wage;

                Console.WriteLine("The your new wage: " + newWage);

                break;

            case 2:
                loop = 0;

                break;
        }
    }

    Menu();

}

static void Question4()
{
    int loop = 1, option;

    while (loop == 1)
    {

        Console.WriteLine("\nEnter:  " +
            "\n1 - Cotinue;" +
            "\n2 - Exit.");

        option = int.Parse(Console.ReadLine());

        if (option == 1)
        {
            Console.WriteLine("\nAnswer Question 4");
            Console.WriteLine("4) O progama irá retornar 30");
        }
        else if (option == 2)
        {
            loop = 0;
        }
        else
        {
            Console.WriteLine("Invalid Option!");
        }
    }

    Menu();

}

static void Question5()
{
    int loop = 1, option;

    while (loop == 1)
    {

        Console.WriteLine("\nEnter:  " +
            "\n1 - Cotinue;" +
            "\n2 - Exit.");

        option = int.Parse(Console.ReadLine());

        if (option == 1)
        {
            Console.WriteLine("\nAnswer Question 5");
            Console.WriteLine("5) O progama irá escrever: 2 4");
        }
        else if (option == 2)
        {
            loop = 0;
        }
        else
        {
            Console.WriteLine("Invalid Option!");
        }
    }

    Menu();

}

static void Question6()
{
    int loop = 1, option;

    while (loop == 1)
    {

        Console.WriteLine("\nEnter:  " +
            "\n1 - Cotinue;" +
            "\n2 - Exit.");

        option = int.Parse(Console.ReadLine());

        if (option == 1)
        {
            Console.WriteLine("\nAnswer Question 6");
            Console.WriteLine("6) Letra A");
        }
        else if (option == 2)
        {
            loop = 0;
        }
        else
        {
            Console.WriteLine("Invalid Option!");
        }
    }

    Menu();

}


static void Question7()
{
    int loop = 1, option;

    while (loop == 1)
    {

        Console.WriteLine("\nEnter:  " +
            "\n1 - Cotinue;" +
            "\n2 - Exit.");

        option = int.Parse(Console.ReadLine());

        if (option == 1)
        {
            Console.WriteLine("\nAnswer Question 7");
            Console.WriteLine("7) Letra B");
        }
        else if (option == 2)
        {
            loop = 0;
        }
        else
        {
            Console.WriteLine("Invalid Option!");
        }
    }

    Menu();

}




static void Question8() {
    Calculadora calc = new Calculadora(0, 0);
    int opcao, num1, num2;
    int loop = 1;


    while (loop == 1)
    {

        Console.WriteLine("\n>>>>>>> CALCULADORA <<<<<<<");
        Console.WriteLine("Selecione a Operação ");
        Console.WriteLine("1 - SOMA; " +
                          "\n2 - MULTIPLICAÇÃO;" +
                          "\n3 - DESCONTO;" +
                          "\n0 - SAIR.");

        opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 0:
                loop = 0;
         
                break;

            case 1:
                Console.WriteLine("\nDigite o primeiro número da soma: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número da soma: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("O resultado da soma é: " + calc.Somar(num1, num2));

                break;

            case 2:
                Console.WriteLine("\nDigite o primeiro número do produto: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número do produto: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("O resultado da multiplicação é: " + calc.Multiplicar(num1, num2));

                break;

            case 3:
                Console.WriteLine("\nDigite o valor do produto: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o desconto (%): ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("O resultado do desconto é: " + calc.Descontar(num1, num2));

                break;

            default:

                Console.WriteLine("\nOpção escolhida inválida!");

                break;
        }

    }

    Menu();
   
}
