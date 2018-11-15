﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using ImageProcessor.Web.Episerver.Business;

namespace ImageProcessor.Web.Episerver.Models.Blocks
{
    [ContentType(DisplayName = "Filter", GUID = "f6d77f0f-07b0-4495-9c56-57dadcbbc157", Description = "Applies a filter to the current image.", GroupName = Global.GroupName)]
    public class FilterBlock : ImageProcessorMethodBaseBlock
    {
        [EnumAttribute(typeof(Filter))]
        public virtual Filter Filter { get; set; }
    }
}