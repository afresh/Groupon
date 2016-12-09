using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Groupon.Enums;

namespace Groupon.Grp.Members
{
    [Description("会员")]
    public class Member : FullAuditedEntity<long>
    {
        [Description("手机号")]
        [StringLength(20)]
        public virtual string Mobile { get; set; }

        [Description("密码")]
        public virtual string Password { get; set; }

        [Description("OpenId")]
        public virtual string OpenId { get; set; }

        [Description("头像")]
        public virtual string Face { get; set; }

        [Description("昵称")]
        [StringLength(8)]
        public virtual string Nickname { get; set; }

        [Description("性别")]
        public virtual int Sex { get; set; }

        [Description("生日")]
        public virtual string Birthday { get; set; }

        [Description("成长值")]
        public virtual int GrowthValue { get; set; }

        [Description("积分")]
        public virtual int Point { get; set; }

        [Description("账号状态")]
        public virtual EnumAccountState AccountState { get; set; }
    }
}
