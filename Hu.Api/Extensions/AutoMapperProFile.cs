using AutoMapper;
using Hu.Api.Models;
using Hu.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hu.Api.Extensions
{
    public class AutoMapperProFile : Profile
    {
        /// <summary>
        /// 构造函数实现映射
        /// </summary>
        public AutoMapperProFile()
        {
            //相互之间转换
            //CreateMap<ToDo, ToDoDto>().ReverseMap();
            //Dto中FirstName+LastName = 实体类中的Name
            //.ForMember(d=>d.Name,o=>o.MapFrom(o=>o.FirstName+o.LastName))
            //字段名字不同
            //.ForMember(d=>d.Id,o=>o.MapFrom(o=>o.Id))
            //不映射某个字段
            //.ForMember(d=>d.Id,o=>o.Ignore());
            //CreateMap<Memo, MemoDto>().ReverseMap();
            //CreateMap<User, UserDto>().ReverseMap();


            //CreateMap<Module, MenuDto>().ReverseMap()   
            //    字段名字不同
            //    .ForMember(f => f.Id, t => t.MapFrom(t => t.mid))
            //    .ForMember(f => f.Menu, t => t.MapFrom(t => t.name))
            //    .ForMember(f => f.Path, t => t.MapFrom(t => t.path));
            //    //不映射某个字段
            //    .ForMember(f => f.Icon, t => t.Ignore())
            //    .ForMember(f => f.Title, t => t.Ignore())
            //    .ForMember(f => f.ComponentOne, t => t.Ignore())
            //    .ForMember(f => f.Sort, t => t.Ignore())
            //    .ForMember(f => f.FatherId, t => t.Ignore());


            CreateMap<MenuDto, Module>().ReverseMap()
                 //字段名字不同
                 .ForMember(f => f.mid, t => t.MapFrom(t => t.Id))
                .ForMember(f => f.name, t => t.MapFrom(t => t.Menu))
                .ForMember(f => f.path, t => t.MapFrom(t => t.Path));

        }
    }
}
