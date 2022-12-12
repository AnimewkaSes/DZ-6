internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите размер массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int [] arr = new int[n];
        int result = 0;
        
        Console.WriteLine("Заполните массив: ");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Введённый массив: ");
        
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} ",arr[i]);
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i]>0)
            {
                result +=1;
            }
        }


        if (result>0)
        {
           Console.WriteLine("\nКоличество чисел > 0 : {0}", result); 
        }else{
        
        Console.WriteLine("\nСреди введённого множества, нет чисел > 0 ");
        }
    }
}