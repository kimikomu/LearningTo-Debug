using System;
// using System.Diagnostics;		// for Debug.WriteLine

namespace LearningToDebug
{
	class Program
	{
		static void Main()
		{
			// Debug.WriteLine: issues for using this method to debug:
			// 1. You have to write a new line of code for each log. Over time, log may be littered with calls you no longer need. Make sure to clean up afterwards.
			// 2. No central place to manage all of the log statements

			//int loop = 0;
			//for (int i = 0; i < 10; i++)
			//{
			//loop++;
			//Debug.WriteLine($"Current loop itteration: {loop}");      // Logs to output window

			//Console.Write("Type the string to log: ");
			//string input = Console.ReadLine();
			//Debug.WriteLine(input);
			//}




			// Breakpoints -  click on left side OR highlight and right click and select Breakpoint -> Insert Breakpoint: useful for ternary if statements

			int loop = 0;
			for (int i = 0; i < 10; i++)
			{

				// Tracepoints - Special kind of breakpoin
				// breakpoint to tracepoint: change settings, Actions checkbox ckecked, Log message, Continue excution checkbox checked
				// tracepoints are dimond markers instead of circles like regular breakpoints
				

				Console.Write("Type the string to log: ");
				string input = Console.ReadLine();

				loop++;
			}


		}
	}
}
