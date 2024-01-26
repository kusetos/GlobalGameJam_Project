using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithCube : MonoBehaviour
{
    [SerializeField] private string cubeName;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == cubeName)
        {
            Debug.Log(cubeName + " CUBE ENTRERED");
            CubeLevelManager.FillTile();

        }
    }
    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.name == cubeName)
        {
            Debug.Log(cubeName + " CUBE EXIT");
            CubeLevelManager.FreeTile();
        }
    }

}
