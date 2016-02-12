# Levenshtein_Distance_CSharp-
This repository contains C# version of Levenshtein distance calculation code.

  The Levenshtein algorithm calculates the least number of edit operations that are necessary to modify one string to obtain another string.Here explained the most common way of calculating this - Dynamic programming approach. 
  A matrix is initialized measuring in the (m,n)-cell the Levenshtein distance between the m-character prefix of one with the n-prefix of the other word. The matrix can be filled from the upper left to the lower right corner. Each jump horizontally or vertically corresponds to an insert, delete or a substitute, respectively. The cost is set to 1 for each of the operations. 

Example: string 1 = SYNTAX; string 2 = SEMANTICS.

Step 1: We check if any of the strings is empty. If so, edit distance will be equal to another string length.

Step 2: Then, we fill the matrix with initial values:
              
              		S	Y	N	T	A	X
              	0	1	2	3	4	5	6
              S	1						
              E	2						
              M	3						
              A	4						
              N	5						
              T	6						
              I	7						
              C	8						
              S	9						

Step 3: Calculation time! What we do is we are running through the colums from left to right, doing 3.1 and 3.2 tasks. So we first check the column "S"  from the top to the bottom, then from the "Y" from the top to the bottom, until the last one – “X”.

3.1 We check if letters for current cell is equal. If so, cost = 0. If not cost = 1. Cost for “S:S” cell will be zero. Cost for “E:S” will be 1.

3.2 Here, we filling the current cell, by using this math expression: Math.Min(Math.Min(matrix[i- 1, j] + 1, matrix[i, j - 1] + 1), matrix[i - 1, j - 1] + cost). So, we take value from left, and value from above, comparing this values, and take minimum. Then, we compare this minimum value with value from above left plus cost, and again take the minimum.    

              		S	Y	N	T	A	X
              	0	1	2	3	4	5	6
              S	1	0	1	2	3	4	5
              E	2	1	1	2	3	4	5
              M	3	2	2	2	3	4	5
              A	4	3	3	3	3	3	4
              N	5	4	4	3	4	4	4
              T	6	5	5	4	3	4	5
              I	7	6	6	5	4	4	5
              C	8	7	7	6	5	5	5
              S	9	8	8	7	6	6	6

Step 4: the number in the lower right corner is the Levenshtein distance between both words = 6.
