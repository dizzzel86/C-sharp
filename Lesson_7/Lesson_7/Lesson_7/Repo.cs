using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    //struct Repo
    //{
    //    public Worker[] Workers;

    //    public Repo(params Worker[] Args)
    //    {
    //        Workers = Args;
    //    }
    //}

    //struct Repo2
    //{
    //    private Worker[] Workers;

    //    public Worker[] this[int index]
    //    {
    //        get { return Workers[index]; }
    //        set { Workers[index] = value; }
    //    }

    //    public Repo2(params Worker[] Args)
    //    {
    //        Workers = Args;
    //    }

    //    public string Print()
    //    {
    //        return;

    //    }
    //}

    struct Repo3
    {
        private Worker[] Workers;

        public string this[int index]
        {
            get { return this.Workers[index].Print(); }

        }

        public Repo3(params Worker[] Args)
        {
            Workers = Args;
        }

    }
}
