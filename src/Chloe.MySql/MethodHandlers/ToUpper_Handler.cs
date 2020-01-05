﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chloe.DbExpressions;

namespace Chloe.MySql.MethodHandlers
{
    class ToUpper_Handler : IMethodHandler
    {
        public bool CanProcess(DbMethodCallExpression exp)
        {
            if (exp.Method != PublicConstants.MethodInfo_String_ToUpper)
                return false;

            return true;
        }
        public void Process(DbMethodCallExpression exp, SqlGenerator generator)
        {
            generator.SqlBuilder.Append("UPPER(");
            exp.Object.Accept(generator);
            generator.SqlBuilder.Append(")");
        }
    }
}
