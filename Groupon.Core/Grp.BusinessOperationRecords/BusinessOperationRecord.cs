using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Groupon.Grp.BusinessOperationRecords
{
    [Description("商家操作记录")]
    public class BusinessOperationRecord : FullAuditedEntity<long>
    {
        [Description("商家Id")]
        public virtual long BusinessId { get; set; }

        [Description("商家手机号")]
        [StringLength(20)]
        public virtual string BusinessMobile { get; set; }

        [Description("商家名称")]
        [StringLength(20)]
        public virtual string BusinessName { get; set; }

        [Description("操作名称")]
        [StringLength(20)]
        public virtual string OperationName { get; set; }

        [Description("服务")]
        [StringLength(50)]
        public virtual string Service { get; set; }

        [Description("动作")]
        [StringLength(50)]
        public virtual string Action { get; set; }

        [Description("传入参数")]
        public virtual string InputParam { get; set; }

        [Description("传出数据")]
        public virtual string OutputData { get; set; }

        [Description("是否操作成功")]
        public virtual bool IsSuccessful { get; set; }
    }
}
