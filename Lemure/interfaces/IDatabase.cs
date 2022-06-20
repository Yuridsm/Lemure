using System;
using System.Collections.Generic;
using System.Text;

namespace lemure.interfaces
{
    interface IDatabase
    {
        public void insert();
        public void delete();
        public void select();
        public void update();

    }
}
