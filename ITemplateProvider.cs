﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandebarsDotNetCore
{
    public interface ITemplateProvider
    {
        HandlebarsDotNet.IHandlebars GetEnvironment();

        Func<object, string> GetTemplate(string key);
        Func<object, string> GetLayoutTemplate(string key);
    }
}
