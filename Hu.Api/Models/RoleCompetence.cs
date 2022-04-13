using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Hu.Api.Models
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("RoleCompetence")]
    public class RoleCompetence
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public int Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="roleId"    )]
         public int? RoleId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="moduleId"    )]
         public int? ModuleId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="competenceId"    )]
         public string CompetenceId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="remark"    )]
         public string Remark { get; set; }
    }
}
