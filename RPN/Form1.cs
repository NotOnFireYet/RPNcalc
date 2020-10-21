using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace RPN_feeble_tries {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.Text = "Stack Calculator";
        }

		private void calc_button_Click(object sender, EventArgs e) {

			string[] inp = input.Text.Split();

			/////INTUP INTO RPN/////

			Stack<string> out_stack = new Stack<string>();
			Stack<string> operations = new Stack<string>();

			string curr;

			for (int i = 0; i < inp.Length; i++) {

				curr = inp[i];

				if (Single.TryParse(curr, out float n))
					out_stack.Push(curr);
				else {
					if (operations.Count != 0) {
						switch (curr) {

                            case "(":
                                operations.Push(curr);
                               break;

                            case ")": //видит закрывашку, закидывает все в стак до открывашки и удаляет ее из op
								if (operations.Count != 0) {
									while (operations.Peek() != "(")
										out_stack.Push(operations.Pop());
									operations.Pop();
								} else
									operations.Push(curr);
								break;
                            
                            case "+":
							case "-":
								if (operations.Peek() == "/" || operations.Peek() == "*")
									out_stack.Push(operations.Pop());
								operations.Push(curr);
								break;

							case "*":
							case "/":
								if (operations.Peek() == "+" || operations.Peek() == "-")
									operations.Push(curr);
								else {
									out_stack.Push(operations.Pop());
									operations.Push(curr);
								}
								break;
						}
					}
					else
						operations.Push(curr);
				}
            }

			if (operations.Count != 0) {
				while (operations.Count != 0)
					out_stack.Push(operations.Pop());
			}

			/////CALCULATIONS/////

			string[] in_calc = out_stack.ToArray();
			Array.Reverse(in_calc); 

			Stack<float> nums = new Stack<float>();

			float num1;
			float num2; 
			float rez = new float();

			foreach (string i in in_calc) {

				if (Single.TryParse(i, out num1)) {
					nums.Push(Single.Parse(i));
				}
				else {
					num1 = nums.Pop();
					num2 = nums.Pop();

					Debug.WriteLine(num1);
					Debug.WriteLine(num2);

					switch (i) {
						case "+":
							rez = num1 + num2;
							break;

						case "-":
							rez = num2 - num1;
							break;

						case "*":
							rez = num1 * num2;
							break;

						case "/":
							rez = num2 / num1;
							break;
					}
					
					nums.Push(rez);
				}
			}

			output.Text = nums.Pop().ToString();
            loglist.Items.Add(input.Text + " = " + output.Text);
		}

		private void button1_Click(object sender, EventArgs e) {
			output.Clear();
            input.Clear();
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
	}
}
