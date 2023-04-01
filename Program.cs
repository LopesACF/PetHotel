Console.Write("+================================================+\n"); Console.ForegroundColor  = ConsoleColor.DarkYellow; Console.Write("/  Bem vindo ao Pet Holtel Descanso do Caramelo  /\n"); Console.ResetColor(); Console.Write("+================================================+\n");

Console.ResetColor(); Thread.Sleep(1000);

Console.ForegroundColor = ConsoleColor.Green;

Console.Write("Qual a especie do seu animal? ");

String especie = Console.ReadLine()!;

Console.ResetColor(); Thread.Sleep(1000);

Console.ForegroundColor = ConsoleColor.Red;

Console.Write($"Muito bem, qual a raça do(a) {especie}? ");

String raça = Console.ReadLine()!;

Console.ResetColor(); Thread.Sleep(1000);

Console.ForegroundColor = ConsoleColor.Yellow;

Console.Write("Como posso chama-lo(a)? ");

String nome = Console.ReadLine()!;

Console.ResetColor(); Thread.Sleep(1000);

Console.ForegroundColor = ConsoleColor.Cyan;

Console.Write($"Qual a idade do(a) {nome}? ");

String idade = Console.ReadLine()!;

Console.ResetColor(); Thread.Sleep(1000);

Console.ForegroundColor = ConsoleColor.Magenta;

Console.Write($"Qual a cor do(a) {nome}? ");

String Cor = Console.ReadLine()!;

Console.ResetColor();  Console.Clear();

Console.Write("+================================================+\n"); Console.ForegroundColor  = ConsoleColor.DarkYellow; Console.Write("/  Bem vindo ao Pet Holtel Descanso do Caramelo  /\n"); Console.ResetColor(); Console.Write("+================================================+\n");

Console.ResetColor(); Console.WriteLine();

Console.WriteLine("+================================================+");

Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine($"Especie: {especie}"); Console.ResetColor();

Console.WriteLine("+================================================+");

Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine($"Raça: {raça}"); Console.ResetColor();

Console.WriteLine("+================================================+");

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine($"Nome: {nome}"); Console.ResetColor();

Console.WriteLine("+================================================+");

Console.ForegroundColor = ConsoleColor.Cyan;

Console.WriteLine($"Idade: {idade}"); Console.ResetColor();

Console.WriteLine("+================================================+");

Console.ForegroundColor = ConsoleColor.Magenta;

Console.WriteLine($"Cor: {Cor}"); Console.ResetColor();

Console.WriteLine("+================================================+");

