using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LatihanEvent : MonoBehaviour
{
    public TextMeshProUGUI texDebug;
    public TextMeshProUGUI texDebugFix;
    public TextMeshProUGUI texDebugLate;
    public int counter=0;
     public int counter1=0;
      public int counter2=0;
    // public bool isSiap=false;
    // Start is called before the first frame update
 void OnDestroy()
 {
    texDebug.text = "objek terhapus";
 }
}
