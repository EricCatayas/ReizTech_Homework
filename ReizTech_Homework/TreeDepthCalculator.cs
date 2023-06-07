using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTech_Homework
{
	public static class TreeDepthCalculator
	{
		public static int GetDepth(Branch branch)
		{
			int depth = 1;

			if (branch.branches.Count > 0)
			{

				foreach (Branch child in branch.branches)
				{
					int newDepth;

					newDepth = GetDepth(child);

					if(newDepth > depth)
					{
						// Assign greater value as current depth
						depth = newDepth;
					}
				}
			}
			else
			{
				return depth;
			}

			// A Branch with at least one child should return 2
			return depth + 1;
		}

	}
}


