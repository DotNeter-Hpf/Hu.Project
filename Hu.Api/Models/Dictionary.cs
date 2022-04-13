using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Hu.Api.Models
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("Dictionary")]
    public class Dictionary
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public int Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="typeName"    )]
         public string TypeName { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="type"    )]
         public string Type { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="fatherId"    )]
         public string FatherId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="marke"    )]
         public string Marke { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="typeValue"    )]
         public string TypeValue { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="yl1"    )]
         public string Yl1 { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="yl2"    )]
         public string Yl2 { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="yl3"    )]
         public string Yl3 { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="status"    )]
         public string Status { get; set; }
    }
}
