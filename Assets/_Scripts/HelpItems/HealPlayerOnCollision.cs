using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPlayerOnCollision : MonoBehaviour
{
    [SerializeField] private float _healSpeed = 10f;
    [SerializeField] private float _maxHealTime = 10f;

    private PlayerHealth _health;

    private void Start()
    {
        Debug.Log("sdfsdf");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Player Triggered");
            other.GetComponent<PlayerHealth>().SetIsHealing(true);

            

        }
        //Start action
        //noise/music, laugh
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Player")
        {

            if (_maxHealTime >= 0f)
            {
                Debug.Log("give damage");
                other.GetComponent<PlayerHealth>().HealPlayer(_healSpeed * Time.deltaTime);
                _maxHealTime -= Time.deltaTime;
            }
            else
            {
                Destroy(this.gameObject, 1f);
            }
        }
        //give damage per time.                                 ;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Trigger ended!!!");
            other.GetComponent<PlayerHealth>().SetIsHealing(false);
            //other.GetComponent<PlayerHealth>().ChangeHealState(HealState.DAMAGING);

        }
        //stop noise, laugh quiter
    }
}
