class Program {
    public static void Main(string[] args)
    {
        int age;
        Console.WriteLine("Nhập tuổi của bạn");
        age = Convert.ToInt32(Console.ReadLine());
        string result = (age >= 18) ? "trưởng thành" : (age >= 13 ? "vị thành niên" : "trẻ em");
        Console.WriteLine(result);
    }
}