using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreanFader : MonoBehaviour
{
    [SerializeField] private float _fadeSpeed;

    IEnumerator Start()
    {
        Image fadeImage = GetComponent<Image>();
        Color color = fadeImage.color;

        while(color.a < 1f)
        {
            color.a += _fadeSpeed * Time.deltaTime;
            fadeImage.color = color;
            yield return null;
        }
        
    }
}
