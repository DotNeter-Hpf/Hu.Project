using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Hu.Api.Models
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("Part")]
    public class Part
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
        /// 零件号 
        ///</summary>
         [SugarColumn(ColumnName="partNo"    )]
         public string PartNo { get; set; }
        /// <summary>
        /// 零件序号 
        ///</summary>
         [SugarColumn(ColumnName="serialNo"    )]
         public string SerialNo { get; set; }
        /// <summary>
        /// 零件类型 
        ///</summary>
         [SugarColumn(ColumnName="type"    )]
         public string Type { get; set; }
        /// <summary>
        /// 型号 
        ///</summary>
         [SugarColumn(ColumnName="modelNumber"    )]
         public string ModelNumber { get; set; }
        /// <summary>
        /// 工艺工时 
        ///</summary>
         [SugarColumn(ColumnName="processHour"    )]
         public string ProcessHour { get; set; }
    }
}
