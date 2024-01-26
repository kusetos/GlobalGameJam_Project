using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class CubeLevelManager
{
    private static int _filledTiles = 0;
    
    public static void FillTile()
    {
        _filledTiles++;
        Debug.Log(_filledTiles);
        if( _filledTiles == 6)
        {
            Debug.Log("LEVEL PASSED");
            SceneManager.LoadScene(0);
        }
    }

    public static void FreeTile()
    {
        _filledTiles--;
        Debug.Log(_filledTiles);
    }

}
