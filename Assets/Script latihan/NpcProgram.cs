using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcProgram : MonoBehaviour
{
   public GameObject objekButtonChat;
    void OnTriggerEnter2D(Collider2D other)
        {
              if(other.gameObject.tag=="Player"){
                objekButtonChat.SetActive(true);
              }
        }
    void OnTriggerExit2D(Collider2D other)
        {
             if(other.gameObject.tag=="Player"){
                objekButtonChat.SetActive(false);
              }
        }
}
