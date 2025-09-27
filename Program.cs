class Program{
    public static void Main(string[] args)
    {
        int age;
        Console.WriteLine("Nhập tuổi của bạn");
        age = Convert.ToInt32(Console.ReadLine());
        string status;
        if (age >= 18)
        {
            status = "adult";
            Console.WriteLine("bạn đã trưởng thành");

        }
        else if (age < 18 && age >= 13)
        {
            status = "teenager";
            Console.WriteLine("Bạn là thanh thiếu niên");
        }
        else
        {
            status = "child";
            Console.WriteLine("bạn là trẻ em"); 
        }

    
    }
}
