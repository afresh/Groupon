using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Groupon.Enums;

namespace Groupon.Grp.BusinessBills
{
    [Description("商家账单")]
    public class BusinessBill : FullAuditedEntity<long>
    {
        [Description("商家Id")]
        public virtual long BusinessId { get; set; }

        [Description("商家手机号")]
        [StringLength(20)]
        public virtual string BusinessMobile { get; set; }

        [Description("商家名称")]
        [StringLength(20)]
        public virtual string BusinessName { get; set; }

        [Description("商家账单操作")]
        public virtual EnumBillOperation BillOperation { get; set; }

        [Description("金额")]
        public virtual decimal Price { get; set; }

        [Description("操作人员Id")]
        public virtual long OperationUserId { get; set; }

        [Description("操作人员工号")]
        [StringLength(20)]
        public virtual string OperationUserNo { get; set; }
    }
}
