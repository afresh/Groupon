using System.ComponentModel;
using Abp.Domain.Entities.Auditing;
using Groupon.Enums;

namespace Groupon.Grp.Messages
{
    [Description("消息")]
    public class Message : FullAuditedEntity<long>
    {
        [Description("消息类型")]
        public virtual EnumMessageType MessageType { get; set; }

        [Description("标题")]
        public virtual string Title { get; set; }

        [Description("详情")]
        public virtual string Detail { get; set; }

        [Description("发送人员Id")]
        public virtual long SendUserId { get; set; }

        [Description("接收会员Ids")]
        public virtual string ReceiveMemberIds { get; set; }
    }
}
