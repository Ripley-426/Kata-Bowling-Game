using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private GameObject scoreGameObject;
    [SerializeField] private GameObject bonusScore1;
    [SerializeField] private GameObject bonusScore2;
    [SerializeField] private Text scoreLabel;
    private readonly BowlingCalculator _bc = new BowlingCalculator();
    private readonly List<int> _throws = new List<int>();

    public void CalculateScore()
    {
        scoreLabel.text = "0";
        int score = _bc.CalculateScore(GetThrowsList());
        scoreLabel.text = score.ToString();
    }
    
    private List<int> GetThrowsList()
    {
        _throws.Clear();
        foreach (Transform child in scoreGameObject.transform)
        {
            ScoreDropdown scoreDropdown = child.gameObject.GetComponent<ScoreDropdown>();
            _throws.Add(scoreDropdown.GetLabelValue());
        }

        AddBonusScore(bonusScore1);
        AddBonusScore(bonusScore2);
        
        return _throws;
    }

    private void AddBonusScore(GameObject bonusScore)
    {
        ScoreDropdown scoreDropdown = bonusScore.GetComponent<ScoreDropdown>();
        _throws.Add(scoreDropdown.GetLabelValue());
    }
}
