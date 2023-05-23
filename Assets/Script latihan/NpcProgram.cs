using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcProgram : MonoBehaviour
{
    public SpriteRenderer spriteNpc;
    public Sprite hadapkanan,hadapkiri,hadapbawah,hadapatas;
   public GameObject objekButtonChat;
   [SerializeField]PlayerMainManager player;
  void Start()
  {
    player= PlayerMainManager.instance;
  }
   public void HadapkePlayer(){

   print("hadap");
   float selisihx= Mathf.Abs(transform.position.x-player.transform.position.x);
   float selisihy= Mathf.Abs(transform.position.y-player.transform.position.y);
   if(selisihx > selisihy){
      if(transform.position.x < player.transform.position.x){
       // player.controlscrip.animator.SetFloat("movX",1);
      spriteNpc.sprite= hadapkanan;
    }else  if(transform.position.x> player.transform.position.x){
       spriteNpc.sprite= hadapkiri;
     //  player.controlscrip.animator.SetFloat("movX",-1);
    }
   }else{
      if(transform.position.y< player.transform.position.y){
       //  player.controlscrip.animator.SetFloat("movY",1);
      spriteNpc.sprite= hadapatas;
    }else  if(transform.position.y> player.transform.position.y){
       spriteNpc.sprite= hadapbawah;
        //   player.controlscrip.animator.SetFloat("movY",-1);
    }
   }
   
   
   }
    void OnTriggerEnter2D(Collider2D other)
        {
              if(other.gameObject.tag=="Player"){
                print("enter");
             
                objekButtonChat.SetActive(true);
              }
        }

        void OnTriggerStay2D(Collider2D other)
        {
          if(other.gameObject.tag=="Player"){
              
                HadapkePlayer();
              
              }
        }
    void OnTriggerExit2D(Collider2D other)
        {
             if(other.gameObject.tag=="Player"){
             
                objekButtonChat.SetActive(false);
              }
        }
}
