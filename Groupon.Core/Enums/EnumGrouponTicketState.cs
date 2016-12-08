using System.ComponentModel;

namespace Groupon.Enums
{
    [Description("团购券状态")]
    public enum EnumGrouponTicketState
    {
        待消费 = 0,
        已使用 = 1,
        退款中 = 2,
        已退款 = 3,
        已过期 = 4
    }
}
