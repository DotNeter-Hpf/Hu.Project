using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Hu.Api.Models
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("RestWork")]
    public class RestWork
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
         [SugarColumn(ColumnName="production"    )]
         public decimal? Production { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="time"    )]
         public string Time { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="partNo"    )]
         public string PartNo { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="serialNo"    )]
         public string SerialNo { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="status"    )]
         public string Status { get; set; }
    }
}
