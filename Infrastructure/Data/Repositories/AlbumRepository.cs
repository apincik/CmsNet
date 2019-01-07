﻿using Core.Entities;
using Core.Interfaces;
using Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class AlbumRepository : Repository<Album>, IAlbumRepository
    {
        public AlbumRepository(WebContext dbContext) : base(dbContext)
        {
        }

        public Task<List<Album>> ListAllByIdWithPhotos()
        {
            throw new NotImplementedException();
        }
    }
}
