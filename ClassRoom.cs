using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupJoin
{
    public class ClassRoom
    {

        public int ClassId { get; set; }
        public string ClassName { get; set; }

        public ClassRoom(int classId,string className)
        {
            ClassId = classId;
            ClassName = className;
        }
    }
}
