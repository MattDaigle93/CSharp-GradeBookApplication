﻿using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public new GradeBookType Type { get; set; }
        public StandardGradeBook(string name) : base(name)
        {
              
        }
    }
}
