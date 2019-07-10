using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBase.Models
{
    [Table("userinfo")]
    public class UserInfoModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        public int OemId { get; set; }

        public long AccountId { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [MaxLength(20)]
        public string NickName { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [MaxLength(20)]
        public string RealName { get; set; }

        /// <summary>
        /// 头像地址
        /// </summary>
        [MaxLength(255)]
        public string HeadImg { get; set; }

        /// <summary>
        /// 邮件地址
        /// </summary>
        [MaxLength(50)]
        public string Mail { get; set; }

        [MaxLength(50)]
        public string Phone { get; set; }

        [MaxLength(50)]
        public string QQ { get; set; }

        [MaxLength(50)]
        public string Weixin { get; set; }

        [MaxLength(100)]
        public string Wid { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [MaxLength(20)]
        public string Province { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [MaxLength(20)]
        public string City { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [MaxLength(20)]
        public string Region { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        public bool IsFakePhone { get; set; }

        /// <summary>
        /// 用户来源
        /// </summary>
        public int Source { get; set; }
    }
}
