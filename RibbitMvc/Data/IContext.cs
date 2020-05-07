﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbitMvc.Data
{
    public interface IContext : IDisposable
    {
        IUserRepository Users { get; }
        IRibbitRepository Ribbits { get; }

        int SaveChanges();
    }
}
