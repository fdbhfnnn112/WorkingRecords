using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeetCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
                
        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
            Valid_Parentheses VP = new Valid_Parentheses();
            var vp = VP.Version2ForStach("(([]){})");


            Remove_Nth_Node_From_End_of_List.Solution RNNFE = new Remove_Nth_Node_From_End_of_List.Solution();
            Remove_Nth_Node_From_End_of_List.ListNode v = new Remove_Nth_Node_From_End_of_List.ListNode(1);
            v.next = new Remove_Nth_Node_From_End_of_List.ListNode(2);
            v.next.next = new Remove_Nth_Node_From_End_of_List.ListNode(3);
            v.next.next.next = new Remove_Nth_Node_From_End_of_List.ListNode(4);
            v.next.next.next.next = new Remove_Nth_Node_From_End_of_List.ListNode(5);
            var rnnfe = RNNFE.RemoveNthFromEnd(v,2);

            _4Sum S4 = new _4Sum();
            var S4T = S4.fourSum(new int[] { 1, 0, -1, 0, -2, 2 } ,0);

            Letter_Combinations_of_a_Phone_Number LCOAPN = new Letter_Combinations_of_a_Phone_Number();
            var lco = LCOAPN.LetterCombinations("23");

            _3Sum_Closest _3C = new _3Sum_Closest();
            var _3c = _3C.ThreeSumClosest(new int[] { 0,0,0 },1);

            _15_3Sum _153 = new _15_3Sum();
            var _15_3 = _153.threeSum(new int[] { -1, 0, 1, 2, -1, -4});

            Longest_Common_Prefix LCP = new Longest_Common_Prefix();
            var lcp = LCP.LongestCommonPrefix(new string[] { "aca", "cba" });

            Integer_to_Roman ITR = new Integer_to_Roman();
            var itr = ITR.RomanToInt("MCMXCVI");

            Container_With_Most_Water CWMW = new Container_With_Most_Water();
            var cwmw = CWMW.MaxAreaEasy(new int[] {1, 8, 6, 2, 5, 4, 8, 3, 7});

            Regular_Expression_Matching REM = new Regular_Expression_Matching();
            var rem = REM.IsMatch("mississippi", "mis*is*p*.");

            Palindrome_Number PN = new Palindrome_Number();
            var pn =  PN.IsPalindrome(-121);

            String_to_integer__atoi_ STI = new String_to_integer__atoi_();
            var sti =  STI.MyAtoi(" + 0 123");

            Reverse_Integer Ri = new Reverse_Integer();
            var RiIndex = Ri.Reverse(1534236469);

            ZigZag_Conversion ziz = new ZigZag_Conversion();
            var Strugmmkq=  ziz.Convert("PAYPALISHIRING", 4);

            Longest_Palindromic_Substring l = new Longest_Palindromic_Substring();
           //var index =  l.LongPalind("abcabc");
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            webBrowser1.Document.Window.ScrollTo(100, 100);
        }
    }
}
