using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Hu.Api.Models
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("Device")]
    public class Device
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
         [SugarColumn(ColumnName="oeeID"    )]
         public string OeeID { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="andonID"    )]
         public string AndonID { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="iotID"    )]
         public string IotID { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="rprtID"    )]
         public string RprtID { get; set; }
    }
}
