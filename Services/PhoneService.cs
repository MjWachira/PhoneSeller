using System.Collections.Generic;
using PhoneSeller.Models;

namespace PhoneSeller.Services
{
    public class PhoneService
    {
        public List<Phone> GetPhones()
        {
            return new List<Phone>
            {
                new Phone { Id = 1, Name = "iPhone 15", Brand = "Apple", Price = 999.99m },
                new Phone { Id = 2, Name = "Galaxy S23", Brand = "Samsung", Price = 899.99m },
                new Phone { Id = 3, Name = "Pixel 8", Brand = "Google", Price = 799.99m }
            };
        }
    }
}