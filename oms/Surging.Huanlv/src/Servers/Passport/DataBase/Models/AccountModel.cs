using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBase.Models
{
    [Table("account")]
    public class AccountModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        [DbIndex]
        public int OemId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [MaxLength(20)]
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [MaxLength(100)]
        public string Password { get; set; }

        /// <summary>
        /// 账号是否可用
        /// </summary>
        public bool IsDisable { get; set; }

        /// <summary>
        /// 第一次登入时间
        /// </summary>
        public DateTime FirstLogonTime { get; set; }

        /// <summary>
        /// 最后一次登入时间
        /// </summary>
        public DateTime LastLogonTime { get; set; }

        /// <summary>
        /// 登入错误次数
        /// </summary>
        public int LogonErrorNum { get; set; }

        /// <summary>
        /// 登入错误信息
        /// </summary>
        [MaxLength(100)]
        public string LogonError { get; set; }
    }
}
