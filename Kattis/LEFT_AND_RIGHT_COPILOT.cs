using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//With modern technology advancement, it is now possible to deliver mail with a robot! There is a neighborhood on a long horizontal road, on which there are n houses numbered 1 to n from left to right.Every day a mail delivery robot receives a pile of letters with exactly one letter for each house. Due to mechanical restrictions, the robot cannot sort the letters. It always checks the letter on top of the pile, visits the house that should receive that letter and delivers it.The robot repeats this procedure until all the letters are delivered.As a result, each of the n houses is visited by the robot exactly once during the mail delivery of a single day.

//The mail delivery robot has a tracking device that records its delivery route.One day the device was broken, and the exact route was lost. However, the technical team managed to recover the moving directions of the robot from the broken device, which are represented as a string consisting of n−1 letters.The i-th letter of the string is ‘L’ (or ‘R’) if the(i + 1) - th house visited by the robot is on the left(or right) of the i-th house visited.For example, if n=4 and the robot visited the houses in the order of 2,4,3,1, its moving directions would be “RLL”.

//With the moving directions, it may be possible to determine the order in which the robot visited the houses.The technical team has asked you to write a program to do that.There can be multiple orders producing the same moving directions, among which you should find the lexicographically earliest order.

//Input
//The input has a single integer n (2≤n≤2⋅105) on the first line.The second line has a string of length n−1 consisting of letters ‘L’ and ‘R’ giving the moving directions of the robot.

//Output
//Output the lexicographically earliest order in which the robot may have visited the houses and delivered the letters according to the moving directions.Consider two different integer sequences of equal length A= (a1, a2,…, ak) and B = (b1, b2,…, bk), and let 1≤i≤k be the lowest-numbered index where ai≠bi.Then A is lexicographically earlier than B if ai<bi; otherwise B is lexicographically earlier than A.
namespace Kattis
{
    public class LEFT_AND_RIGHT_COPILOT
    {
        public static void LeftAndRight(){
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int[] arr = new int[n];
            int[] arr2 = new int[n];
            for(int i = 0; i < n; i++){
                arr[i] = i + 1;
                arr2[i] = i + 1;
            }
            for(int i = 0; i < n - 1; i++){
                if(s[i] == 'L'){
                    arr[i] = arr[i] - 1;
                    arr2[i + 1] = arr2[i + 1] - 1;
                }
                else{
                    arr[i + 1] = arr[i + 1] - 1;
                    arr2[i] = arr2[i] - 1;
                }
            }
            string s1 = "";
            string s2 = "";
            for(int i = 0; i < n; i++){
                s1 += arr[i];
                s2 += arr2[i];
            }
            if(s1.CompareTo(s2) < 0){
                Console.WriteLine(s1);
            }
            else{
                Console.WriteLine(s2);
            }
        }
    }
}
