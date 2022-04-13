using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Hu.Api.Models
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("Role")]
    public class Role
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public int Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="roleName"    )]
         public string RoleName { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="remark"    )]
         public string Remark { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="fatherId"    )]
         public int? FatherId { get; set; }
    }
}
