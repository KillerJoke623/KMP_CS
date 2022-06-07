﻿using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public class CFG
    {
        public List<int> A = new List<int>();
        public void KMPSearch(string pat, string txt)
        {
            int M = pat.Length;
            int N = txt.Length;
            
            int[] lps = new int[M];
            int j = 0; 
            
            computeLPSArray(pat, M, lps);

            int i = 0; 
            while (i < N) {
                if (pat[j] == txt[i]) {
                    j++;
                    i++;
                }
                if (j == M) {
                    A.Add(i-j);;
                    j = lps[j - 1];
                }
                
                else if (i < N && pat[j] != txt[i]) {
                    
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i = i + 1;
                }
            }
        }

        void computeLPSArray(string pat, int M, int[] lps)
        {
            
            int len = 0;
            int i = 1;
            lps[0] = 0; 

            
            while (i < M) {
                if (pat[i] == pat[len]) {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else 
                {
                    if (len != 0) {
                        len = lps[len - 1];

                    }
                    else 
                    {
                        lps[i] = len;
                        i++;
                    }
                }
            }
        }
    }
}