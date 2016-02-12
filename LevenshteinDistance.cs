   static class LevenshteinDistance
    {

        public static int Compute(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] matrix = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            // Step 2
            for (int i = 0; i <= n; i++)
                matrix[i, 0] = i;

            for (int j = 0; j <= m; j++)
                matrix[0, j] = j;

            // Step 3
            for (int i = 1; i <= n; i++)
            {
                
                for (int j = 1; j <= m; j++)
                {
                    // Step 3.1
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    // Step 3.2
                    matrix[i, j] = Math.Min(
                        Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1),
                        matrix[i - 1, j - 1] + cost);
                }
            }
            // Step 4
            return matrix[n, m];
        }
    }
