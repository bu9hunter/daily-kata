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
            string[] ver1 = version1.Split('.');
            string[] ver2 = version2.Split('.');

            int idx = ver1.Length > ver2.Length ? ver1.Length : ver2.Length;
            
            for (int i = 0; i < idx; i++)
            {
                int intVer1 = 0;
                int intVer2 = 0;

                if (i < ver1.Length) intVer1 = Convert.ToInt32(ver1[i]);
                if (i < ver2.Length) intVer2 = Convert.ToInt32(ver2[i]);

                if (intVer1 > intVer2) return 1;
                else if (intVer1 < intVer2) return -1;
            }

            return 0;
        }

        public int CompareVersion(string version1, string version2)
        {
            int cnt = 0;
            int ver1 = 0;
            int ver2 = 0;

            foreach (string element1 in version1.Split('.'))
            {
                if (String.IsNullOrEmpty(element1))
                {
                    ver1 = 0;
                    version1 = "";
                }
                else
                {
                    cnt++;
                    ver1 = Convert.ToInt32(element1);
                    version1 = version1.Substring(cnt);
                }

                foreach (string element2 in version2.Split('.'))
                {
                    if (String.IsNullOrEmpty(element2))
                    {
                        ver2 = 0;
                        version2 = "";
                    }
                    else
                    {
                        ver2 = Convert.ToInt32(element2);
                        version2 = version2.Substring(cnt);
                    }

                    if (ver1 > ver2)
                    {
                        return 1;
                    }
                    else if (ver1 < ver2)
                    {
                        return -1;
                    }

                    break;
                }
            }

            return 0;
        }

        public int CompareVersion(string version1, string version2)
        {
            int[] ver1 = new int[4];
            int[] ver2 = new int[4];
            int cnt = 0;

            foreach (string element in version1.Split('.'))
            {
                ver1[cnt++] = Convert.ToInt32(element);
            }

            cnt = 0;
            foreach (string element in version2.Split('.'))
            {
                ver2[cnt++] = Convert.ToInt32(element);
            }

            for (int i = 0; i < 4; i++)
            {
                if (ver1[i] > ver2[i])
                {
                    return 1;
                }
                else if (ver1[i] < ver2[i])
                {
                    return -1;
                }
            }

            return 0;
        }
    }
}