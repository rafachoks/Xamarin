using System;
using UIKit;

namespace Example_ContentControls
{
	public class Application// : UIApplication
	{
		public static void Main (string[] args)
		{
			try
			{
				UIApplication.Main (args, null, "AppDelegate");
			}
			catch (Exception e)
			{
				Console.WriteLine (e.ToString ());
			}
		}
	}
}