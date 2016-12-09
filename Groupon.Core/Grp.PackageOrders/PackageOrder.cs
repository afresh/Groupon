using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Groupon.Enums;

namespace Groupon.Grp.PackageOrders
{
    [Description("套餐订单")]
    public class PackageOrder : FullAuditedEntity<long>
    {
        [Description("订单号")]
        [StringLength(20)]
        public virtual string No { get; set; }

        [Description("订单状态")]
        public virtual EnumOrderState OrderState { get; set; }

        [Description("付款时间")]
        public virtual DateTime PayTime { get; set; }

        [Description("数量")]
        public virtual int Number { get; set; }

        [Description("总价")]
        public virtual decimal TotalPrice { get; set; }

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

        [Description("套餐团购价")]
        public virtual decimal PackageGrouponPrice { get; set; }

        [Description("套餐门市价")]
        public virtual decimal PackageRetailPrice { get; set; }

        [Description("套餐简介")]
        public virtual string PackageIntroduction { get; set; }

        [Description("商家Id")]
        public virtual long BusinessId { get; set; }

        [Description("商家名称")]
        [StringLength(20)]
        public virtual string BusinessName { get; set; }

        [Description("商家地址")]
        public virtual string BusinessAddress { get; set; }

        [Description("商家电话")]
        [StringLength(20)]
        public virtual string BusinessTelephone { get; set; }
    }
}
