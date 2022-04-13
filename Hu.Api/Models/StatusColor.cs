using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Hu.Api.Models
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("StatusColor")]
    public class StatusColor
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public int Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="statusName"    )]
         public string StatusName { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="statusValue"    )]
         public string StatusValue { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="color"    )]
         public string Color { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="isVisable"    )]
         public int? IsVisable { get; set; }
    }
}
