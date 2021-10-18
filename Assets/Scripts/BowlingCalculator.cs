using System.Collections.Generic;
using UnityEngine;

public class BowlingCalculator
{
    private int _score = 0;

    public int CalculateScore(List<int> throws)
    {
        for (int i = 0; i < 10; i++)
        {
            switch (throws[i])
            {
                //Strike
                case 12:
                    _score += 10 + Mathf.Min(throws[i + 1], 10) + Mathf.Min(throws[i + 2], 10);
                    break;
                //Spare
                case 11:
                    _score += 10 + Mathf.Min(throws[i + 1], 10);
                    break;
                default:
                    _score += throws[i];
                    break;
            }
        }

        return _score;
    }
}
