﻿using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Cms.ViewModels.Articles
{
    public class ArticleUpdateViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public string Tags { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int? SeoId { get; set; }
        public Seo Seo { get; set; }

        public int? PhotoThumbnailId { get; set; }
        [Display(Name = "Thumbnail")]
        public IFormFile FileThumbnail { get; set; }
        [Display(Name = "Header")]
        public int? PhotoHeaderId { get; set; }
        public IFormFile FileHeader { get; set; }
        [Display(Name = "Images")]
        public List<IFormFile> Files { get; set; }

        [Display(Name = "Remote thumbnail")]
        public string RemoteFileThumbnail { get; set; }
        [Display(Name = "Remote header")]
        public string RemoteFileHeader { get; set; }
        [Display(Name = "Remote files [ ; ]")]
        public string RemoteFiles { get; set; }

        public Photo PhotoThumbnail { get; set; }
        public Photo PhotoHeader { get; set; }

        public int? AlbumId { get; set; }
        public Album Album { get; set; }

        public ArticleSettings ArticleSettings { get; set; }

        public List<Category> Categories { get; set; }

    }
}
