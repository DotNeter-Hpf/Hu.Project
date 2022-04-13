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
        /// 注册
        /// </summary>
        /// <param name="userDto"></param>
        /// <returns></returns>
        //public async Task<MessageModel> RegisterAsync(UserDto userDto)
        //{
        //    try
        //    {
        //        //数据传输层和数据库实体层之间的一个映射转换
        //        var tModel = mapper.Map<User>(userDto);
        //        var model = await db.Queryable<User>().FirstAsync(it => it.Account.Equals(tModel.Account));
        //        if (model != null)
        //            return MessageModel.Fail($"注册账号：{model.Account}已存在，请重新注册！");

        //        tModel.CreateDate = db.GetDate();
        //        tModel.PassWord = tModel.PassWord.GetMD5();

        //        int row = await db.Insertable(tModel).ExecuteCommandAsync();
        //        if (row > 0)
        //            return MessageModel.Success(tModel);
        //        return MessageModel.Fail("注册失败，请稍后重试");
        //    }
        //    catch (Exception ex)
        //    {
        //        return MessageModel.Error("注册账号失败:" + ex.Message);
        //    }
        //}


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
                    return MessageModel.Fail("账号或密码错误，请重试！");
                return MessageModel.Success(model);
            }
            catch (Exception ex)
            {
                return MessageModel.Error(ex.Message);
            }
        }
    }
}
