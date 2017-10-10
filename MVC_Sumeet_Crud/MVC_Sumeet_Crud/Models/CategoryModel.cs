using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Sumeet_Crud.Models
{
    public class CategoryModel
    {
        public Category Category { get; set; }
        public List<Status> Statuses { get; set; }
    }
}