using Hu.Api.Models;
using Hu.Shared.Dtos;
using Hu.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hu.Api.Services.IServices
{
    public interface ILoginService : IBaseService<UserManage, UserManageDto>
    {
        Task<MessageModel> LoginAsync(string userName, string passWord);


        Task<MessageModel> GetMenuAsync();
        

    }
}
