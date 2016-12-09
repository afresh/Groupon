using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Groupon.Grp.Infos
{
    [Description("资讯")]
    public class Info : FullAuditedEntity<long>
    {
        [Description("分类代码")]
        [StringLength(4)]
        public virtual string InfoClassCode { get; set; }

        [Description("分类名称")]
        [StringLength(20)]
        public virtual string InfoClassName { get; set; }

        [Description("标题")]
        public virtual string Title { get; set; }

        [Description("作者")]
        [StringLength(20)]
        public virtual string Author { get; set; }

        [Description("主图")]
        public virtual string MainImage { get; set; }

        [Description("详情")]
        public virtual string Detail { get; set; }
    }
}
