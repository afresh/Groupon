using System;
using System.ComponentModel;

namespace Groupon
{
    [Serializable]
    public class ResultDto
    {
        /// <summary>
        /// 代码
        /// 0：成功
        /// -1：未登录
        /// 1：失败
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 消息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public object Data { get; set; }
    }
}
