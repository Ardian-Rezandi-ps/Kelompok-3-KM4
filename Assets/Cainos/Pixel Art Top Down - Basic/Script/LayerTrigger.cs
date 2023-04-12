using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    //when object exit the trigger, put it to the assigned layer and sorting layers
    //used in the stair objects for player to travel between layers
    public class LayerTrigger : MonoBehaviour
    {
       
        public int sortingLayerEnter;
      
        public int sortingLayerExit;
         private void OnTriggerEnter2D(Collider2D other)
        {
            if(other.gameObject.tag=="Player"){
               other.GetComponent<SpriteRenderer>().sortingOrder= sortingLayerEnter;
            }
          
        }

        private void OnTriggerExit2D(Collider2D other)
        { 
            if(other.gameObject.tag=="Player"){
            other.GetComponent<SpriteRenderer>().sortingOrder= sortingLayerExit;
        }

        }
           
    }
}
