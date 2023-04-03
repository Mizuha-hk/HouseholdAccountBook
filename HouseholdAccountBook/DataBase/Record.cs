using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseholdAccountBook.DataBase
{
    internal class Record
    {
        [Key]
        public int recordId {  get; set; }
        [Required]
        public decimal price { get; set; }
        [Required]
        public DateTime recordDate { get; set; }
        [Required]
        public int categoryId { get; set; }
        public string comment { get; set; }
    }
}
