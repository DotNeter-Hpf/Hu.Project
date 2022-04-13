using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Hu.Api.Models
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("OeeTerm")]
    public class OeeTerm
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
         [SugarColumn(ColumnName="ida"    )]
         public string Ida { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="status"    )]
         public string Status { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="andonState"    )]
         public string AndonState { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="rprtBarCode"    )]
         public string RprtBarCode { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="user"    )]
         public string User { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="time"    )]
         public string Time { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="endTime"    )]
         public string EndTime { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="production"    )]
         public string Production { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="source"    )]
         public string Source { get; set; }
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
         [SugarColumn(ColumnName="qualityRate"    )]
         public string QualityRate { get; set; }
        /// <summary>
        /// 工艺工时 
        ///</summary>
         [SugarColumn(ColumnName="processHour"    )]
         public string ProcessHour { get; set; }
    }
}
