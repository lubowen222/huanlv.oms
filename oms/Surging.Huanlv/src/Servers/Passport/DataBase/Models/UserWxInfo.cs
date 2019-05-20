using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBase.Models
{
    [Table("UserWxInfo")]
    public class UserWxInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        [DbIndex]
        public long UserId { get; set; }

        [MaxLength(100)]
        public string OpenId { get; set; }

        [MaxLength(100)]
        public string NickName { get; set; }

        [MaxLength(500)]
        public string HeadImage { get; set; }
    }
}
