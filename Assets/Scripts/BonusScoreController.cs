using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusScoreController : MonoBehaviour
{
    [SerializeField] private GameObject penultimateScore;
    [SerializeField] private GameObject lastScore;
    [SerializeField] private GameObject bonusScore1;
    [SerializeField] private GameObject bonusScore2;
    private ScoreDropdown _penultimateDropdown;
    private ScoreDropdown _lastDropdown;
    private ScoreDropdown _bonus1Dropdown;
    private ScoreDropdown _bonus2Dropdown;


    private void Start()
    {
        _penultimateDropdown = penultimateScore.GetComponent<ScoreDropdown>();
        _lastDropdown = lastScore.GetComponent<ScoreDropdown>();
        _bonus1Dropdown = bonusScore1.GetComponent<ScoreDropdown>();
        _bonus2Dropdown = bonusScore2.GetComponent<ScoreDropdown>();
    }

    private void Update()
    {
        //10 = Spare | 11 = strike
        if (_penultimateDropdown.GetLabelValue() == 11 || _lastDropdown.GetLabelValue() == 10 || _lastDropdown.GetLabelValue() == 11)
        {
            bonusScore1.SetActive(true);
        }
        else
        {
            bonusScore1.SetActive(false);
            ResetDropdownValue(_bonus1Dropdown);
        }

        if (_lastDropdown.GetLabelValue() == 11)
        {
            bonusScore2.SetActive(true);
        }
        else
        {
            bonusScore2.SetActive(false);
            ResetDropdownValue(_bonus2Dropdown);
        }
        
    }

    private void ResetDropdownValue(ScoreDropdown scoreDropdown)
    {
        try
        {
            scoreDropdown.ResetValue();
        }
        catch
        {
            // ignored
        }
    }
}
