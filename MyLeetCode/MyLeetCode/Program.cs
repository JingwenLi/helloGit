using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCode
{
    public class Program
    {
        public class Shape
        {
            // A few example members
            public int X { get; private set; }
            public int Y { get; private set; }
            public int Height { get; set; }
            public int Width { get; set; }

            // Virtual method
            public void Draw()
            {
                Debug.WriteLine("Performing base class drawing tasks");
            }
        }
        class Circle : Shape
        {
            public void Draw()
            {
                // Code to draw a circle...
                Debug.WriteLine("Drawing a circle");
            }
        }
        class Rectangle : Circle
        {
            public override void Draw()
            {
                // Code to draw a rectangle...
                Debug.WriteLine("Drawing a rectangle");
                base.Draw();
            }
        }
        class Triangle : Shape
        {
            //public override void Draw()
            //{
            //    // Code to draw a triangle...
            //    Debug.WriteLine("Drawing a triangle");
            //    base.Draw();
            //}
        }

        public static void Main()
        {
            Circle cc = new Circle();
            cc.Draw();

            Shape sc = new Circle();
            sc.Draw();

            //var shapes = new List<Shape>
            //{
            //    new Rectangle(),
            //    new Triangle(),
            //    new Circle()
            //};

            //// Polymorphism at work #2: the virtual method Draw is
            //// invoked on each of the derived classes, not the base class.
            //foreach (var shape in shapes)
            //{
            //    shape.Draw();
            //}



            //int result = (new Solution11.Solution()).MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
            //Debug.WriteLine("result : " + result);

            //Debug.WriteLine("result : " + (new WiseTeach1()).TransferNums("1.11").Trim());

            //char[][] board = new char[1][] {
            //                  new char[] { 'a'},
            //                    };

            //char? a;

            //string result = (new Solution5.Solution()).LongestPalindrome("fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffgggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggg");
            //Debug.WriteLine("result : " + result);


            //char[][] board = new char[3][] {
            //                  new char[] { 'a','b'},
            //                  new char[] { 'a','a'},
            //                  new char[] { 'b','a'},
            //                    };

            //bool result = (new Solution79.Solution()).Exist(board, "a");
            //Debug.WriteLine("result : " + result);

            //char[][] board = new char[7][] {
            //                  new char[] { 'F','Y','C','E','N','R','D' },
            //                  new char[] { 'K','L','N','F','I','N','U' },
            //                  new char[] { 'A','A','A','R','A','H','R' },
            //                  new char[] { 'N','D','K','L','P','N','E' },
            //                  new char[] { 'A','L','A','N','S','A','P' },
            //                  new char[] { 'O','O','G','O','T','P','N' },
            //                  new char[] { 'H','P','O','L','A','N','O' },
            //                    };

            //bool result = (new Solution79.Solution()).Exist(board, "FRANCE");
            //Debug.WriteLine("result : " + result);


            //char[][] board = new char[3][] {
            //                  new char[] { 'A', 'B', 'C', 'E' },
            //                  new char[] { 'S', 'F', 'C', 'S' },
            //                  new char[] { 'A', 'D', 'E', 'E' }
            //                    };

            //bool result = (new Solution79.Solution()).Exist(board, "ABCCED");
            //Debug.WriteLine("result : " + result);

            //char[][] board = new char[1][] {
            //                  new char[] { 'a', 'a'},
            //                    };


            //bool result = (new Solution79.Solution()).Exist(board, "aaa");
            //Debug.WriteLine("result : " + result);

            //char[][] board = new char[3][] {
            //                  new char[] { 'A', 'B', 'C', 'E' },
            //                  new char[] { 'S', 'F', 'E', 'S' },
            //                  new char[] { 'A', 'D', 'E', 'E' }
            //                    };

            //bool result = (new Solution79.Solution()).Exist(board, "ABCESEEEFS");
            //Debug.WriteLine("result : " + result);

            //List<string> nums = new List<string> { "a", "aa", "aaa", "aaaa", "aaaaa", "aaaaaa", "aaaaaaa", "aaaaaaaa", "aaaaaaaaa", "aaaaaaaaaa" };
            //bool result = (new Solution139.Solution()).WordBreak("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab", nums);

            //List<string> nums = new List<string> { "a", "abc", "b", "cd" };
            //bool result = (new Solution139.Solution()).WordBreak("abcd", nums);

            //List<string> nums = new List<string> { "bc", "cb" };
            //bool result = (new Solution139.Solution()).WordBreak("ccbb", nums);
        }
    }
}
