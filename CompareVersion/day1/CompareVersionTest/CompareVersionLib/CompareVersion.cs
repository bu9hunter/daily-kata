using System;

namespace CompareVersionLib
{
    public class CompareVersionClass
    {
        public CompareVersionClass()
        {
        }

        public int CompareVersion(string version1, string version2)
        {
            int cnt = 0;

            foreach (string element1 in version1.Split('.'))
            {
                foreach (string element2 in version2.Split('.'))
                {
                    int local_cnt = 0;
                    if (local_cnt < cnt) continue;

                    if (Convert.ToInt32(element1) > Convert.ToInt32(element2))
                    {
                        return 1;
                    }
                    else if (Convert.ToInt32(element1) < Convert.ToInt32(element2))
                    {
                        return -1;
                    }
                    break;
                }
                cnt++;
            }

            return 0;
        }

        //public int CompareVersion(string version1, string version2)
        //{
        //    int[] ver1 = new int[4];
        //    int[] ver2 = new int[4];
        //    int cnt = 0;

        //    foreach (string element in version1.Split('.'))
        //    {
        //        ver1[cnt++] = Convert.ToInt32(element);
        //    }

        //    cnt = 0;
        //    foreach (string element in version2.Split('.'))
        //    {
        //        ver2[cnt++] = Convert.ToInt32(element);
        //    }

        //    for (int i = 0; i < 4; i++)
        //    {
        //        if (ver1[i] > ver2[i])
        //        {
        //            return 1;
        //        }
        //        else if (ver1[i] < ver2[i])
        //        {
        //            return -1;
        //        }
        //    }

        //    return 0;
        //}
    }
}