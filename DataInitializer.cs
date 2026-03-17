using System;
using System.Collections.Generic;

namespace QuanLySanPham
{
    public static class DataInitializer
    {
        public static List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product("SP001", "Bàn phím cơ Keychron K8", 2350000, "Bàn phím"),
                new Product("SP002", "Chuột Logitech G Pro X Superlight", 3690000, "Chuột"),
                new Product("SP003", "Tai nghe Sony WH-1000XM5", 8490000, "Tai nghe"),
                new Product("SP004", "Màn hình LG UltraGear 27GP850", 6990000, "Màn hình"),
                new Product("SP005", "Laptop ASUS ROG Zephyrus G14", 32900000, "Laptop"),
                new Product("SP006", "Ổ cứng SSD Samsung 970 EVO Plus 1TB", 2450000, "Lưu trữ")
            };
        }
    }
}