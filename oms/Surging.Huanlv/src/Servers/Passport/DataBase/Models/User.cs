using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBase.Models
{
    [Table("Users")]
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// 厂商Id
        /// </summary>
        public int OemId { get; set; }

        /// <summary>
        /// 注册手机号
        /// </summary>
        public string Cellphone { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegisterTime { get; set; }

        /// <summary>
        /// 用户状态
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 最后操作时间
        /// </summary>
        public DateTime ModifiedTime { get; set; }
    }
}
