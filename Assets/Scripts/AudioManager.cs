using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AudioManager : MonoBehaviour
{
   public AudioSource speakerBGM;
   public List<AudioSource> semuaSfxSpeaker;
   public AudioSource suaraKlikSpeakersfx,suaraKlikSpeakerBgm;
   [SerializeField] Slider sliderBgmSetting;
   [SerializeField] Slider sliderSFXSetting;
    void Start()
    {
      GameObject[] objekSfx= GameObject.FindGameObjectsWithTag("sfx");
      for(int i=0;i<objekSfx.Length;i++){
         semuaSfxSpeaker.Add(objekSfx[i].GetComponent<AudioSource>());
      }
      //mengecek apakah ada data dengan nama bgmvolume di dalam sebuah game(save data)
        if(PlayerPrefs.HasKey("bgmvolume")){
         //ada data dengan nama bgmvolume
         sliderBgmSetting.value= PlayerPrefs.GetFloat("bgmvolume");
         //load data bgm vol ke slider
        BgmVolEditSlider();
          }
       
       //mengecek apakah ada data dengan nama sfxvolume di dalam sebuah game(save data)
        if(PlayerPrefs.HasKey("sfxvolume")){
         //ada data dengan nama bgmvolume
         sliderSFXSetting.value= PlayerPrefs.GetFloat("sfxvolume");
         //load data bgm vol ke slider
        BgmVolEditSlider();
          }
    }
  public void SfxVolEditSlider(){
      suaraKlikSpeakersfx.Play();
      //0-1
       for(int i=0;i<semuaSfxSpeaker.Count;i++){
         semuaSfxSpeaker[i].volume = sliderSFXSetting.value;

      }

        //save data volume bgm sesuai nilai slider 
        PlayerPrefs.SetFloat("sfxvolume",sliderSFXSetting.value);
   }
   public void BgmVolEditSlider(){
       suaraKlikSpeakerBgm.Play();
      //0-1
        speakerBGM.volume = sliderBgmSetting.value;
        //save data volume bgm sesuai nilai slider 
        PlayerPrefs.SetFloat("bgmvolume",sliderBgmSetting.value);
   }


}
