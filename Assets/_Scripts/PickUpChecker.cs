using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpChecker : MonoBehaviour
{
    [SerializeField] private GameObject interactionText;
    [SerializeField] private float _interactionRange = 3f;
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, _interactionRange))
        {
            if (hit.collider.gameObject.tag == "canPickUp")
            {
                GameObject door = hit.collider.gameObject;
                interactionText.SetActive(true);

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
}
