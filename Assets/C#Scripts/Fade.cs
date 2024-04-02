using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    GameObject FadeIn;
    GameObject FadeOut;

    public GameObject CurrentLayer;
    public GameObject NextLayer;

    public void FadeAnim()
    {
        if (FadeIn.activeInHierarchy == true && FadeOut.activeInHierarchy==true)
        {
            CurrentLayer.SetActive(false);
            NextLayer.SetActive(true);
            FadeIn.SetActive(false);
            FadeIn.SetActive(false);
        }
        else
        {
            CurrentLayer.SetActive(false);
            NextLayer.SetActive(true);
        }
    }
}
