using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    [SerializeField] public GameObject interactionText;
    [SerializeField] private float _interactionRange = 3f;

/*    [Header("Rotation stat")]
    [SerializeField] private float _forwardDirection = 0f;

    private Vector3 StartRotation;
    private Vector3 Forward;

    private Coroutine AnimationCoroutine;
*/
    private void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, _interactionRange))
        {
            if(hit.collider.gameObject.tag == "Door")
            {
                GameObject door = hit.collider.gameObject;
                interactionText.SetActive(true);
                
                if(Input.GetKeyDown(KeyCode.E))
                {
                    door.GetComponent<Animator>().enabled = true;
                    door.GetComponent<AudioSource>().enabled = true;

                }
            }
            else
            {
                interactionText.SetActive(false);
            }
        }
        else
        {
            interactionText.SetActive(false);
        }


    }

    //public void Open(Vectro3 )



}
