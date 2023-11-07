using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadingStuff : MonoBehaviour
{
    public bool Fading;
    public Text text;
    public float fadeInRate = .1f;
    public void StartFading()
    {
        Fading = true;
    }

    public void FadeOut()
    {
        Fading = false;
    }

    public void Update()
    {
        if(Fading == true && text.GetComponent<CanvasGroup>().alpha != 1f)
        {
            text.GetComponent<CanvasGroup>().alpha += fadeInRate * Time.deltaTime * 8;
        } else if(Fading == false && text.GetComponent<CanvasGroup>().alpha != 0f)
        {
            text.GetComponent<CanvasGroup>().alpha -= fadeInRate * Time.deltaTime * 8;
        }
    }
}
