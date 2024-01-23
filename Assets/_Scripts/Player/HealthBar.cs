using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Gradient _gradient;
    [SerializeField] private Image _fill;

    public void InitMaxHealth(float health)
    {
        _slider.value = 0;
        _slider.maxValue = health;
        _fill.color = _gradient.Evaluate(0);
        
    }

    public void SetHealth(float health)
    {
        _slider.value = health;
        _fill.color = _gradient.Evaluate(health / 100.0f);

    }

}
