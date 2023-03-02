int adultos, criancas, animais;
double valoraluguel, valorfinal;

adultos = 0;
criancas = 0;
animais = 0;
valoraluguel = 0;
valorfinal = 0;

Console.WriteLine("Qual o valor atual do aluguel?");
valoraluguel = double.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de adultos na casa?");
adultos = int.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de criancas na casa?");
criancas = int.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de animais na casa?");
animais = int.Parse(Console.ReadLine());

valorfinal = valoraluguel - (adultos * (valoraluguel * 0.0125)) - (criancas * (valoraluguel * 0.0107)) + (animais * (valoraluguel * 0.02));

Console.WriteLine("O valor final do aluguel é: " + valorfinal);