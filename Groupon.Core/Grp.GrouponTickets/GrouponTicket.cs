using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Groupon.Enums;

namespace Groupon.Grp.GrouponTickets
{
    [Description("团购券")]
    public class GrouponTicket : FullAuditedEntity<long>
    {
        [Description("券码")]
        [StringLength(32)]
        public virtual string TicketCode { get; set; }

        [Description("截止日期")]
        public virtual DateTime ClosingDate { get; set; }

        [Description("状态")]
        public virtual EnumGrouponTicketState State { get; set; }

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

        [Description("套餐Logo")]
        public virtual string PackageLogo { get; set; }

        [Description("套餐团购价")]
        public virtual decimal PackageGrouponPrice { get; set; }

        [Description("订单Id")]
        public virtual long OrderId { get; set; }

        [Description("订单号")]
        [StringLength(20)]
        public virtual string OrderNo { get; set; }

        [Description("核销时间")]
        public virtual DateTime VerificationTime { get; set; }
    }
}
