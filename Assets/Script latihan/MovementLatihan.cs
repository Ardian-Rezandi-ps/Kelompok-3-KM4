using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementLatihan : MonoBehaviour
{
   public float movspeed= 20;
    // Update is called once per frame
    void Update()
    {
          //untuk Android/Button
        if(isPencetAtas){
            transform.Translate(0,movspeed*Time.deltaTime,0);
        }
         if(isPencetKiri){
             transform.Translate(-movspeed*Time.deltaTime,0,0);
        }
         if(isPencetBawah){
            transform.Translate(0,-movspeed*Time.deltaTime,0);
        }
         if(isPencetKanan){
            transform.Translate(movspeed*Time.deltaTime,0,0);
        }

        //untuk Keyboard/PC
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(0,movspeed*Time.deltaTime,0);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(-movspeed*Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(movspeed*Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(0,-movspeed*Time.deltaTime,0);
        }
    }
    bool isPencetAtas=false;
    bool isPencetKiri=false;
    bool isPencetKanan=false;
    bool isPencetBawah=false;
    public void AtasButton(bool isPencet){
        isPencetAtas=isPencet;
    }
     public void KiriButton(bool isPencet){
        isPencetKiri=isPencet;
    }
     public void KananButton(bool isPencet){
        isPencetKanan=isPencet;
    }
     public void BawahButton(bool isPencet){
       isPencetBawah=isPencet;
    }
}
