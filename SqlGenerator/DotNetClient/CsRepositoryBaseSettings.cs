﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlGenerator.DotNetClient
{
    public class CsRepositoryBaseSettings : CsCodeGeneratorSettings
    {
        public string ConnectionStringName { get; set; } = "Default";
    }
}
