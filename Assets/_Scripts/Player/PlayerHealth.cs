using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    [Header("Player Stats")]
    [SerializeField] private float _maxHealth = 100f;
    [SerializeField] private float _damage = 1f;
    private float _currentHealth;

    [Header("")]
    [SerializeField] private HealthBar _healthBar;
    private bool _isHealing = false;

    private void Start()
    {
        _healthBar.InitMaxHealth(_maxHealth);
        
        _currentHealth = 0;
    }

    private void Update()
    {
        if (!_isHealing)
        {
            ReduseDamage(_damage * Time.deltaTime);
        }

            
    }
     
    public void SetIsHealing(bool isHealing)
    {
        _isHealing = isHealing;
    }
    public void HealPlayer(float heal)
    {
        if(_currentHealth >= 0)
        {
            _currentHealth -= heal;
            _healthBar.SetHealth(_currentHealth);
        }
    }    
    public void ReduseDamage(float damage)
    {
        if(_currentHealth <= 100.0f)
        {
            _currentHealth += damage;
            _healthBar.SetHealth(_currentHealth);
        }
    }

}