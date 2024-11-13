using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrivingPanel : MonoBehaviour
{
    
    [SerializeField] private Image panel;
    [SerializeField] private Transform start;
    [SerializeField] private Transform finish;

    private void OnEnable()
    {
        //panel.color = new Color(0f, 0f, 0f,0.5f);
        panel.transform.position = start.position;
        panel.transform.DOMove(finish.position, 0.2f);
        //panel.DOFade(1f, 0.2f);
    }

    [ContextMenu("func")]
    public void OnClose()
    {
        StartCoroutine(FadeThenDisable());
    }

    public IEnumerator FadeThenDisable()
    {
        panel.DOFade(0f, 0.2f);
        yield return new WaitForSeconds(0.2f);
        print("hey");
        
    }
}
