using System;
namespace DEV1
{
    class Program
    {
        static void Main()
        {
            string our_string = Console.ReadLine();
            int maxcount = 0;
           
            for(int k = 0; k < our_string.Length; k++)
            {
                int add_count = 1;
                for (int j = k + 1; j < our_string.Length; j++)
                {
                    if (our_string[k] != our_string[j])
                    break;
                    add_count++;
                }
                if(add_count > maxcount)
                {
                    maxcount = add_count;
                }               
            }
            Console.WriteLine(maxcount);  
        }
    }
}
