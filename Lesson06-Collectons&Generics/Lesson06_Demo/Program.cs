using System.Collections;

namespace Lesson06_Demo
{
    /// <summary>
    /// Demo: ArrayList
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo ArrayList!");

            //khởi tạo
            ArrayList arrayList = new ArrayList();

            //thêm các phần tử
            //arrayList.Add(111);
            arrayList.Add("Tiến Anh");

            //AddRange
            string[] strs = { "Đăng", "An", "Vinh", "Hoa" };
            arrayList.AddRange(strs);

            //in mảng
            printArray(arrayList);

            //Insert
            arrayList.Insert(0, "TA");
            printArray(arrayList);

            //remove
            arrayList.Remove("TA");
            printArray(arrayList);

            //remove ptu thứ 1
            arrayList.RemoveAt(1);
            printArray(arrayList);

            //sort
            arrayList.AddRange(strs);
            printArray(arrayList);

            arrayList.Sort();
            printArray(arrayList);
        }

        static void printArray(ArrayList arrayList)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Danh sách các phần tử: ");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
        }
    }
}
