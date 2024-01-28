using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
                    if (hit.collider.gameObject.name == "ColliderCar")
                    {
                        Invoke("TheEnd", 0.5f);
                        return;
                    }

                    door.GetComponent<Animator>().enabled = true;
                    door.GetComponent<AudioSource>().enabled = true;

                    if (hit.collider.gameObject.name == "DoorExit")
                    {
                        Invoke("ExitScene", 1f);
                    }
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

    private void ExitScene()
    {
        SceneManager.LoadScene(5);
    }

    private void TheEnd()
    {
        SceneManager.LoadScene(6);
    }


    //public void Open(Vectro3 )



}
