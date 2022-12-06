// Задача №29. Программа, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку

int[] array = new int[8];
Random myRandom = new Random();
Console.WriteLine("Вывод массива");
for (int i = 0; i < array.Length; i++) array[i] = myRandom.Next(0, 8);
for (int i = 0; i < array.Length; i++) Console.Write("{0} ", array[i]);

