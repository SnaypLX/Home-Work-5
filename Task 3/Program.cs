// Написать программу копирования массива

int[] arr = { 5, 4, 7, 2, 9 };
 
        int[] copy = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++) {
            copy[i] = arr[i];
        }
 
        Console.WriteLine(String.Join(", ", copy));


