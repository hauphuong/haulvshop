﻿using AutoMapper;
using HaulvShop.Model.Models;
using HaulvShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaulvShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
            Mapper.CreateMap<PostTag, PostTagViewModel>();
        }
    }
}