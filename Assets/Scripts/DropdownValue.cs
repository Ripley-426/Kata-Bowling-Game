using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownValue : MonoBehaviour
{
    [SerializeField] private Dropdown dropdown;

    public int GetLabelValue()
    {
        Debug.Log(dropdown.value, gameObject);
        return dropdown.value;
    }
}
