//string hello = "We are the champions?";

//int stringLength = hello.Length;

//hello = hello.Trim();

//char firstLetter = hello[0];
//Console.Write(firstLetter);

//hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

//firstLetter = hello[0];

//Console.WriteLine(firstLetter);
//Console.WriteLine(hello);

//Random

//string hello = "We are the champions?";

//int stringLength = hello.Length;

//hello = hello.Trim();

//char firstLetter = hello[0];
//Console.Write(firstLetter);

//hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

//firstLetter = hello[0];

//Console.WriteLine(firstLetter);
//Console.WriteLine(hello);


﻿int[] numbers = new int[10];
Random random = new Random();

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(1, numbers.Length + 1);
    sum = sum + numbers[i];
}

foreach(int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine($"Total: {sum}");