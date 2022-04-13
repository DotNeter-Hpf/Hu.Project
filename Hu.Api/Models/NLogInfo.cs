using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Hu.Api.Models
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("NLogInfo")]
    public class NLogInfo
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="LogId"  ,IsIdentity = true  )]
         public int LogId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Date"    )]
         public DateTime Date { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Origin"    )]
         public string Origin { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Level"    )]
         public string Level { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Message"    )]
         public string Message { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Detail"    )]
         public string Detail { get; set; }
    }
}
