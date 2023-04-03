using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseholdAccountBook.DataBase
{
    internal class Goal
    {
        [Key]
        public int categoryId { get; set; }
        public decimal goalPrice { get; set; }
    }
}
