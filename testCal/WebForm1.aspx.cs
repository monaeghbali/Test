using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testCal
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            txtOutput.Text = Calculate(txtInput.Text);
        }

        //Reverse polish calculation
        public string Calculate(string text)
        {
            Stack<int> stackone = new Stack<int>();
            stackone.Clear();
            string[] inputarray = text.Split();
            int end = inputarray.Length - 1;
            int numinput;
            int i = 0;

            do
            {
                if (inputarray[i] != "=" && inputarray[i] != "+" && inputarray[i] != "-" && inputarray[i] != "*" && inputarray[i] != "/")
                {
                        numinput = Convert.ToInt32(inputarray[i]);
                        stackone.Push(numinput);
                }
                else if (inputarray[i] == "+")   { 
                        int store1 = stackone.Pop();
                        int store2 = stackone.Pop();
                        stackone.Push(store2 + store1);
                }
                else if (inputarray[i] == "-"){
                        int store1 = stackone.Pop();
                        int store2 = stackone.Pop();
                        stackone.Push(store2 - store1);
                }
                else if (inputarray[i] == "*"){
                        int store1 = stackone.Pop();
                        int store2 = stackone.Pop();
                        stackone.Push(store2 * store1);
                }
                else if (inputarray[i] == "/"){
                        int store1 = stackone.Pop();
                        int store2 = stackone.Pop();
                        stackone.Push(store2 / store1);
                }
            }
            while (i++ < end && stackone.Count != 0 && inputarray[i] != "=");
            string txtout = stackone.Pop().ToString();
            //return txtout;
            return "";
        }

       
    }
}