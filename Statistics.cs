using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLySanPham
{
    public static class Statistics
    {
        public static void DisplayStatistics(List<Product> products)
        {
            if (products == null || !products.Any())
            {
                Console.WriteLine("Danh sách sản phẩm rỗng, không thể thống kê.");
                return;
            }

            Console.WriteLine("\n=== THỐNG KÊ SẢN PHẨM ===");
            Console.WriteLine($"Tổng số sản phẩm     : {products.Count,5}");

            decimal totalValue = products.Sum(p => p.Price);
            Console.WriteLine($"Tổng giá trị sản phẩm: {totalValue:N0} đ");

            decimal averagePrice = products.Average(p => p.Price);
            Console.WriteLine($"Giá trung bình       : {averagePrice:N0} đ");
        }
    }
}