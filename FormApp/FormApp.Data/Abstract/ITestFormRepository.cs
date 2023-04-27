﻿using FormApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp.Data.Abstract
{
    public interface ITestFormRepository : IGenericRepository<TestForm>
    {
        Task<TestForm> GetFormsWithFieldsById(int id);
    }
}
