Console.Write("Въведи двуцифрено число: ");

int numbers = int.Parse(Console.ReadLine());

int ed = numbers % 10;

int des = numbers / 10;

int sum = ed + des;

Console.WriteLine($"{ed} + {des} = {sum}");