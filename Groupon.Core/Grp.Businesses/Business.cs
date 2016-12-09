using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Groupon.Enums;

namespace Groupon.Grp.Businesses
{
    [Description("商家")]
    public class Business : FullAuditedEntity<long>
    {
        [Description("手机号")]
        [StringLength(20)]
        public virtual string Mobile { get; set; }

        [Description("密码")]
        public virtual string Password { get; set; }

        [Description("申请人姓名")]
        [StringLength(20)]
        public virtual string ApplicantName { get; set; }

        [Description("Logo")]
        public virtual string Logo { get; set; }

        [Description("名称")]
        [StringLength(20)]
        public virtual string Name { get; set; }

        [Description("地标")]
        public virtual string Landmark { get; set; }

        [Description("地址")]
        public virtual string Address { get; set; }

        [Description("电话")]
        [StringLength(20)]
        public virtual string Telephone { get; set; }

        [Description("代码")]
        public virtual string BusinessScopeCode { get; set; }

        [Description("经营范围")]
        public virtual string BusinessScope { get; set; }

        [Description("联系人姓名")]
        [StringLength(20)]
        public virtual string ContactName { get; set; }

        [Description("联系人电话")]
        [StringLength(20)]
        public virtual string ContactMobile { get; set; }

        [Description("账号状态")]
        public virtual EnumAccountState AccountState { get; set; }
    }
}
