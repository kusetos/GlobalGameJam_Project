using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDoctor : MonoBehaviour
{

    void Update()
    {
        transform.position += Vector3.back * Time.deltaTime * 4f;
        
    }
}
