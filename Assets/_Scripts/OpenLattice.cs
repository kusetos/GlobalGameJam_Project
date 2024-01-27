using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLattice : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<Animator>().enabled = true;
        }
    }
}
