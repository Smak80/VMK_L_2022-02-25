﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMK_L_2022_02_25
{
    public struct MyStruct
    {
        public int a;
        public double x;

        public MyStruct(int v1, double v2) : this()
        {
            a = v1;
            x = v2;
        }

        public override string ToString()
        {
            return $"a={a}; x={x}";
        }
    }
    public class MyClass
    {
        private DateTime dt;

        public int Year
        {
            get => dt.Year;
            set => dt = dt.AddYears(value - dt.Year);
        }
        private List<MyStruct> l = new ();
        public List<MyStruct> MyList => new (l);
        public void Add(MyStruct s) => l.Add(s);
        public void Add(MyStruct[] s) => l.AddRange(s);
        public void Remove(int a)
        {
            for (int i = 0; i < MyList.Count; i++)
            {
                if (l[i].a == a)
                {
                    l.RemoveAt(i);
                    i--;
                }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (MyList.Count > 0)
            {
                foreach (var myStruct in MyList)
                {
                    sb.Append($"{myStruct}\n");
                }
            }
            else
            {
                sb.Append("Список пуст\n");
            }
            return sb.ToString();
        }
    }
}
