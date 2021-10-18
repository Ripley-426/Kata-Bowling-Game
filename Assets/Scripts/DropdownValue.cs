using UnityEngine;
using UnityEngine.UI;

public class DropdownValue : MonoBehaviour
{
    [SerializeField] private Dropdown dropdown;

    public int GetLabelValue()
    {
        return dropdown.value;
    }
}
