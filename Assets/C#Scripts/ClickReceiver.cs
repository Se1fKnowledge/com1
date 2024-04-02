using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ClickReceiver : MonoBehaviour, IPointerClickHandler
{

    public GameObject DialogueBox;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (DialogueBox.activeInHierarchy == false)
        {
            DialogueBox.SetActive(true);
        }
    }
    
}
