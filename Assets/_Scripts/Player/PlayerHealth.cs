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

    private void Start()
    {
        _healthBar.InitMaxHealth(_maxHealth);
        
        _currentHealth = 0;
    }
    
    public void HealDamage(float heal)
    {
        _currentHealth -= heal;
        _healthBar.SetHealth(_currentHealth);
    }    
    public void ReduseDamage(float damage)
    {
        _currentHealth += damage;
        _healthBar.SetHealth(_currentHealth);
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.F))
        {
            HealDamage(25f);
        }
        ReduseDamage(_damage * Time.deltaTime);
        
    }
}
