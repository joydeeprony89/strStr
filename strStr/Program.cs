using System;

namespace strStr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrStr("mississippi", "issip"));
        }

        static int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrWhiteSpace(haystack)) return 0;
            for(int i = 0; i < haystack.Length; i++)
            {
                int length = needle.Length;
                int j = i ;
                int k = 0;
                while (j < haystack.Length && length > 0 && haystack[j] == needle[k])
                {
                    k++; j++; length--;
                }
                if (length == 0) return j - needle.Length; 
            }
            return -1;
        }
    }
}
