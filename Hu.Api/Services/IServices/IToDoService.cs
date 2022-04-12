using AutoMapper;
using Hu.Api.Models;
using Hu.Shared.Dtos;
using Hu.Shared.Models;
using Hu.Shared.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Hu.Api.Services.IServices
{
    public interface IToDoService : IBaseService<ToDo, ToDoDto>
    {
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        Task<MessageModel<PageModel<ToDoDto>>> QueryPageAsync(ToDoParameter query);

        Task<MessageModel> SummaryAsync();
    }
}
