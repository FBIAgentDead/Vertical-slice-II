using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FpsOption : MonoBehaviour
{
    public Slider slider;
    [SerializeField]
    private Text fpsText;

    void Start()
    {
        Application.targetFrameRate = 300;
    }

    public void ChangeFRameRate()
    {
        Application.targetFrameRate = Mathf.FloorToInt(slider.value);
        fpsText.text = Mathf.RoundToInt(slider.value) + " fps";
    }
}
