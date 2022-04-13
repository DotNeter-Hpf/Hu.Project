using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Hu.Api.Models
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("UserManage")]
    public class UserManage
    {
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "userName")]
        public string UserName { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "passWord")]
        public string PassWord { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "idCardNum")]
        public string IdCardNum { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "address")]
        public string Address { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "powerId")]
        public int? PowerId { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "depId")]
        public int? DepId { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "roleId")]
        public int? RoleId { get; set; }
    }
}
