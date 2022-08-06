// See https://aka.ms/new-console-template for more information
Console.WriteLine("Print the Nth Harmonic Value");
        int i,n;
        double sum = 0.0;
        Console.WriteLine("Input the number of terms : ");
        n = Convert.ToInt32(Console.ReadLine());
        for (i = 1; i <= n; i++)
        {
            Console.WriteLine("1/{0} + ", i);
            sum += 1 / (float)i;
        }
        Console.WriteLine("Sum of Series upto {0} terms : {1}", n, sum);