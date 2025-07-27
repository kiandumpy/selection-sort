using System;


class Program
{
    static void Main()
    {

        Console.WriteLine("Enter an elements: ");
        int size = int.Parse(Console.ReadLine());

        int[] myArray = new int[size];

         Console.WriteLine("Enter the elements:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}: ");
            myArray[i] = int.Parse(Console.ReadLine());
        }
        //int[] myArray = { 3, 6, 1, 7, 2 };

        Console.WriteLine("Before Sorting");
        Showarray(myArray);

        SortSelection(myArray);

        Console.WriteLine("After Sorting");
        Showarray(myArray);
    }
    //sort ko select loke poh (inner loop 1 ku outer loop 1ku)
    //for loop ko thone dl
    //
    static void SortSelection(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIdx = i;

            for (int j = i + 1; j < array.Length; j++)

                if (array[j] < array[minIdx])
                {
                    minIdx = j;
                }
            //loc change pee front ko poh dok mae code
            int tpoAr = array[i];
            array[i] = array[minIdx];
            array[minIdx] = tpoAr;
        }
    }

    static void Showarray(int[] array)
    {
        foreach (int num in array)
        {
            Console.WriteLine("After SelectionSort" + num);
        }
        Console.WriteLine();
    }
}



