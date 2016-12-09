using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Groupon.Enums;

namespace Groupon.Grp.RefundRecords
{
    [Description("退款记录")]
    public class RefundRecord : FullAuditedEntity<long>
    {
        [Description("退款数量")]
        public virtual int Number { get; set; }

        [Description("退款金额")]
        public virtual decimal Price { get; set; }

        [Description("退款方式")]
        public virtual EnumRefundWay Way { get; set; }

        [Description("退款状态")]
        public virtual EnumRefundState State { get; set; }

        [Description("退款原因")]
        public virtual string Reason { get; set; }

        [Description("会员Id")]
        public virtual long MemberId { get; set; }

        [Description("会员手机号")]
        [StringLength(20)]
        public virtual string MemberMobile { get; set; }

        [Description("套餐Id")]
        public virtual long PackageId { get; set; }

        [Description("套餐名称")]
        [StringLength(20)]
        public virtual string PackageName { get; set; }

        [Description("订单Id")]
        public virtual long OrderId { get; set; }

        [Description("订单号")]
        [StringLength(20)]
        public virtual string OrderNo { get; set; }

        [Description("审核人员Id")]
        public virtual long AuditingUserId { get; set; }

        [Description("审核人员工号")]
        [StringLength(20)]
        public virtual string AuditingUserNo { get; set; }

        [Description("审核人员姓名")]
        [StringLength(20)]
        public virtual string AuditingUserRealName { get; set; }
    }
}
