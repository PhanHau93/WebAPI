using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGes
{
    using System;
    using System.Data.Entity;

    public sealed class ContextRepository
    {
        private static volatile Context instance;
        private static object syncRoot = new Object();

        private ContextRepository() { }

        public static Context Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Context();
                    }
                }

                return instance;
            }
        }
    }

}
