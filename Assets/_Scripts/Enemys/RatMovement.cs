using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RatMovement : MonoBehaviour
{
    [SerializeField] private GameObject[] _targets;
    [SerializeField] private float _speed;
    private int index = 0;
    private Vector3 newTarget;
    void Start()
    {
        //targets = new List<Transform>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, _targets[index].transform.position) <= 0.001f)
        {
            index++;
            if(index >= _targets.Count())
            {
                index = 0;
            }

        }
        TurnToTarget();
        

        transform.position = Vector3.MoveTowards(transform.position, _targets[index].transform.position, _speed * Time.deltaTime);

        
    }
    private void TurnToTarget()
    {
            transform.LookAt(newTarget); // = Quaternion.LookRotation(targets[_index].position);
        //transform.rotation =  Quaternion.Euler(0f, 90f, 0f);
        newTarget = Vector3.Lerp(newTarget, _targets[index].transform.position, 2f * Time.deltaTime);
    }
}
