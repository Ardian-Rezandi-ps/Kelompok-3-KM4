using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AudioManager : MonoBehaviour
{
   public AudioSource speakerBGM;
   [SerializeField] Slider sliderBgmSetting;

    void Start()
    {
        if(PlayerPrefs.HasKey("bgmvolume")){
         sliderBgmSetting.value= PlayerPrefs.GetFloat("bgmvolume");
        BgmVolEditSlider();
          }
       
    }
   public void BgmVolEditSlider(){
        speakerBGM.volume = sliderBgmSetting.value;
        PlayerPrefs.SetFloat("bgmvolume",sliderBgmSetting.value);
   }


}
