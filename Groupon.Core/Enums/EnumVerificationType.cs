using System.ComponentModel;

namespace Groupon.Enums
{
    [Description("验证类型")]
    public enum EnumVerificationType
    {
        注册 = 0,
        找回密码 = 1,
        重新绑定手机号 = 2,
        绑定会员卡 = 3
    }
}
