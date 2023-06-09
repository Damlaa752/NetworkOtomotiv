using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkOtomotiv.Entity.Model.Entity
{
    public class Car : Entity
    {
        public Car():base()
        {
            
        }

        public Car(Brand brand, string seri, string model, string name, int year, string yakit, string? ımage, string color, string city, string vites, bool garanti, bool hasarKaydi, bool plaka, int km, decimal price,bool isHome, bool isActive):base(name)
        {
            Brand = brand;
            Seri  = seri;
            Model = model;
            Year = year;
            Yakit = yakit;
            Image = ımage;
            Color = color;
            City = city;
            Vites = vites;
            Garanti = garanti;
            HasarKaydi = hasarKaydi;
            Plaka = plaka;
            Km = km;
            Price = price;
            IsHome = isHome;
            IsActive = isActive;
        }
        public int BrandId { get; set; }
        public int BodyTypeId { get; set; }
        [Display(Name="Resim")]
        public string? Image { get; set; }
        public Brand? Brand { get; set; }
        public BodyType? BodyType { get; set; }
        public string Seri { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Yakit { get; set; }
        public string Vites { get; set; }
        public string Color { get; set; }
        public string City { get; set; }     
        public bool Garanti { get; set; }
        public bool HasarKaydi { get; set; }
        [Display(Name="Plaka/Uyruk")]
        public bool Plaka { get; set; }
        [Display(Name="Araç Km")]
        public int Km { get; set; }
        [Display(Name = "Fiyatı")]
        public decimal Price { get; set; }
        public bool IsHome { get; set; }
        public bool IsActive { get; set; }


    }
}
