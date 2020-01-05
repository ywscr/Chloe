﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chloe.DbExpressions;

namespace Chloe.SQLite.MethodHandlers
{
    class Max_Handler : IMethodHandler
    {
        public bool CanProcess(DbMethodCallExpression exp)
        {
            if (exp.Method.DeclaringType != PublicConstants.TypeOfSql)
                return false;

            return true;
        }
        public void Process(DbMethodCallExpression exp, SqlGenerator generator)
        {
            SqlGenerator.Aggregate_Max(generator, exp.Arguments.First(), exp.Method.ReturnType);
        }
    }
}
