using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardCamera : MonoBehaviour
{
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.FindAnyObjectByType<Camera>();

    }

    private void Update()
    {
        transform.LookAt(_camera.transform);
        //Quaternion.EulerAngles(_camera.transform.rotation.x, _camera.transform.rotation.y, _camera.transform.rotation.z);
        //transform.rotation = _camera.transform.rotation;       transform.rotation = 

    }

}
