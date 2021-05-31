using System;
					
public class FactorCalculatorExtendedEuclidean
{
	struct component
	{
		public int x;
		public int y;
		public int d;
	}
	
	public int HighestCommonFactorUsingExtendedEuclidean(int variable1, int variable2)
    {
        
        if (variable1 == 0 || variable2 == 0)
        {
            return -1; //Cannot find factors of zero
        }
        
        //Variables are the same (ignoring the sign) we know the highest without any calculations
        if (Math.Abs(variable1) == Math.Abs(variable2))
        {
            return Math.Abs(variable1);
        }

		component A = new component();
		A.x = 1;
		A.y = 0;
		A.d = Math.Max(variable1, variable2);
		
		component B = new component();
		B.x = 0;
		B.y = 1;
		B.d = Math.Min(variable1, variable2);
		
		component AOld;
		
		int q;
		
		while(true)
		{
			if(B.d == 0)
			{
				return Math.Abs(A.d);
			}
			
			q = (int)Math.Round((double)A.d/(double)B.d);
			AOld = A;
			A = B;
			B.x = AOld.x - q * B.x;
			B.y = AOld.y - q * B.y;
			B.d = AOld.d - q * B.d;
		}
    }
}