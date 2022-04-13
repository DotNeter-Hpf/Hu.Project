using System;
using System.Collections.Generic;
using System.Linq;
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
        ///  
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public int Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="menu"    )]
         public string Menu { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="icon"    )]
         public string Icon { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="title"    )]
         public string Title { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="path"    )]
         public string Path { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="componentOne"    )]
         public string ComponentOne { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="component"    )]
         public string Component { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="fatherId"    )]
         public int FatherId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="sort"    )]
         public int? Sort { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="powerMark"    )]
         public string PowerMark { get; set; }
    }
}
