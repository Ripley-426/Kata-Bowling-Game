using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private Text nameLabel;
    [SerializeField] private Text errorLabel;
    [SerializeField] private GameObject playerNamePanel;
    [SerializeField] private GameObject scorePanel;

    public void SetName()
    {
        if (nameInput.text == "")
        {
            DisplayErrorMessage("Please insert a name");
        }
        else
        {
            SetNameInScoreBoard();
            DisablePlayerNamePanel();
            EnableScorePanel();
        }
    }
    private void DisplayErrorMessage(string error)
    {
        errorLabel.text = error;
    }
    private void SetNameInScoreBoard()
    {
        nameLabel.text = nameInput.text;
    }
    private void DisablePlayerNamePanel()
    {
        playerNamePanel.gameObject.SetActive(false);
    }
    private void EnableScorePanel()
    {
        scorePanel.gameObject.SetActive(true);
    }
}
