using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Groupon.Enums;

namespace Groupon.Members
{
    [Description("会员")]
    public class Member : FullAuditedEntity<long>
    {
        [Description("手机号")]
        [StringLength(20)]
        public string Mobile { get; set; }

        [Description("密码")]
        public string Password { get; set; }

        [Description("OpenId")]
        public string OpenId { get; set; }

        [Description("头像")]
        public string Face { get; set; }

        [Description("昵称")]
        [StringLength(8)]
        public string Nickname { get; set; }

        [Description("性别")]
        public int Sex { get; set; }

        [Description("生日")]
        public string Birthday { get; set; }

        [Description("成长值")]
        public int GrowthValue { get; set; }

        [Description("积分")]
        public int Point { get; set; }

        [Description("账号状态")]
        public EnumAccountState AccountState { get; set; }
    }
}
