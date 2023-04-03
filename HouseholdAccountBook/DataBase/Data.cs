using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseholdAccountBook.DataBase
{
    internal class Data
    {
        [Key]
        public int monthId { get; set; }
        [Required]
        public int categoryId { get; set; }
        [Required]
        public decimal pricePerMonth { get; set; }
    }
}
