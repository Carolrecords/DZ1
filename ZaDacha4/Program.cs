

   Console.WriteLine("Введите число: ");
   int number = Convert.ToInt32(Console.ReadLine());

   for (int i = 1; i <= number; i++)
   {
    if (i % 2 == 0) Console.WriteLine("{0} ,", i);
   }
