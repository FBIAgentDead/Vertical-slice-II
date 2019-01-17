using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HoveringImage : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    public Image statUI;
    public Canvas parentCanvas;

    void Start()
    {
        Vector2 pos;

        RectTransformUtility.ScreenPointToLocalPointInRectangle(parentCanvas.transform as RectTransform, Input.mousePosition, parentCanvas.worldCamera, out pos);
    }

    void Update()
    {
        SetImagePos();
    }

    private void SetImagePos()
    {
        Vector2 movePos;

        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            parentCanvas.transform as RectTransform,
            Input.mousePosition, parentCanvas.worldCamera,
            out movePos);

        statUI.transform.position = parentCanvas.transform.TransformPoint(movePos);
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
