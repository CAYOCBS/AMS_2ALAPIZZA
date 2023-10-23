using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS23_FIRST_MVC.Models
{
    public class CategoryModel
    {
         public int Id { get; set; }
        public string? Name{ get; set; }
        public bool IsActive { get; set; }

        public CategoryModel(int id, string name, bool isActive)
        {
            Id = id;
            Name = name;
            IsActive = isActive;
        }
    }
}