using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideWithCheese : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("EZ Maze");
        SceneManager.LoadScene(2);
    }
}
