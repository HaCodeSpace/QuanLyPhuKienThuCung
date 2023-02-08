﻿using DAL.Base;
using DAL.Data;
using DAL.IServices;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class TrangThaiService : EntityBaseRepository<TrangThai>, ITrangThaiService
    {
        public TrangThaiService(DbContexts contexts) : base(contexts)
        {
        }
    }
}
