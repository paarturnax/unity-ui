using Data.Matching;
using UnityEngine;

public class InitOverview : MonoBehaviour
{
    [SerializeField] private MatchToggleButton button;

    private void Start()
    {
        button.gameObject.SetActive(true);
        button.Toggle.isOn = true;
        button.OnToggle();
    }
}
