using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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

    private AudioManager _audioManager;

    private bool firstStage = false;
    private bool secondStage = false;
    private bool thirdStage = false;

    private float stageTimer;


    private void Start()
    {
        //bool wasStupid = false;
        stageTimer = 0f;

        _healthBar.InitMaxHealth(_maxHealth);
        
        _currentHealth = 0;
        _audioManager = FindObjectOfType<AudioManager>();
    }

    private void changeSoundState(SoundState state)
    {
        switch (state)
        {
            case SoundState.BOY:
                _audioManager.Play("BoyLaugh");
                thirdStage = true;
                stageTimer = 0f;
                break;
            case SoundState.MANIAC:
                _audioManager.Play("ManiacalLaugh");
                break;
            case SoundState.REALISTIC:
                _audioManager.Play("RealisticLaugh");
                secondStage = true;
                stageTimer = 0f;
                break;
            case SoundState.SCREAM:
                _audioManager.Play("Scream");
                break;
            case SoundState.STUPID:
                _audioManager.Play("StupidLaugh");
                firstStage = true;
                break;
            case SoundState.MAN:
                _audioManager.Play("ManLaugh");
                break;
            case SoundState.LONG:
                _audioManager.Play("LongLaugh");
                break;
            default:
                break;
        }

    }


    private void Update()
    {

        //first stage
        if(_currentHealth >= 10 && firstStage == false)
        {
            changeSoundState(SoundState.STUPID);
            
        }

        //second stage
        if( _currentHealth >= 25 && secondStage == false)
        {
            //realistic -> man
            if(stageTimer == 0)
            {
                changeSoundState(SoundState.MAN);
            }
            stageTimer += Time.deltaTime;
            if(stageTimer >= 5f)
            {
                changeSoundState(SoundState.REALISTIC);
            }

        }

        //third stage
        if(_currentHealth >= 50 && thirdStage == false)
        {
            if(stageTimer == 0)
            {
                changeSoundState(SoundState.LONG);
            }
            stageTimer += Time.deltaTime;
            if( stageTimer >= 10f)
            {
                changeSoundState (SoundState.BOY);
            }

        }



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

            if (_currentHealth <= 5) firstStage = false;
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
public enum SoundState
{
    BOY,
    MANIAC,
    REALISTIC,
    SCREAM,
    STUPID,
    MAN,
    LONG
}