using AutoMapper;
using Hu.Api.Models;
using Hu.Api.Services.IServices;
using Hu.Shared.Dtos;
using Hu.Shared.Extensions;
using Hu.Shared.Models;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hu.Api.Services
{
    public class LoginService : BaseServices<UserManage, UserManageDto>, ILoginService
    {
        private readonly IMapper mapper;
        private readonly ISqlSugarClient db;

        public LoginService(IMapper _mapper, ISqlSugarClient _sqlSugarClient) : base(_mapper, _sqlSugarClient)
        {
            this.mapper = _mapper;
            db = _sqlSugarClient;
        }


        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public async Task<MessageModel> LoginAsync(string userName, string passWord)
        {
            try
            {
                var model = await db.Queryable<UserManage>().FirstAsync(it => it.UserName.Equals(userName) && it.PassWord.Equals(passWord.GetMD5()));
                if (model == null)
                    return MessageModel.Fail("账号或密码错误，请重试");
                return MessageModel.Success(model);
            }
            catch (Exception ex)
            {
                return MessageModel.Error(ex.Message);
            }
        }


        /// <summary>
        /// 获取菜单上下级
        /// </summary>
        /// <returns></returns>
        public async Task<MessageModel> GetMenuAsync()
        {
            //{
            //    List<Module> moduleList = new()
            //    {
            //        new Module() { Id = 1, Menu = "1", Path = "1" },
            //        new Module() { Id = 2, Menu = "2", Path = "2" },
            //        new Module() { Id = 3, Menu = "3", Path = "3" }
            //    };
            //    var test1 = mapper.Map<List<Module>, List<MenuDto>>(moduleList);
            //}

            //{
            //    List<MenuDto> menuList = new()
            //    {
            //        new MenuDto() { mid = 4, name = "4", path = "4" },
            //        new MenuDto() { mid = 5, name = "5", path = "5" },
            //        new MenuDto() { mid = 6, name = "6", path = "6" }
            //    };

            //    var test2 = mapper.Map<List<Module>>(menuList);
            //}

            try
            {
                List<Module> tree = await db.Queryable<Module>().ToTreeAsync(it => it.children, it => it.FatherId, 0);
                foreach (var item in tree)
                {
                    item.meta = new Meta
                    {
                        title = item.Menu,
                        icon = item.Icon,
                        keepAlive = false
                    };
                    //判断子集
                    if (item.children != null)
                    {
                        foreach (var child in item.children)
                        {
                            child.meta = new Meta
                            {
                                title = child.Menu,
                                icon = child.Icon
                            };
                        }
                    }
                }

                if (tree == null)
                    return MessageModel.Fail("没有对应的数据");

                List<MenuDto> listDto = mapper.Map<List<MenuDto>>(tree);
                return MessageModel.Success(listDto);
            }
            catch (Exception ex)
            {
                return MessageModel.Error(ex.Message);
            }
        }

    }
}
