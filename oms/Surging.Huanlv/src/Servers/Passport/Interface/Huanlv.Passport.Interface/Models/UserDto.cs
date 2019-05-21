using System;
using System.Collections.Generic;
using System.Text;

namespace Huanlv.Passport.Interface
{
    public class UserDto
    {
        public long Id { get; set; }
        
        public int OemId { get; set; }
        
        public string Cellphone { get; set; }
        
        public string Password { get; set; }
        
        public DateTime RegisterTime { get; set; }
        
        public int Status { get; set; }
    }
}
