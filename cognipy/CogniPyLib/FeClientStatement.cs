﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentEditorClientLib
{
    public enum StatementType { Concept, Rule, Role, Instance, Annotation, Constraint }

    public class FeClientStatement
    {
        public string CnlStatement { get; set; }
        
        public HashSet<string> Concepts { get; set; }
        
        public HashSet<string> Instances { get; set; }
        
        public HashSet<string> Roles { get; set; }
        
        public HashSet<string> DataRoles { get; set; }
        
        public StatementType Type { get; set; }
    }
}
