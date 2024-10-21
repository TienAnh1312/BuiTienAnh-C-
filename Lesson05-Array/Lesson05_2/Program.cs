namespace Lesson05_2
{
    /// <summary>
    /// mảng 2 chiều 4x3
    /// Duyệt mảng và in teo ma trận cột
    /// In ra phần tử có chỉ số hàng bằng chỉ số cột
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Mảng 2 chiều");
            int[,] arrays =
            {
                {4, 6, 9 },
                {2, 4, 5 },
                {9, 2, 6 },
                {1, 6, 3 }
            };
            //duyệt mảng và in
            printArray(arrays);
        }
        static void printArray(int[,] arrays)
        {
            //duyệt mảng và in theo hàng cột
            Console.WriteLine("Các phần tử trong mảng");
            for (int i = 0; i <= arrays.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arrays.GetUpperBound(1); j++)
                {
                    Console.Write(" {0} ", arrays[i, j]);
                }
                Console.WriteLine();
            }  
            
            //Tìm các phần tử có chỉ số hàng bằng chỉ số cột
            Console.WriteLine("Các phần tử có chỉ số hàng bằng chỉ số cột") ;
            for (int i = 0;i <= arrays.GetUpperBound(0); i++)
            {
                for(int j = 0;j <= arrays.GetUpperBound(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(" {0} ", arrays[i,j]);
                    }
                }
            }  
            
            //Các phần tử lớn nhất trên hàng
            Console.WriteLine("Các phần tử lớn nhất trên mảng");
            for (int i = 0; i <= arrays.GetUpperBound(0) ; i++)
            {
                int max = arrays[i, 0];
                for (int j = 0;j <= arrays.GetUpperBound(1); j++)
                {
                    if (max < arrays[i, j])
                    {
                        max = arrays[i, j];
                    }    
                }    
                Console.WriteLine("Hang {0}:{1}",i,max);
            }    
        }
    }
}
