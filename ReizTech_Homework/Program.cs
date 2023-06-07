using ReizTech_Homework;

//Assignment 1
int hour, minute;
try 
{ 

	Console.WriteLine("Enter the hour (0-12): ");
	hour = int.Parse(Console.ReadLine());

	Console.WriteLine("Enter the minute (0-59): ");
	minute = int.Parse(Console.ReadLine());

	double lesserAngle = ClockAngleCalculator.GetClockAngle(hour, minute);
	Console.WriteLine($"Lesser angle between the hour and minute hand is: {lesserAngle} degrees.");
}
catch(Exception ex)
{
	Console.WriteLine($"Error: {ex.Message}");	
}

//Assignment 2
/*
 (Branch#)
		            (1)
				   /   \
			    (2)     (4)
			   /       / | \
	  	    (3)     (5) (7) (11)
		           /   /   \
		        (6)  (8)    (10)
                      |
                     (9)
*/


Branch branch1 = new Branch();
Branch branch2 = new Branch();
Branch branch3 = new Branch();
Branch branch4 = new Branch();
Branch branch5 = new Branch();
Branch branch6 = new Branch();
Branch branch7 = new Branch();
Branch branch8 = new Branch();
Branch branch9 = new Branch();
Branch branch10 = new Branch();
Branch branch11 = new Branch();


branch8.branches.Add(branch9);
branch5.branches.Add(branch6);
branch7.branches.Add(branch8);
branch7.branches.Add(branch10);
branch4.branches.Add(branch5);
branch4.branches.Add(branch7);
branch4.branches.Add(branch11);
branch2.branches.Add(branch3);
branch1.branches.Add(branch2);
branch1.branches.Add(branch4);

int depth = TreeDepthCalculator.GetDepth(branch1);

Console.WriteLine($"Depth of Branch 1: {depth}");

Console.ReadLine();
