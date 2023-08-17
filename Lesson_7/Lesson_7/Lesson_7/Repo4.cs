using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    struct Repo4
    {
        private Worker[] Workers;

        public string this[int index]
        {
            get { return this.Workers[index].Print(); }

        }

        public string this[string i]
        {
            get
            {
            switch(i)
                {
                    case "+": return "Плюс";
                    case "-": return "Минус";
                    case "*": return "Умножить";                   
                    default: return "Иное";
                        break;
                }
            }

        }

        public Repo4(params Worker[] Args)
        {
            Workers = Args;
        }


    }
}
