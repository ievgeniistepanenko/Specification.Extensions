﻿using Specification.Interfaces;
using System.Linq;

namespace Specification.Extensions
{
    public static class QueryableExtension
    {
        public static IQueryable<T> Where<T>(this IQueryable<T> source, ISpecification<T> spec)
        {
            return source.Where(spec.ToExpression());
        }
    }

}