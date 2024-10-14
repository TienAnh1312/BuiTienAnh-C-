
/// <summary>
/// Author: Tiến Anh
/// Date  : 14/10/2024
/// Objective: Sử dụng biến, hằng và kiểu dữ liệu
/// </summary>
internal class program
{
    
    static void Main(string[] args)
    {
        //khai báo các biến 
        int id = 1;
        string Name = "Tien Anh";
        byte age = 18;
        char gender = 'M';
        //Khai báo hằng số
        const float percent = 75.50F;

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        //Hiển thị giá trị các biến và hằng số
        Console.WriteLine("ID : {0}", id);
        Console.WriteLine("Name :" + Name);
        Console.WriteLine("Age : {0}", age);
        Console.WriteLine("Gender : " + gender);
        Console.WriteLine("percentage : {0}", percent);

    }
}

