﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CodeFrame.Models.DbModel;
using CodeFrame.Web.Areas.Manage.Models;

namespace CodeFrame.Web
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<UserInfo,UserInfoModel>();
            CreateMap<UserInfoModel, UserInfo>();
        }
    }
}
