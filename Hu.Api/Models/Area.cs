using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Hu.Api.Models
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("Area")]
    public class Area
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public int Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="areaName"    )]
         public string AreaName { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="fatherId"    )]
         public int? FatherId { get; set; }
        /// <summary>
        /// 储存最大的父级名称 
        ///</summary>
         [SugarColumn(ColumnName="maxLevel"    )]
         public string MaxLevel { get; set; }
    }
}
