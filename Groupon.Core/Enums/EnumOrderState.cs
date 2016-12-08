using System.ComponentModel;

namespace Groupon.Enums
{
    [Description("订单状态")]
    public enum EnumOrderState
    {
        待付款 = 0,
        待使用 = 1,
        待评价 = 2,
        已完成 = 3,
        退款中 = 4,
        已退款 = 5
    }
}
