using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AnimatedButton : MonoBehaviour, IDeselectHandler
{
    [SerializeField] private TMP_Text normal;
    [SerializeField] private TMP_Text selected;
    [SerializeField] private Image image;

    [SerializeField] private Color _normalColor;
    [SerializeField] private Color _selectedColor;

    [SerializeField] private float _transitionTime = 0.4f;

   // private void OnEnable()
   // {
   //     selected.color = new Color(_selectedColor.r, _selectedColor.g, _selectedColor.b, 0f);
   //     image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
   // }
   //
   // public void HighlightenText()
   // {
   //     normal.DOFade(0f, 0.1f);
   //     image.DOFade(1f, _transitionTime);
   //     selected.DOFade(1f, _transitionTime);
   // }

    public void OnDeselect(BaseEventData data)
    {
        normal.DOFade(1f, 0.1f);
        image.DOFade(0f, _transitionTime);
        selected.DOFade(0f, _transitionTime);
    }  
}
