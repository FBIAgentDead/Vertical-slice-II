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

    IEnumerator MoveImage()
    {
        while (statUI.enabled)
        {
            SetImagePos();
            yield return null;
        }
    }

    private void SetImagePos()
    {
        /*
        Vector2 movePos;

        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            parentCanvas.transform as RectTransform,
            Input.mousePosition, parentCanvas.worldCamera,
            out movePos);

        //statUI.transform.position = parentCanvas.transform.TransformPoint(movePos);
    */
        Vector3 offset = new Vector3(50, 40, 0);
        statUI.transform.position = Input.mousePosition + offset;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        statUI.transform.position = eventData.position;
        statUI.enabled = true;
        StartCoroutine(MoveImage());
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        statUI.enabled = false;

        //particles poof
    }
}
