namespace Lesson07_ex2
{
    /// <summary>
    /// InvalidCastException
    /// IndexOutOfRangeException.
    ///ArrayTypeMismatchException.
    /// </summary>
  

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // InvalidCastException
            try
            {
                // Tạo một đối tượng kiểu object
                object str = "Hello, world!";

                // Cố gắng ép kiểu từ object sang int (sai kiểu, sẽ gây lỗi)
                int num = (int)str; // Lỗi InvalidCastException
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("InvalidCastException: Không thể ép kiểu giữa các kiểu không tương thích.");
                Console.WriteLine(e.Message);
            }

            // IndexOutOfRangeException
            try
            {
                int[] numbers = { 1, 2, 3 };

                // Cố gắng truy cập chỉ số ngoài phạm vi của mảng (gây lỗi)
                int number = numbers[5]; // Lỗi IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException: Chỉ số vượt ngoài phạm vi của mảng.");
                Console.WriteLine(e.Message);
            }

            // ArrayTypeMismatchException
            try
            {
                // Tạo một mảng kiểu object
                object[] objects = new object[3];

                // Thêm các giá trị vào mảng
                objects[0] = "Hello";
                objects[1] = 123;

                // Cố gắng thêm một kiểu không hợp lệ vào mảng (sẽ gây lỗi)
                objects[2] = new int[5]; // Lỗi ArrayTypeMismatchException
            }
            catch (ArrayTypeMismatchException e)
            {
                Console.WriteLine("ArrayTypeMismatchException: Không thể thêm kiểu không hợp lệ vào mảng.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
