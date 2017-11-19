using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integration.Domain.Entities.Models
{
    public class UserViewModel
    {
        [Key]
        public string UserID { get; set; }
        public string AccessKey { get; set; }
    }

    public class TokenConfigurations
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }
    }
}
