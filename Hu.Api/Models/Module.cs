using System;
using System.Collections.Generic;
using System.Linq;
using Hu.Shared.Dtos;
using SqlSugar;
namespace Hu.Api.Models
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("Module")]
    public class Module
    {
        /// <summary>
        /// 菜单id
        /// </summary>
        [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }


        /// <summary>
        /// 菜单页面名称
        /// </summary>
        [SugarColumn(ColumnName = "menu")]
        public string Menu { get; set; }


        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "icon")]
        public string Icon { get; set; }


        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "title")]
        public string Title { get; set; }


        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "path")]
        public string Path { get; set; }


        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "componentOne")]
        public string ComponentOne { get; set; }


        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "component")]
        public string Component { get; set; }


        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "fatherId")]
        public int FatherId { get; set; }


        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "sort")]
        public int? Sort { get; set; }


        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "powerMark")]
        public string PowerMark { get; set; }


        /// <summary>
        /// 用的是 Hu.Shared.Dtos.Meta，实用AutoMapper转换的时候方便一点
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public Meta meta { get; set; }

        /// <summary>
        /// 递归，找子集
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public List<Module> children { get; set; }
    }

    //public class Meta
    //{
    //    /// <summary>
    //    /// 此菜单的标题
    //    /// </summary>
    //    public string title { get; set; }


    //    /// <summary>
    //    /// 此菜单的图标
    //    /// </summary>
    //    public string icon { get; set; }

    //    /// <summary>
    //    /// 页面缓存
    //    /// </summary>
    //    public bool keepAlive { get; set; }
    //}
}
