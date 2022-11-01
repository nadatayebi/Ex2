using System;
public class Exercise13
{
    public static void Main()
    {
        int[] arr1 = new int[10];
        int i, n, p = 0, inval;
        Console.Write("\n\nInsert New value in the sorted array :\n");

        Console.Write("entrer la taille de tableau: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write(" entrer {0} les elements de tableau :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("entre le nombre que vous voulez inserer : ");
        inval = Convert.ToInt32(Console.ReadLine());
        Console.Write("The exist array list is :\n ");
        for (i = 0; i < n; i++)
            Console.Write("{0} ", arr1[i]);
        for (i = 0; i < n; i++)
            if (inval < arr1[i])
            {
                p = i;
                break;
            }
        for (i = n; i >= p; i--)
            arr1[i] = arr1[i - 1];
        arr1[p] = inval;

        Console.Write("Nouveau table est :\n ");
        for (i = 0; i <= n; i++)
            Console.Write("{0} ", arr1[i]);
        Console.Write("\n");
    }
}
