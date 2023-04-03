using ABI.Windows.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseholdAccountBook.DataBase
{
    internal class Category
    {
        [Key]
        public int categoryId { get; set; }
        [Required]
        public string categoryName { get; set; }
        [Required]
        public int categoryColorId { get; set; }
    }
}
