using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ToggleButton : MonoBehaviour
{
    public TMP_Text normal;
    public TMP_Text selected;
    public Image image;

    public Toggle Toggle;

    [SerializeField] private string _text;
    [SerializeField] private GameObject _targetObject;

    [Inject]
    [SerializeField] private ToggleButtonsManager _toggleListener;

    private void OnValidate()
    {
        normal.text = _text;
        selected.text = _text;
    }

    private void OnEnable()
    {
        selected.color -= new Color(0f, 0f, 0f, 1f);
        _toggleListener.ActiveToggleHasChanged += onToggleHasChanged;
    }

    private void onToggleHasChanged(Toggle toggle)
    {
        Toggle.isOn = Toggle == toggle;
    }
    public void OnToggle()
    {
        _targetObject.SetActive(Toggle.isOn);
        if (Toggle.isOn)
        {
            _toggleListener.InvokeEvent(Toggle);
            AnimateActivation();
        }
        else
        {
            AnimateDeactivation();
        }
    }


    private void OnDisable()
    {
        _toggleListener.ActiveToggleHasChanged -= onToggleHasChanged;
    }

    private void AnimateActivation()
    {
        normal.DOFade(0f, 0.1f);
        image.DOFade(1f, 0.3f);
        selected.DOFade(1f, 0.3f);
    }

    private void AnimateDeactivation()
    {
        normal.DOFade(1f, 0.1f);
        image.DOFade(0f, 0.3f);
        selected.DOFade(0f, 0.3f);
    }


}
