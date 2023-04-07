using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pointertest : MonoBehaviour
{
    public Text debug;
    public void PoinUp(){
        debug.text= "Lepas button";
    }
     public void PoinDown(){
        debug.text= "Tahan button";
    }
}
