using System.Collections.Generic;

namespace MDPro3
{
    public class MultiStringMaster
    {
        public string managedString = "";
        public class Part
        {
            public int count;
            public string str;
        }

        public List<Part> strings = new List<Part>();

        public void Add(string str)
        {
            var exist = false;
            for (var i = 0; i < strings.Count; i++)
                if (strings[i].str == str)
                {
                    exist = true;
                    strings[i].count++;
                }
            if (exist == false)
            {
                var t = new Part();
                t.count = 1;
                t.str = str;
                strings.Add(t);
            }
            ReCreateString();
        }
        public void Remove(string str, bool all = false)
        {
            Part t = null;
            for (var i = 0; i < strings.Count; i++)
                if (strings[i].str.Replace(str, "miaowu") != strings[i].str)
                    t = strings[i];
            if (t != null)
            {
                if(all)
                    strings.Remove(t);
                else
                {
                    if (t.count == 1)
                        strings.Remove(t);
                    else
                        t.count--;
                }
            }
            ReCreateString();
        }
        void ReCreateString()
        {
            managedString = "";
            for (var i = 0; i < strings.Count; i++)
                if (strings[i].count == 1)
                    managedString += strings[i].str + "\n";
                else
                    managedString += strings[i].str + "*" + strings[i].count + "\n";
        }
        public void Clear()
        {
            strings.Clear();
            managedString = "";
        }
    }
}
