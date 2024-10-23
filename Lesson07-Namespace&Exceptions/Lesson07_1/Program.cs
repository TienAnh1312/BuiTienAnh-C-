using Lesson07_1.Store;

namespace Lesson07_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //tạo mới nhà phân phối cung cấp đầy đủ namespace
            Supply.Manufacturer dealer = new Supply.Manufacturer();

            //gán giá trị
            dealer.Name = "Thực phẩm TA";
            dealer.Email = "TPTA@gmail.com";
            dealer.Phone = "0828345288";

            //in thông tin
            Console.WriteLine("Dealer infomation");
            Console.WriteLine("\t Name: " + dealer.Name);
            Console.WriteLine("\t Email: " + dealer.Email);
            Console.WriteLine("\t Phone: " + dealer.Phone);

            //tạo mới sản phẩm trong namespace Store
            StoreItem si = new StoreItem();

            //gán giá trị
            si.ItemNo = 613508;
            si.ItemName = "TANEW";
            si.Price = 80.00M;

            //in thông tin
            Console.WriteLine("Store Inventory");
            Console.Write("\t Item #: ");
            Console.WriteLine(si.ItemNo);
            Console.Write("\t Item Name: ");
            Console.WriteLine(si.ItemName);
            Console.Write("\t Item Price: ");
            Console.WriteLine(si.Price);

            Console.ReadLine();
        }
    }
}
