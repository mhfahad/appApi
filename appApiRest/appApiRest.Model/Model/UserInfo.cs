using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appApiRest.Model.Model
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string userId { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string usermail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [EmailAddress]
        public string userPass { get; set; }

    }
}
