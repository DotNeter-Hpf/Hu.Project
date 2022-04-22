using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hu.Shared.Dtos
{
    public class MenuDto
    {
        /// <summary>
        /// 菜单id
        /// </summary>
        public int mid { get; set; }

        /// <summary>
        /// 菜单页面跳转地址
        /// </summary>
        public string path { get; set; }


        /// <summary>
        /// 菜单页面名称
        /// </summary>
        public string name { get; set; }


        /// <summary>
        /// 菜单页面跳转地址
        /// </summary>
        public string component { get; set; }


        /// <summary>
        /// 权限标识 菜单:true；功能:false
        /// </summary>
        public string powerMark { get; set; }

        /// <summary>
        /// 存子集菜单的信息
        /// </summary>
        public Meta meta { get; set; }


        /// <summary>
        /// 存子集菜单的信息
        /// </summary>
        public List<MenuDto> children { get; set; }
    }

    public class Meta
    {
        /// <summary>
        /// 此菜单的标题
        /// </summary>
        public string title { get; set; }


        /// <summary>
        /// 此菜单的图标
        /// </summary>
        public string icon { get; set; }

        /// <summary>
        /// 页面缓存
        /// </summary>
        public bool keepAlive { get; set; }
    }
}
