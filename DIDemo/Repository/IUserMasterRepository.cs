﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemo.Repository
{
    public interface IUserMasterRepository
    {
        IEnumerable<UserMaster> GetAll();
        UserMaster Get(int id);
        UserMaster Add(UserMaster item);
        bool Update(UserMaster item);
        bool Delete(int id);
    }
}
