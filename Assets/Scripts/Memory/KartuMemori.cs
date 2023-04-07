using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KartuMemori : MonoBehaviour
{
    public Sprite spriteImg;
    public Image icon;
    public bool isTerbuka=false;
    public int indeksKartu=0;
    // Start is called before the first frame update
    public void OpenKartu(){
        if(!isTerbuka && (MemoryManager.instance.jumlahTerbukaSementara<=2)){
            isTerbuka=true;
              icon.gameObject.SetActive(true);
              MemoryManager.instance.CekKartuTerbuka(this);
             
        }else  if(!isTerbuka){
          
                MemoryManager.instance.ResetKartuAb();
                   isTerbuka=true;
                    icon.gameObject.SetActive(true);
                 MemoryManager.instance.CekKartuTerbuka(this);
              }
        
      
    }
    public void TutupKartu(){
        isTerbuka=false;
          icon.gameObject.SetActive(false);
    }
  
}
