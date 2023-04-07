using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class TopDownCharacterController : MonoBehaviour
    {
        public float speed;
         public VariableJoystick variableJoystick;
        private Animator animator;

        public Collider2D colliderPlayer;
        private void Start()
        {
            animator = GetComponent<Animator>();
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if(other.gameObject.tag=="npc"){
               // DialogKita.instance.BicarasamaNpcBurung();
            }
        }
        
        private void FixedUpdate()
        {

            animator.SetFloat("movX",variableJoystick.Horizontal);
            animator.SetFloat("movY",variableJoystick.Vertical);
            Vector2 joystikV2= new Vector2(variableJoystick.Horizontal,variableJoystick.Vertical);
            animator.SetFloat("speed",joystikV2.sqrMagnitude);
             GetComponent<Rigidbody2D>().velocity = speed * joystikV2;
           
        }
    }
}
