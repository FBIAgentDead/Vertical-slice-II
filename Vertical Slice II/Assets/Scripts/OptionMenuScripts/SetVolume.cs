using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour {
    [SerializeField]
    private Text musicText;
    [SerializeField]
    private Text soundText;
    public AudioMixer mixer;
    [SerializeField]
    private Slider getVolume;

    private void Start()
    {

    }

    public void SetLevel(float sliderValue)
    {
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
        musicText.text = Mathf.RoundToInt(sliderValue * 100) + "%";
    }

    //private void Update()
    //{
    //    SetLevel(getVolume.value);
    //}

    public void SetLevel2(float sliderValue)
    {
        mixer.SetFloat("SoundVol", Mathf.Log10(sliderValue) * 20);
        soundText.text = Mathf.RoundToInt(sliderValue * 100) + "%";
    }

}
