using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Hu.Api.Models
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("ReturnOee")]
    public class ReturnOee
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public int Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="devID"    )]
         public string DevID { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="status"    )]
         public string Status { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="time"    )]
         public string Time { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="source"    )]
         public string Source { get; set; }
    }
}
