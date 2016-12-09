using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Groupon.Menus
{
    [Description("导航菜单权限")]
    public class MenuPermission : FullAuditedEntity<long>
    {
        [Description("导航菜单代码")]
        [StringLength(4)]
        public virtual string MenuCode { get; set; }

        [Description("用户Id")]
        public virtual long? UserId { get; set; }

        [Description("角色Id")]
        public virtual int? RoleId { get; set; }

        [Description("部门Id")]
        public virtual long? DepartmentId { get; set; }

        [Description("是否有效")]
        public virtual bool IsEnable { get; set; }
    }
}
