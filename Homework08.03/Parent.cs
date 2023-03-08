using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework08._03
{
    public class Parent
    {
        //All access modifiers
        public int Public = 10;
        private int Private = 20;
        protected int Protected = 30;
        internal int Internal = 40;
        protected internal int ProtectedInternal = 50;

        public string name;
    }
    public class Child : Parent
    {
        public Child()
        {
            Public *= 10;
            //Private *= 10;
            Protected *= 10;
            Internal *= 10;
            ProtectedInternal *= 10;

            name = "bob";
        }
    }
}




