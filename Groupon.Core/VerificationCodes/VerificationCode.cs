using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Groupon.Enums;

namespace Groupon.VerificationCodes
{
    [Description("验证码")]
    public class VerificationCode : FullAuditedEntity<long>
    {
        [Description("手机号")]
        [StringLength(20)]
        public virtual string Mobile { get; set; }

        [Description("验证码")]
        [StringLength(6)]
        public virtual string Code { get; set; }

        [Description("验证状态")]
        public virtual EnumVerificationState State { get; set; }

        [Description("验证类型")]
        public virtual EnumVerificationType Type { get; set; }
    }
}
