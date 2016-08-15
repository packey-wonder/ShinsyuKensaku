using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ShinsyuKensaku.Models
{
    public class Book
    {
        [Key]
        public int id { get; set; }
        public int seq { get; set; }
        public string title { get; set; }
        public string heading { get; set; }
        public string body { get; set; }
        public string link { get; set; }
        public int division { get; set; }

    }


}