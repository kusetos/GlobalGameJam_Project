using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPlayerOnCollision : MonoBehaviour
{
    [SerializeField] private float _damage = 10f;
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

            

        }
        //Start action
        //noise/music, laugh
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
            Debug.Log("give damage");
            other.GetComponent<PlayerHealth>().HealDamage(_damage * Time.deltaTime);

        //give damage per time.    
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            Debug.Log("Trigger ended!!!");
            //stop noise, laugh quiter
    }
}
