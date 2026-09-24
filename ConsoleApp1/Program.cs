using System;
using System.Collections.Generic;

class SinhVien
{
    public string HoTen { get; set; }
    public double Diem { get; set; }
}

class Program
{
    static void Main()
    {
        // 1. Nhập số lượng sinh viên
        int n;

        do
        {
            Console.Write("Nhap so luong sinh vien: ");
            n = int.Parse(Console.ReadLine());

            if (n <= 0)
                Console.WriteLine("So luong sinh vien phai > 0.");

        } while (n <= 0);

        List<SinhVien> danhSach = new List<SinhVien>();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nSinh vien thu {i + 1}:");

            Console.Write("Ho va ten: ");
            string hoTen = Console.ReadLine();

            Console.Write("Diem: ");
            double diem = double.Parse(Console.ReadLine());

            SinhVien sv = new SinhVien();

            sv.HoTen = hoTen;
            sv.Diem = diem;

            danhSach.Add(sv);
        }


        double tongDiem = 0;

        foreach (SinhVien sv in danhSach)
        {
            tongDiem += sv.Diem;
        }

        double diemTrungBinh = tongDiem / n;
        double diemMax = danhSach[0].Diem;

        foreach (SinhVien sv in danhSach)
        {
            if (sv.Diem > diemMax)
            {
                diemMax = sv.Diem;
            }
        }


        int soLuongDat = 0;

        foreach (SinhVien sv in danhSach)
        {
            if (sv.Diem >= 5.0)
            {
                soLuongDat++;
            }
        }
        Console.WriteLine("\n================ DANH SACH SINH VIEN ================");
        Console.WriteLine("{0,-5} {1,-30} {2,-10}", "STT", "Ho va ten", "Diem");
        Console.WriteLine("-----------------------------------------------------");

        for (int i = 0; i < danhSach.Count; i++)
        {
            Console.WriteLine(
                "{0,-5} {1,-30} {2,-10:F2}",
                i + 1,
                danhSach[i].HoTen,
                danhSach[i].Diem
            );
        }


        Console.WriteLine("\n================ THONG KE ================");
        Console.WriteLine($"Diem trung binh: {diemTrungBinh:F2}");
        Console.WriteLine($"Diem cao nhat: {diemMax:F2}");
        Console.WriteLine($"So sinh vien dat (>= 5.0): {soLuongDat}");
        Console.WriteLine("\nSinh vien co diem cao nhat:");

        foreach (SinhVien sv in danhSach)
        {
            if (sv.Diem == diemMax)
            {
                Console.WriteLine($"{sv.HoTen} - {sv.Diem:F2}");
            }
        }
    }
}