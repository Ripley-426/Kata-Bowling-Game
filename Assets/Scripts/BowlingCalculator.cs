using System.Collections.Generic;
using UnityEngine;

public class BowlingCalculator
{
    public int CalculateScore(List<int> throws)
    {
        int score = 0;
        for (int i = 0; i < 10; i++)
        {
            switch (throws[i])
            {
                //Strike
                case 11:
                    score += 10 + Mathf.Min(throws[i + 1], 10) + Mathf.Min(throws[i + 2], 10);
                    break;
                //Spare
                case 10:
                    score += 10 + Mathf.Min(throws[i + 1], 10);
                    break;
                default:
                    score += throws[i];
                    break;
            }
        }

        return score;
    }
}
