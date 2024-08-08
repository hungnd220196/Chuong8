using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong8
{
    //demo indexer
    class IndexerClass
    {
        private int[] arr = new int[100];
        public int this[int index]
        {
            get
            {
                // kiem tra mien gia tri cua chi so index
                if (index < 0 || index >= 100)
                {
                    return 0;
                }
                else
                {

                    return arr[index];
                }
            }
            set
            {
                if (!(index < 0 || index >= 100))
                {
                    arr[index] = value;
                }
            }
        }
    }
    //demo2
    class DayCollection
    {
        string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        // tra ve chi so ngay trong mang
        public int this[string inputDay]
        {
            get
            {
                int i = 0;
                foreach (string day in days)
                {
                    if (day == inputDay)
                    {
                        return i;
                    }
                    i++;
                }
                return -1;

            }

        }
    }

}
