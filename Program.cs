using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLySanPham
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("MSSV: 2415053122343");
            Console.WriteLine("Ten: Luu Ngoc Tran");
            Console.WriteLine("Lop: 24T3");
            Console.WriteLine();

            // Lấy danh sách sản phẩm
            List<Product> products = DataInitializer.GetSampleProducts();

            Console.WriteLine("=== DANH SÁCH TẤT CẢ SẢN PHẨM ===\n");
            foreach (var p in products)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine(new string('-', 70));

            // 1. Sản phẩm giá > 5 triệu
            Console.WriteLine("\n1. Sản phẩm có giá > 5.000.000đ:");
            var expensive = products.Where(p => p.Price > 5000000);
            foreach (var p in expensive)
            {
                Console.WriteLine(p);
            }

            // 2. Sắp xếp theo giá tăng dần
            Console.WriteLine("\n2. Danh sách sản phẩm sắp xếp theo giá tăng dần:");
            var sortedByPrice = products.OrderBy(p => p.Price);
            foreach (var p in sortedByPrice)
            {
                Console.WriteLine(p);
            }

            // 3. 3 sản phẩm rẻ nhất
            Console.WriteLine("\n3. 3 sản phẩm rẻ nhất:");
            var cheapest3 = products.OrderBy(p => p.Price).Take(3);
            foreach (var p in cheapest3)
            {
                Console.WriteLine(p);
            }

            // 4. Tìm kiếm theo tên
            Console.Write("\n4. Nhập từ khóa để tìm sản phẩm: ");
            string keyword = Console.ReadLine()?.Trim().ToLower() ?? "";

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var found = products
                    .Where(p => p.Name.ToLower().Contains(keyword))
                    .ToList();

                Console.WriteLine($"\nKết quả tìm kiếm chứa '{keyword}':");
                if (found.Any())
                {
                    foreach (var p in found)
                    {
                        Console.WriteLine(p);
                    }
                }
                else
                {
                    Console.WriteLine("→ Không tìm thấy sản phẩm nào phù hợp.");
                }
            }
            else
            {
                Console.WriteLine("→ Bạn chưa nhập từ khóa.");
            }

            Statistics.DisplayStatistics(products);

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}