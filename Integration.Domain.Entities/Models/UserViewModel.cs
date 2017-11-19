using System;
using System.Collections.Generic;
using System.Text;

namespace Integration.Domain.Entities.Models
{
    public class UserViewModel
    {
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
