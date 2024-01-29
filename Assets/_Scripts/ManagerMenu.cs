using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerMenu : MonoBehaviour
{
    public void GoToGame() => StartCoroutine(LoadLevelNext(1));
    public void ExitToGame() => Application.Quit();


    public void Start()
    {
        Cursor.visible = true; 
        Cursor.lockState = CursorLockMode.None;
    }
    public void LoadLevel(int index)
    {
        StartCoroutine(LoadLevelNext(index));
    }

    IEnumerator LoadLevelNext(int levelIndex)
    {
        yield return new WaitForSeconds(0.1f);

        SceneManager.LoadScene(levelIndex);
    }
}
