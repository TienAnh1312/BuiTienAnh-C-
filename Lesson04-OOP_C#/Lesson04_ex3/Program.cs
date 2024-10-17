namespace Lesson04_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Document document = new Document();
            document.content = "Đây là nội dung cảu document";
            string filePath = "document.txt";
            //ghi vào file
            document.Write(filePath);
            //đọc lại từ file
            document.Read(filePath);
            Console.WriteLine($"nội dung tài liệu: {document.content}");

            string encrytedContent = document.Encrypt();
            Console.WriteLine($"mã hóa nội dung:{encrytedContent}");

            //gán dữ liệu đã mã hóa cho document để thử giải mã
            document.content = encrytedContent;
            string decryptedContent = document.Decrypt();
            Console.WriteLine($"Decryted nội dung:{decryptedContent}");
        }
    }
}
