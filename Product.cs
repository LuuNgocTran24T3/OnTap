using System;

namespace QuanLySanPham
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public Product(string id, string name, decimal price, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return $"ID: {Id,-8} | Tên: {Name,-25} | Giá: {Price,10:N0}đ | Loại: {Category}";
        }
    }
}