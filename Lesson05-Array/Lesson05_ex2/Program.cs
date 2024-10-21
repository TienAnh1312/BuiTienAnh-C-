namespace Lesson05_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
           
                // Khai báo và khởi tạo mảng 2 chiều với 4 dòng và 4 cột
                int[,] array = new int[4, 4] {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

                // In mảng theo hàng cột
                Console.WriteLine("Mảng ban đầu:");
                PrintArray(array);

                // Tính tổng các phần tử mà có chỉ số hàng=chỉ số cột
                int diagonalSum = CalculateDiagonalSum(array);
                Console.WriteLine($"\nTổng các phần tử có chỉ số hàng = chỉ số cột: {diagonalSum}");

                // In ra các phần tử nhỏ nhất trên mỗi cột
                Console.WriteLine("\nPhần tử nhỏ nhất trên mỗi cột:");
                PrintMinElementsOfColumns(array);

                // Liệt kê các phần tử chia hết cho 7
                Console.WriteLine("\nCác phần tử chia hết cho 7:");
                ListMultiplesOfSeven(array);

                // Tìm tổng các phần tử nằm trên đường viền của mảng
                int borderSum = CalculateBorderSum(array);
                Console.WriteLine($"\nTổng các phần tử nằm trên đường viền của mảng: {borderSum}");

                // Chuyển thành mảng 1 chiều rồi sắp xếp tăng dần
                int[] oneDArray = ConvertTo1DAndSort(array);
                Console.WriteLine("\nMảng 1 chiều sau khi sắp xếp tăng dần:");
                Console.WriteLine(String.Join(" ", oneDArray));
            }

            // Hàm in mảng 2 chiều
            static void PrintArray(int[,] arr)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            // Hàm tính tổng các phần tử có chỉ số hàng = chỉ số cột
            static int CalculateDiagonalSum(int[,] arr)
            {
                int sum = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    sum += arr[i, i]; // Chỉ số hàng = chỉ số cột
                }
                return sum;
            }

            // Hàm in phần tử nhỏ nhất trên mỗi cột
            static void PrintMinElementsOfColumns(int[,] arr)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    int min = arr[0, col];
                    for (int row = 1; row < arr.GetLength(0); row++)
                    {
                        if (arr[row, col] < min)
                            min = arr[row, col];
                    }
                    Console.WriteLine($"Cột {col + 1}: {min}");
                }
            }

            // Hàm liệt kê các phần tử chia hết cho 7
            static void ListMultiplesOfSeven(int[,] arr)
            {
                bool found = false;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] % 7 == 0)
                        {
                            Console.Write(arr[i, j] + " ");
                            found = true;
                        }
                    }
                }
                if (!found)
                    Console.WriteLine("Không có phần tử nào chia hết cho 7.");
            }

            // Hàm tính tổng các phần tử trên đường viền của mảng
            static int CalculateBorderSum(int[,] arr)
            {
                int sum = 0;
                int n = arr.GetLength(0); // số dòng
                int m = arr.GetLength(1); // số cột

                // Cộng các phần tử ở 2 hàng đầu tiên và cuối cùng
                for (int col = 0; col < m; col++)
                {
                    sum += arr[0, col]; // Hàng đầu tiên
                    sum += arr[n - 1, col]; // Hàng cuối cùng
                }

                // Cộng các phần tử ở 2 cột đầu tiên và cuối cùng (trừ các phần tử đã tính ở hàng đầu/ cuối)
                for (int row = 1; row < n - 1; row++)
                {
                    sum += arr[row, 0]; // Cột đầu tiên
                    sum += arr[row, m - 1]; // Cột cuối cùng
                }

                return sum;
            }

            // Hàm chuyển mảng 2 chiều thành mảng 1 chiều và sắp xếp tăng dần
            static int[] ConvertTo1DAndSort(int[,] arr)
            {
                int[] oneDArray = new int[arr.Length];
                int index = 0;

                // Chuyển từng phần tử của mảng 2 chiều sang mảng 1 chiều
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        oneDArray[index++] = arr[i, j];
                    }
                }

                // Sắp xếp mảng tăng dần
                Array.Sort(oneDArray);
                return oneDArray;
            }
        }
    }

