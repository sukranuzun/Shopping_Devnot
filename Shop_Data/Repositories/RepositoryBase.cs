using Shop_Data.Abstract;
using Shop_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> 
        where T : class, IEntity
    {
    }
}
