using Hu.Api.Models;
using Hu.Shared.Dtos;
using Hu.Shared.Models;
using Hu.Shared.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hu.Api.Services.IServices
{
    public interface IMemoService : IBaseService<Memo,MemoDto>
    {
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        Task<MessageModel<PageModel<MemoDto>>> QueryPage(QueryParameter query);
    }
}
