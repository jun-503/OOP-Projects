﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using week_06.BL;

namespace week_06.DL
{
    class SubjectList
    {
        static List<SubjectList> subjects = new List<SubjectList>();

        public static void setSubjectIntoList(SubjectList s)
        {
            subjects.Add(s);
        }


    }
}
