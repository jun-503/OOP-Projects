using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using week_06.BL;

namespace week_06.DL
{
    class DegreeProgramDL
    {
        public class DegreeProgramList
        {

            public static List<DegreeProgram> programlist = new List<DegreeProgram>();

            public static void addIntoDegreeList(DegreeProgram d)
            {
                programlist.Add(d);
            }
            public static DegreeProgram isDegreeExists(string degreeName)
            {
                foreach (DegreeProgram d in programlist)
                {
                    if (d.degreeName == degreeName)
                    {
                        return d;
                    }
                }
                return null;
            }
        }
    }
}
