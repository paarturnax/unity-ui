using Data;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Achievement : MonoBehaviour
{
    [SerializeField] private TMP_Text _nameText;
    [SerializeField] private TMP_Text _dateText;
    [SerializeField] private Image _image;

    private string _name;
    private string _date;
    private string _icon;

    public void Initialize(AchievementData data)
    {
        _nameText.text = _name = data.Name;
        _dateText.text = _date = $"Completed on {data.CompletedOn.ToString()}";
        _image.sprite = Resources.Load<Sprite>($"Icons/{data.Icon}");
    }

    private void OnDisable()
    {
        Destroy(gameObject);
    }
}
