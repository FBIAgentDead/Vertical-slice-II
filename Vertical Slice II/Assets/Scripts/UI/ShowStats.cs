using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShowStats : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    public Image statUI;

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        statUI.enabled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        statUI.enabled = false;

        //particles poof

    }
}
