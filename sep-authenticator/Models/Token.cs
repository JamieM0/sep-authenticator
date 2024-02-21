using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep_authenticator.Models
{
    public class Token
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public Token()
        {
            Id = 0;
            Name = "";
            Secret = "";
            Issuer = "";
            CreatedOn = DateTime.Now;
            UpdatedOn = DateTime.Now;
        }

        public Token(int id, string name, string secret, string issuer, DateTime createdOn, DateTime updatedOn)
        {
            Id = id;
            Name = name;
            Secret = secret;
            Issuer = issuer;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
        }
        public Token(string name, string secret, string issuer, DateTime createdOn, DateTime updatedOn)
        {
            Name = name;
            Secret = secret;
            Issuer = issuer;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
        }
    }
}
