using System;
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
        private List<MyStruct> l = new ();

        public List<MyStruct> MyList
        {
            get => l;
            set => l = value;
        }

        public void Add(MyStruct s)
        {
            MyList.Add(s);
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
