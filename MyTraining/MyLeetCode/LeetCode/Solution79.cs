using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//给定一个二维网格和一个单词，找出该单词是否存在于网格中。

//单词必须按照字母顺序，通过相邻的单元格内的字母构成，其中“相邻”单元格是那些水平相邻或垂直相邻的单元格。

//同一个单元格内的字母不允许被重复使用。

//示例:
//    board =
//    [
//      ['A','B','C','E'],
//      ['S','F','C','S'],
//      ['A','D','E','E']
//    ]
//    给定 word = "ABCCED", 返回 true.
//    给定 word = "SEE", 返回 true.
//    给定 word = "ABCB", 返回 false.


namespace MyTraining.MyLeetCode
{

    //char[][] board = new char[3][] {
    //                          new char[] { 'A', 'B', 'C', 'E' },
    //                          new char[] { 'S', 'F', 'C', 'S' },
    //                          new char[] { 'A', 'D', 'E', 'E' }
    //                            };
    public class Solution79
    {
        public class Solution
        {
            bool[][] visit;
            char[][] boarda;
            char[] charwords;

            public bool Exist(char[][] board, string word)
            {
                boarda = board;

                charwords = word.ToCharArray();

                visit = new bool[board.Length][];
                for (int i = 0; i < board.Length; i++)
                {
                    visit[i] = new bool[board[i].Length];
                }

                for (int i = 0; i < board.Length; i++)
                {
                    for (int j = 0; j < board[i].Length; j++)
                    {
                        if (word.First() == board[i][j])
                        {
                            if (FindChar(i, j, 0))
                            {
                                return true;
                            }
                        }
                    }
                }
                return false;
            }

            public bool FindChar(int i, int j, int charwordIndex)
            {
                if (charwordIndex >= charwords.Length)
                    return true;

                if (i < 0  || i >= boarda.Length 
                    || j < 0 || j >= boarda[0].Length 
                    || boarda[i][j] != charwords[charwordIndex] 
                    || visit[i][j] == true)
                {
                    return false;
                }
                else
                {
                    visit[i][j] = true;
                }

                bool res = 
                    FindChar(i - 1, j, charwordIndex + 1) 
                    || FindChar(i + 1, j, charwordIndex + 1) 
                    || FindChar(i, j + 1, charwordIndex + 1) 
                    || FindChar(i, j - 1, charwordIndex + 1);

                //当我们把ij位置的所有都找完之后，会到这一步，不管成功与否，我们都需要
                //把ij这个位置的可走信息变成false（可走），因为这一步之后，会回溯至上一个位置的
                //另一种路线，而另一种路线是可以走ij这个位置的。
                visit[i][j] = false; 
                return res;
            }
        }
    }
}
