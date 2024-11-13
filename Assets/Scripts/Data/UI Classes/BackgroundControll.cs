using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControll : MonoBehaviour
{
    [SerializeField] private float _initialWigth = 1920f;
    [SerializeField] private float _initialHeight = 1080f;
    private float _initialRatio;
    private float _targetRatio;
    private float _requiredScaling;

    private void WindowScaling()
    {
        _initialRatio = _initialWigth / _initialHeight;
        _targetRatio = (float)Screen.currentResolution.width / (float)Screen.currentResolution.height;

        _requiredScaling = _targetRatio / _initialRatio;
        
        if (_requiredScaling > 1f)
            transform.localScale = new Vector3(_requiredScaling, _requiredScaling, 1);
    }

    [ContextMenu("upscale")]
    private void OnEnable()
    {
        WindowScaling();
    }
}
