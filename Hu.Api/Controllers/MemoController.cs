using Microsoft.AspNetCore.Mvc;
using Hu.Api.Models;
using Hu.Api.Services.IServices;
using Hu.Shared.Dtos;
using Hu.Shared.Models;
using Hu.Shared.Parameters;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Hu.Api.Controllers
{
    /// <summary>
    /// 备忘录控制器
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MemoController : BaseApiController
    {
        private readonly IMemoService imemoService;

        public MemoController(IMemoService _imemoService)
        {
            imemoService = _imemoService;
        }


        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<MessageModel> GetAll() => await imemoService.GetAllAsync();


        /// <summary>
        /// 查询单条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns>T</returns>
        [HttpGet]
        public async Task<MessageModel> GetSingle(int id) => await imemoService.GetSingleAsync(id);


        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<MessageModel<PageModel<MemoDto>>> QueryPage([FromQuery] QueryParameter query)
            => await imemoService.QueryPage(query);

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<MessageModel<Memo>> Add([FromBody] MemoDto model) => await imemoService.AddAsync(model);


        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<MessageModel> Update([FromBody] MemoDto model) => await imemoService.UpdateAsync(model);



        /// <summary>
        /// 根据ID删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<MessageModel> Delete(int id) => await imemoService.DeleteAsync(id);
    }
}
