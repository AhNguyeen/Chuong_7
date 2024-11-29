//Ch7_BT3: Cho phep nhap 2 mang ArrA va ArrB roi tinh ArrC bang cach tinh tong ArrA + ArrB
//Dang Anh Nguyen
//Date: 28/11/2024
using System.Security.Cryptography;

internal class Ch7_BT3
{
    private static void Main(string[] args)
    {
        int num = 0;        
        num = NhapSoNguyen(num);
        //Tao mang
        Console.WriteLine("Mang ArrA la: ");
        int[] ArrA = TaoMang(num);
        Console.WriteLine("Mang ArrB la: ");
        int[] ArrB = TaoMang(num);
        int[]ArrC = TinhTong(ArrA, ArrB);
        XuatMang("ArrC", ArrC);



    }
    static void XuatMang(string name, int[] Arr)
    {
        Console.Write($"Mang {name} la: ");
        foreach ( int i in Arr ) 
        {
            Console.Write(i + " ");
        }
        
    }
    static int[] TinhTong(int[] ArrA, int[] ArrB)
    {
        int[] ArrC = new int[ArrA.Length];
        for(int i = 0;i < ArrA.Length;i++)
        {
            ArrC[i] = ArrA[i] + ArrB[i];
        }    
        return ArrC;
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
        do
        {
            Console.Write("Nhap mot so nguyen duong: ");
            int.TryParse(Console.ReadLine(), out num);
        }
        while (num < 0);
        return num;
    }
}