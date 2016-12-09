using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Groupon.Grp.PackageEvaluations
{
    [Description("套餐评价")]
    public class PackageEvaluation : FullAuditedEntity<long>
    {
        [Description("评价分数")]
        public virtual decimal Score { get; set; }

        [Description("评价详情")]
        public virtual string Detail { get; set; }

        [Description("会员Id")]
        public virtual long MemberId { get; set; }

        [Description("会员手机号")]
        [StringLength(20)]
        public virtual string MemberMobile { get; set; }

        [Description("会员昵称")]
        [StringLength(8)]
        public virtual string MemberNickname { get; set; }

        [Description("会员头像")]
        public virtual string MemberFace { get; set; }

        [Description("是否匿名")]
        public virtual bool IsAnonymous { get; set; }

        [Description("是否系统评价")]
        public virtual bool IsSystemEvalu { get; set; }

        [Description("套餐Id")]
        public virtual long PackageId { get; set; }

        [Description("套餐名称")]
        [StringLength(20)]
        public virtual string PackageName { get; set; }

        [Description("套餐团购价")]
        public virtual decimal PackageGrouponPrice { get; set; }

        [Description("商家地址")]
        public virtual string BusinessAddress { get; set; }

        [Description("订单Id")]
        public virtual long OrderId { get; set; }

        [Description("订单号")]
        [StringLength(20)]
        public virtual string OrderNo { get; set; }

        [Description("下单时间")]
        public virtual DateTime OrderTime { get; set; }
    }
}
