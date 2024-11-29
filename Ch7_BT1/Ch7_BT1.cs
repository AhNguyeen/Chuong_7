/* Ch7_BT1: Nhập một số nguyên N với 1<=n<=100, nhập sai yêu cầu nhập lại. Viết các hàm thực hiện:
 * Đặng Anh Nguyên
 * Date: 23/11/2024
 */
using System;
using System.ComponentModel.DataAnnotations;

namespace Ch7_BT1
{
    internal class Ch7_BT1
    {
        static void Main(string[] args)
        {
            int num = 0;
            num = SoNguyenDuong(num);
            //a. Nhập mảng số nguyên n phần tử
            Console.WriteLine($"A. Mang so nguyen {num} phan tu la: ");
            int[] Arr = MangSoNguyen(num);
            //b. Xuất mảng vừa nhập
            Console.Write("B. ");
            XuatMangVuaNhap(Arr);
            //c. Xuat cac so chan trong mang
            Console.Write("C. ");
            XuatMangChan(Arr);
            //d. Xuất các số là số nguyên tố trong mảng
            Console.WriteLine("D. Cac so nguyen to trong mang la: ");
            XuatSoNguyenToTrongMang(Arr);
            //e. Tính tổng trung bình cộng các phần tử trong mảng           
            TrungBinhCong(Arr);
            //f. Đếm số lượng các số hoàn thiện có trong mảng
            DemSoHoanThien(Arr);
            //g. Tìm vị trí cuối cùng của x trong mảng
            int x = 0;
            Console.Write("Nhap gia trinh muon tim x = ");
            int.TryParse(Console.ReadLine(),out x);
            int viTri = ViTriCuoiCungCuaX(Arr, x);
            if(viTri == -1)
            {
                Console.WriteLine($"G. Khong ton tai {x} trong mang!");
            }    
            else
            {
                Console.WriteLine($"G. Vi tri cuoi cung cua {x} trong mang la: {viTri}");
            }
            //h. Tìm số nguyên tố đầu tiên trong mảng
            int viTri1 = SoNguyenToDauTienTrongMang(Arr);
            if (viTri1 == -1)
            {
                Console.Write($"H. Khong ton tai {x} trong mang!");
            }
            else
            {
                Console.Write($"H. So nguyen to dau tien trong mang o vi tri thu: {viTri1}");
            }
            //i. Tìm phần tử lớn nhất trong mảng
            double soLonNhat = SoLonNhat(Arr);
            Console.WriteLine($"I. So lon nhat trong mang la: {soLonNhat}");
            //j. Tìm phần tử nhỏ nhất trong mảng
            SoNhoNhat(Arr);
            //k. Sap xep cac phan tu trong mang tang dan
            Console.Write("K. ");
            TangDan(Arr);
            //l.Kiem tra mang co thu tu tang dan hay khong?
            ThuTuTangDan(Arr);


        }
        //l.Kiem tra mang co thu tu tang dan hay khong?
        static void ThuTuTangDan(int[] intArr)
        {
            bool dieuKienDung = true; //neu cac phantu trong mang tang dan thi dung
            for (int i = 0; i <= intArr.Length - 1;i++)
            {
                if (intArr[i] > intArr[i] + 1)
                {
                    dieuKienDung = false;
                    break;
                }
            }
            Console.WriteLine();
            if (dieuKienDung)
            {
                Console.WriteLine("L. Cac phan tu trong mang co tang dan");
            }
            else
            {
                Console.WriteLine("L. Cac phan tu trong mang khong tang dan");
            }            
        }
        //k. Sap xep cac phan tu trong mang tang dan
        static void TangDan(int[] intArr)
        {
            Array.Sort(intArr);
            foreach(int i in intArr)
            {
                Console.Write(i + " ");
            }

        }
        //j. Tìm phần tử nhỏ nhất trong mảng
        static void SoNhoNhat(int[] intArr)
        {
            double min = intArr[0];
            foreach(int i in intArr)
            {
                if(min > i)
                {
                    min = i;
                }
            }
            Console.WriteLine($"J. Phan tu nho nhat trong mang la: {min}");
        }
        //i. Tìm phần tử lớn nhất trong mảng
        static double SoLonNhat(int[] intArr)
        {
            double soLonNhat = 0;
            foreach (int i in intArr)
            {
                if (i > soLonNhat)
                {
                    soLonNhat = i;
                }    
            }
            Console.WriteLine();
            return soLonNhat;
        }
        //h. Tìm số nguyên tố đầu tiên trong mảng
        static int SoNguyenToDauTienTrongMang(int[] intArr)
        {
            int viTri = 1;
            for (int i = 0;i < intArr.Length; i++)
            {
                if (KiemTraSoNguyenTo(intArr[i])==true)
                {
                    viTri = i;
                    break;
                }    
            }
            return viTri;
        }
        //g. Tìm vị trí cuối cùng của x trong mảng
        static int ViTriCuoiCungCuaX(int[] intArr, int x)
        {
            int viTri = -1;
            for (int i = intArr.Length -1; 1 >= 0; i--)
            {
                if (intArr[i] == x)
                {
                    viTri = i;
                    break;
                }    
            }
            return viTri;
        }
        //f.1. Kiểm tra số hoàn thiện
        static bool KiemTraSoHoanThien(int num)
        {
            int tong = 0;
            if (num <= 1) return false;
            for (int i = 1; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    tong += i;
                }    
            }
            return tong == num;
        }
        //f.2. Đếm số lượng số hoàn thiện có trong mảng
        static void DemSoHoanThien(int[] intArr)
        {
            int dem = 0;
            foreach (int i in intArr)
            {
                if (KiemTraSoHoanThien(i))
                {
                    dem++;
                }    
            }
            Console.WriteLine($"F. So luong so hoan thien co trong mang la: {dem}");
        }
        //e. Tính trung bình cộng các phần tử trong mảng
        static void TrungBinhCong(int[] intArr)
        {
            double tong = 0;
            foreach (int i in intArr)
            {                                  
                    tong += i;
            }
            double tongTrungBinh = tong / intArr.Length;
            Console.WriteLine($"E. Tong trung binh cong la: {tongTrungBinh}");            
        }
        //d1. Kiểm tra số nguyên tố
        static bool KiemTraSoNguyenTo(int num)
        {
            if(num < 2) return false; //Bé hơn 2 không phải là số nguyên tố
            for(int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }    
            return true;
        }
        //d2. Xuất mảng vừa nhập
        static void XuatSoNguyenToTrongMang(int[] intArr)
        {
            foreach (int i in intArr)
            {
                if (KiemTraSoNguyenTo(i))
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        //c. Xuất các số chẵn trong mảng
        static void XuatMangChan(int[] intArr)
        {
            foreach (int i in intArr)
            {
                if(i % 2 == 0)
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        //b. Xuất mảng vừa nhập
        static void XuatMangVuaNhap(int[] intArr)
        {
            foreach (int i in intArr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        //a. Nhập mảng số nguyên n phần tử
        static int[] MangSoNguyen(int num)
        {
            int[] intArr = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write($"[{i}]: ");
                int.TryParse(Console.ReadLine(), out intArr[i]);
            }   
            return intArr;
        }
        //Nhập một số nguyên dương từ 1 đến 100
        static int SoNguyenDuong(int num)
        {
            do
            {
                Console.Write("Nhap mot nguyen duong: ");
                int.TryParse(Console.ReadLine(), out num);
            }
            while (num < 1 && num > 100);
            return num;
        }
    }
}
