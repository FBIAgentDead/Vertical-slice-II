using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FpsOption : MonoBehaviour
{
    public Slider slider;
    
    void Start()
    {
        Application.targetFrameRate = 300;
    }

    public void ChangeFRameRate()
    {
        Application.targetFrameRate = Mathf.FloorToInt(slider.value);
    }
}
