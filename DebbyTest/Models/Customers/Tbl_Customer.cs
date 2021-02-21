using System;
using System.ComponentModel.DataAnnotations;

namespace DebbyTest.Models.Customers
{
    public class Tbl_Customer
    {
        public Tbl_Customer()
        {
            
        }
        [Key]
        public int customerid { get; set; }
        public string fullname { get; set; }
        public DateTime? createdDate { get; set; }
        public DateTime? modifiedDate { get; set; }
    }
}
