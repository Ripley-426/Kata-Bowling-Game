using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private GameObject scoreGameObject;
    [SerializeField] private Text scoreLabel;
    private readonly BowlingCalculator _bc = new BowlingCalculator();

    private List<int> GetThrowsList()
    {
        List<int> throws = new List<int>();
        foreach (Transform child in scoreGameObject.transform)
        {
            DropdownValue dropdown = child.gameObject.GetComponent<DropdownValue>();
            throws.Add(dropdown.GetLabelValue());
        }
        return throws;
    }

    public void CalculateScore()
    {
        scoreLabel.text = "0";
        int score = _bc.CalculateScore(GetThrowsList());
        scoreLabel.text = score.ToString();
    }
}
