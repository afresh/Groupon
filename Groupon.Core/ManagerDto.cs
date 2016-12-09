using System;
using System.ComponentModel;

namespace Groupon
{
    [Description("���������ݴ������")]
    [Serializable]
    public class ManagerDto<T>
    {
        public T Id { get; set; }
        public T CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public T LastModifierUserId { get; set; }
        public DateTime LastModificationTime { get; set; }
        public T DeleterUserId { get; set; }
        public DateTime DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}