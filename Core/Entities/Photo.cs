﻿using Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Text;

namespace Core.Entities
{
    [Table("cms_photo")]
    public class Photo : BaseEntity
    {
        public int AlbumId { get; set; }
        public Album Album { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        [Required]
        [MaxLength(120)]
        public string NameNormalized { get; set; }

        [Required]
        [MaxLength(10)]
        public string Extension { get; set; }

        [Required]
        [MaxLength(64)]
        public string Hash { get; set; }

        [Required]
        public int Width { get; set; }

        [Required]
        public int Height { get; set; }

        [MaxLength(10)]
        public string Protocol { get; set; }

        [MaxLength(255)]
        public string DomainName { get; set; }

        [Required]
        [MaxLength(255)]
        public string RelativePath { get; set; }

        [MaxLength(255)]
        public string CdnPath { get; set; }

        [MaxLength(255)]
        public string OriginSource { get; set; }

        [Required]
        public Status Status { get; set; }

        [Required]
        public PhotoType Type { get; set; }

        [Required]
        public bool IsLocal { get; set; }


        public string GetImagePath()
        {
            if(IsLocal)
            {
                return Path.Combine($"/{RelativePath}", AlbumId.ToString(), $"{Hash}.{Extension}");
            } 
            else
            {
                return Path.Combine($"{Protocol}://{DomainName}/", RelativePath, AlbumId.ToString(), $"{Hash}.{Extension}");
            }
        }
    }
}