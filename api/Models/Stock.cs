using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema; // Thêm vào để sử dụng attribute Column


namespace api.Models {
    [Table("Stocks")]
    public class Stock {
        public int Id {get; set;}
        public string Symbol {get; set;} = string.Empty;
        public string CompanyName {get; set;} = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase {get; set;}
        [Column(TypeName = "decimal(18,2)")]
        public decimal LastDiv {get; set;}
        public string Industry {get; set;} = string.Empty;
        public long MrketCap {get; set;}
        public List<Comment> Comment {get; set;} = new List<Comment>();
        public List<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
    }
}


