using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButtonsManager : MonoBehaviour
{
    public event Action<Toggle> ActiveToggleHasChanged;
    public event Action<Toggle> MatchToggleHasChanged;
    public Toggle activeToggle;

    public void InvokeEvent(Toggle toggle)
    {
        ActiveToggleHasChanged?.Invoke(toggle);
    }

    public void InvokeMatchToggleChanged(Toggle toggle)
    {
        MatchToggleHasChanged?.Invoke(toggle);
    }
}
