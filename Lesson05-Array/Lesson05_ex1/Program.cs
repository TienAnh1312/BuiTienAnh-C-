namespace Lesson05_ex1
{
    /// <summary>
    /// Khởi tạo mảng 1 chiều gồm 10 phần tử
    /// tìm phần tử nhỏ nhất
    /// đảo ngược mảng
    /// sắp xếp mảng tăng giảm
    /// tìm phần tử là số nguyên tố
    /// in ra số lượng các số dương liên tiếp nhiều nhất
    /// Tính trung bình cộng các phần tử dương
    /// kiểm tra mảng có chứa các phần tử âm dương, đan xen nhau không
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[] arrays = { 11, 21, 31, 42, 24, 55, 33, 32, 62, 98 };

            int chon = 0;

            do
            {
                menu();
                Console.WriteLine("Mời bạn chọn: ");
                chon = int.Parse(Console.ReadLine());  // nhận giá trị từ người dùng
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("1- Tìm phần tử nhỏ nhất");
                        int min = minArrays(arrays);
                        Console.WriteLine("Min: {0}", min);
                        break;
                    case 2:
                        Console.WriteLine("2- Đảo ngược mảng");
                        ReverseArray(arrays);
                        break;
                    case 3:
                        Console.WriteLine("3- Sắp xếp mảng tăng dần");
                        SortArray(arrays);
                        break;
                    case 4:
                        Console.WriteLine("4- Tìm các số nguyên tố trong mảng");
                        FindPrimeNumbers(arrays);
                        break;
                    case 5:
                        Console.WriteLine("5- In ra số lượng các số dương liên tiếp nhiều nhất");
                        int count = CountMaxConsecutivePositives(arrays);
                        Console.WriteLine("Số lượng các số dương liên tiếp nhiều nhất: {0}", count);
                        break;
                    case 6:
                        Console.WriteLine("6- Tính trung bình cộng các phần tử dương");
                        double avg = AverageOfPositiveNumbers(arrays);
                        Console.WriteLine("Trung bình cộng các phần tử dương: {0}", avg);
                        break;
                    case 7:
                        Console.WriteLine("7- Kiểm tra mảng có chứa các phần tử âm dương đan xen không");
                        bool isAlternating = CheckAlternatingSigns(arrays);
                        Console.WriteLine("Mảng đan xen âm dương: {0}", isAlternating);
                        break;
                    case 8:
                        Console.WriteLine("Kết thúc");
                        break;
                    default:
                        Console.WriteLine("Bạn chọn sai chức năng");
                        break;
                }

            } while (chon != 8);
        }

        // Menu chức năng của ứng dụng
        static void menu()
        {
            Console.WriteLine("1- Tìm phần tử nhỏ nhất \n" +
                              "2- Đảo ngược mảng \n" +
                              "3- Sắp xếp mảng tăng dần \n" +
                              "4- Tìm các số nguyên tố trong mảng \n" +
                              "5- In ra số lượng các số dương liên tiếp nhiều nhất \n" +
                              "6- Tính trung bình cộng các phần tử dương \n" +
                              "7- Kiểm tra mảng có chứa các phần tử âm dương đan xen nhau không \n" +
                              "8- Kết thúc");
        }

        // Tìm phần tử nhỏ nhất trong mảng
        static int minArrays(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                    min = arr[i];
            }
            return min;
        }

        // Đảo ngược mảng
        static void ReverseArray(int[] arr)
        {
            Console.WriteLine("Mảng ban đầu: {0}", String.Join(" ", arr));
            Array.Reverse(arr);
            Console.WriteLine("Mảng sau khi đảo: " + String.Join(" ", arr));
        }

        // Sắp xếp mảng tăng dần
        static void SortArray(int[] arr)
        {
            Console.WriteLine("Mảng trước khi sắp xếp: {0}", String.Join(" ", arr));
            Array.Sort(arr);
            Console.WriteLine("Mảng sau khi sắp xếp: {0}", String.Join(" ", arr));
        }

        // Tìm các số nguyên tố trong mảng
        static void FindPrimeNumbers(int[] arr)
        {
            Console.WriteLine("Các số nguyên tố trong mảng: ");
            foreach (int num in arr)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }

        // Kiểm tra một số có phải là số nguyên tố hay không
        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        // Đếm số lượng số dương liên tiếp nhiều nhất
        static int CountMaxConsecutivePositives(int[] arr)
        {
            int maxCount = 0, currentCount = 0;
            foreach (int num in arr)
            {
                if (num > 0)
                {
                    currentCount++;
                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                else
                {
                    currentCount = 0;
                }
            }
            return maxCount;
        }

        // Tính trung bình cộng các phần tử dương
        static double AverageOfPositiveNumbers(int[] arr)
        {
            int sum = 0, count = 0;
            foreach (int num in arr)
            {
                if (num > 0)
                {
                    sum += num;
                    count++;
                }
            }
            return count > 0 ? (double)sum / count : 0;
        }

        // Kiểm tra mảng có chứa các phần tử âm dương đan xen nhau không
        static bool CheckAlternatingSigns(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if ((arr[i - 1] >= 0 && arr[i] >= 0) || (arr[i - 1] < 0 && arr[i] < 0))
                    return false;
            }
            return true;
        }
    }
}
