﻿using System.Collections.Generic;

namespace Cake.AzCli.Core.Models
{
    public class CliArgument
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public bool Required { get; set; }
        public bool InPreview { get; set; }
        public bool Experimental { get; set; }
        public List<string> AllowedValues { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
