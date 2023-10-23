using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS23_FIRST_MVC.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public string Description{ get; set; }
        public string ImageURL{ get; set; }
        public bool IsActive { get; set; }

        public ProductModel(int id, string description, bool isActive, double value, string imageUrl)
        {
            Id = id;
            Value = value;
            ImageURL = imageUrl;
            Description = description;
            IsActive = isActive;
        }
    }
}