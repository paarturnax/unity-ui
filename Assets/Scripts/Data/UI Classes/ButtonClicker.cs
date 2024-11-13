using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicker : MonoBehaviour
{
    [SerializeField] private ToggleButton AchievementsButton;

    private void Start()
    {
        AchievementsButton.gameObject.SetActive(true);
        AchievementsButton.Toggle.isOn = true;
        AchievementsButton.OnToggle();
    }
}
