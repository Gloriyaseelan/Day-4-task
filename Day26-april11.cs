using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lynq
{
    class Day26_april11
    {
        public static void Main(string[] args)
        {
            IList<doctor> docdata = new List<doctor>()
            {
                new doctor(){doctorid=11,doctorname="Luca",age=27,degree="MBBS",emploid=1},
                new doctor(){doctorid=22,doctorname="Paul",age=22,degree="MBBS",emploid=2},
                new doctor(){doctorid=33,doctorname="Noah",age=24,degree="MBBS",emploid=3},
                new doctor(){doctorid=44,doctorname="John",age=26,degree="MBBS",emploid=4},

            };
            IList<specialist> spldata = new List<specialist>()
            {
                new specialist(){emploid=1,specialisation="dentist"},
                 new specialist(){emploid=2,specialisation="gynegologist"},
                  new specialist(){emploid=3,specialisation="pediatrician"},
                   new specialist(){emploid=4,specialisation="cardiologist"},

            };

            var joindata = docdata.Join(
                spldata,
                docd => docd.emploid,
                spld => spld.emploid,
                (docd, spld) => new
                {
                    doctorname = docd.doctorname,
                    specialisation = spld.specialisation
                }
                );
            foreach (var d in joindata)
                Console.WriteLine(d.doctorname + "    " + d.specialisation);

        }
    }

    internal class specialist
    {
         public int emploid { get; internal set; }
        public string specialisation { get; internal set; }
        
    }

    internal class doctor
    {
        public int doctorid { get; internal set; }
        public string doctorname { get; internal set; }
        public int age { get; internal set; }
        public string degree { get; internal set; }
        public int emploid { get; internal set; }
    }

}

