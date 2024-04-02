using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Quest1 : MonoBehaviour, IPointerClickHandler
{

    public GameObject ItemCurrent;
    public GameObject ItemNext;
    public void OnPointerClick(PointerEventData eventData)
    {
        ItemCurrent.SetActive(false);
        ItemNext.SetActive(true);
    }
}
