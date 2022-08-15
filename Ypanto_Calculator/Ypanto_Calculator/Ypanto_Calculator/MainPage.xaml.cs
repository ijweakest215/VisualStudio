using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ypanto_Calculator
{
    public partial class MainPage : ContentPage
    {
        int currentState = 1;
        string mathOperator;
        double firstNumber, secondNumber;
		Stack<double> memory = new Stack<double>();
		String memoryOp;
		
		public MainPage()
		{
			InitializeComponent();
			memory.Push(0);
			OnClear(this, null);
		}

		void OnSelectNumber(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			string pressed = button.Text;

			if (this.resultText.Text == "0" || currentState < 0)
			{
				this.resultText.Text = "";
				if (currentState < 0)
					currentState *= -1;
			}

			this.resultText.Text += pressed;

			double number;
			if (double.TryParse(this.resultText.Text, out number))
			{
				this.resultText.Text = number.ToString("N0");
				if (currentState == 1)
				{
					firstNumber = number;
				}
				else
				{
					secondNumber = number;
				}
			}
		}

		void OnSelectOperator(object sender, EventArgs e)
		{
			currentState = -2;
			Button button = (Button)sender;
			string pressed = button.Text;
			mathOperator = pressed;
		}

		void OnClear(object sender, EventArgs e)
		{
			firstNumber = 0;
			secondNumber = 0;
			currentState = 1;
			this.resultText.Text = "0";
		}

		void OnCalculate(object sender, EventArgs e)
		{
			if (currentState == 2)
			{
				var result = Calculate(firstNumber, secondNumber, mathOperator);

				this.resultText.Text = result.ToString();
				firstNumber = result;
				currentState = -1;
			}
		}

		void OnSelectMemory(object sender, EventArgs e)
		{
            Button button = (Button)sender;
			string pressed = button.Text;
			memoryOp = pressed;
			double num;
			double.TryParse(this.resultText.Text,out num);
            switch (memoryOp) 
			{
				case "M+":
                    this.memory.Push(num);
                    //Console.WriteLine("Success");
                    break;

                case "M-":
                    this.memory.Pop();
					//Console.WriteLine("Success");
					break;

                case "MC":
                    this.memory.Clear();
					//Console.WriteLine("Success");
					this.memory.Push(0);
					break;

                case "MR":
                    double peek = this.memory.Peek();
                    this.resultText.Text = peek.ToString();
                    break;
            }
			currentState = -1;
		}

        public static double Calculate(double value1, double value2, string mathOperator)
		{
			double result = 0;

			switch (mathOperator)
			{
				case "÷":
					result = value1 / value2;
					break;
				case "×":
					result = value1 * value2;
					break;
				case "+":
					result = value1 + value2;
					break;
				case "-":
					result = value1 - value2;
					break;
			}

			return result;
		}
	}
}
