//Ch7_BT2: Nhap vao mang so nguyen, neu nhap sai yeu cau nhap lai, nhap cho toi khi nao nguoi nhap vao -1 thi truong trinh ket thuc. In ra cac so da nhap
//Dang Anh Nguyen
//Date: 27/11/2024
using System.ComponentModel;

internal class Ch7_BT2
{
    private static void Main(string[] args)
    {
        List<int>nums = new List<int>();
        while (true)
        {
            int num;
            Console.Write("Nhap so nguyen bat ky (nhap -1 de dung lai): ");
            int.TryParse(Console.ReadLine(), out num);
            if (num == -1)
            {
               break;
            }
            else
            {
                Console.WriteLine("Gia tri khong hop le! Vui long nhap mot gia tri khac.\n");
            }
            nums.Add(num);           
        }
        foreach (int num in nums)
        {
            Console.Write(num + " ");
        }
    }
    
}