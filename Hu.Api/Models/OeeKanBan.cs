using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Hu.Api.Models
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("OeeKanBan")]
    public class OeeKanBan
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public int Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="area"    )]
         public string Area { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="daBiaoCount"    )]
         public string DaBiaoCount { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="count"    )]
         public string Count { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="daBiaoBaiFenBi"    )]
         public string DaBiaoBaiFenBi { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="time"    )]
         public string Time { get; set; }
        /// <summary>
        /// 0代表总的，1代表每个设备 
        ///</summary>
         [SugarColumn(ColumnName="type"    )]
         public int? Type { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="factory"    )]
         public string Factory { get; set; }
    }
}
