﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blognet.Cms.Core.Interfaces
{
    public interface IApplicationUserManager
    {
        Task<List<IApplicationUser>> ListAll();
    }
}
