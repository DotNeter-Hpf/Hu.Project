using Hu.Api.Controllers;
using Hu.Api.Services.IServices;
using Hu.Shared.Dtos;
using Hu.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hu.Api.Areas.System.Controllers
{
    /// <summary>
    /// 登录Controller
    /// </summary>
    [ApiController]
    [Route("api/System/[controller]/[action]")]
    public class LoginController : BaseApiController
    {
        private readonly ILoginService loginService;


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_loginService">具体业务处理</param>
        public LoginController(ILoginService _loginService)
        {
            this.loginService = _loginService;
        }


        /// <summary>
        /// 登录功能
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<MessageModel> Login(string userName, string passWord) => await loginService.LoginAsync(userName, passWord);


        /// <summary>
        /// 获取菜单上下级
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<MessageModel> Menu() => await loginService.GetMenuAsync();
    }
}
