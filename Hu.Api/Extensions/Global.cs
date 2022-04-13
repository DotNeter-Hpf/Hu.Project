using System;

namespace Hu.Api.Extensions
{
    /// <summary>
    /// 全局变量
    /// </summary>
    public class Global
    {
        /// <summary>
        /// 部署到Azure，服务器时间都是UTC，需要 .AddHours(8) 变成本地时间
        /// </summary>
        public static DateTime CurrentTime => DateTime.Now.AddHours(8);
    }
}
