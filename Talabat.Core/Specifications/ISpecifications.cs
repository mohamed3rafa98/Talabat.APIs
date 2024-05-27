﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Models;

namespace Talabat.Core.Specifications
{
    public interface ISpecifications<T> where T  : BaseModel
    {

        // From of Query

        public Expression<Func<T, bool>> Criteira { get; set; }

        public List<Expression<Func<T,object>>> Includes { get; set; }

        public Expression<Func<T, object>> OrderBy { get; set; }

        public Expression<Func<T, object>> OrderByDesc { get; set; }


        public int Skip { get; set; }
        public int Take { get; set; }

        public bool IsPagiantionEnalbed { get; set; }
    }
}