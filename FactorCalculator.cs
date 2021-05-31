using System;
					
public class FactorCalculator
{
	
	public int HighestCommonFactorSimpleLoop(int variable1, int variable2)
    {
        
        if (variable1 == 0 || variable2 == 0)
        {
            return -1; //Cannot find factors of zero
        }
        
        //Factors of positive and negative numbers are 'similar' and in terms of highest are the same for example
        //factors of 4 are 1x4, 2x2, -1x-4, -2,-2 vs -4 are -1x4, -2x2, 1x-4 both having highest common factor of 4;
        int variable1Abs = Math.Abs(variable1);
        int variable2Abs = Math.Abs(variable2);
        
        //Variables are the same (ignoring the sign) we know the highest without any calculations
        if (variable1Abs == variable2Abs)
        {
            return variable1Abs;
        }

		//Starting factor to check
        int minVariable = Math.Min(variable1Abs, variable2Abs);
		
		//If both varibales are even we can skip odd numbers
		int decrementor = (variable1Abs % 2 == 0 && variable2Abs % 2 == 0) ? 2 : 1;

        for (int factor = minVariable; factor > 1; factor = factor - decrementor)
        {
			//If both remainders are 0 then it is a factor of both
            if (variable1Abs % factor == 0 && variable2Abs % factor == 0)
            {
                return factor;
            }
        }

        // No factors found greater than 1. 1 is a common factor for all integers
        return 1;
    }
}