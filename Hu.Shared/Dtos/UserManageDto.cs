using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hu.Shared.Dtos
{
    public class UserManageDto
    {
        /// <summary>
        ///  
        ///</summary>
        public int Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
        public string UserName { get; set; }
        /// <summary>
        ///  
        ///</summary>
        public string PassWord { get; set; }
        /// <summary>
        ///  
        ///</summary>
        public string IdCardNum { get; set; }
        /// <summary>
        ///  
        ///</summary>
        public string Address { get; set; }
        /// <summary>
        ///  
        ///</summary>
        public int? PowerId { get; set; }
        /// <summary>
        ///  
        ///</summary>
        public int? DepId { get; set; }
        /// <summary>
        ///  
        ///</summary>
        public int? RoleId { get; set; }
    }
}
