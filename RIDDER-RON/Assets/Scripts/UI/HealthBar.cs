using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [field:SerializeField]
    public int MaxValue { get; private set; }
    [field:SerializeField]
    public int Value { get; private set; }

    [SerializeField] 
    private RectTransform _topBar;

    [SerializeField] 
    private RectTransform _bottomBar;

    [SerializeField] 
    private float _animationSpeed = 10f;
    
    private float _fullWidth;
    private float TargetWidth => Value * _fullWidth / MaxValue;

    private Coroutine _adjustBarWidthCoroutine;
    private void Start()
    {
        _fullWidth = _topBar.rect.width;
    }
    
    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Change(20);
        }

        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            Change(-20);
        }
    }


    private IEnumerator AdjustBarWidth(int amount)
    {
        var suddenChangeBar = amount >= 0 ? _bottomBar : _topBar;
        var slowChangeBar = amount >= 0 ? _topBar : _bottomBar;
        suddenChangeBar.SetWidth(TargetWidth);
        while (Mathf.Abs(suddenChangeBar.rect.width - slowChangeBar.rect.width) > 1f)
        {
            slowChangeBar.SetWidth(
                Mathf.Lerp(slowChangeBar.rect.width, TargetWidth, Time.deltaTime * _animationSpeed));
            yield return null;
        }
        slowChangeBar.SetWidth(TargetWidth);
    }
    
    
    public void Change(int amount)
    {
        Value = Mathf.Clamp(Value + amount, 0, MaxValue);
        if (_adjustBarWidthCoroutine != null)
        {
            StopCoroutine(_adjustBarWidthCoroutine);
        }

        _adjustBarWidthCoroutine = StartCoroutine(AdjustBarWidth(amount));
    }
}
