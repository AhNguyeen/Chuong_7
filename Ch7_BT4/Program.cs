//Ch7_BT4: Nhap mang A co N phan tu va tach ra 2 mang B voi cac so va mang C voi cac so le
//Dang Anh Nguyen
//Date: 28/11/2024
internal class Program
{
    private static void Main(string[] args)
    {
        int num = 0;
        num = NhapSoNguyen(num);
        //Tạo mảng
        Console.WriteLine("Mang ArrA la: ");
        int[] ArrA = TaoMang(num);
        
        
    }
    static int[] TaoMang(int num)
    {
        int[] Arr = new int[num];
        for(int i = 0; i < num; i++)
        {
            Console.Write($"[{i}]: ");
            int.TryParse(Console.ReadLine(), out Arr[i]);
        }    
        return Arr;
    }
    static int NhapSoNguyen(int num)
    {
            Console.Write("Nhap mot so nguyen bat ky: ");
            int.TryParse(Console.ReadLine(), out num);
        return num;
    }
}