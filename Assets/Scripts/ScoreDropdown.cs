using UnityEngine;
using UnityEngine.UI;

public class ScoreDropdown : MonoBehaviour
{
    [SerializeField] private Dropdown dropdown;

    public int GetLabelValue()
    {
        return dropdown.value;
    }

    public void ResetValue()
    {
        dropdown.value = 0;
    }
}
