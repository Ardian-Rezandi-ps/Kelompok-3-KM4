using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  Cainos.PixelArtTopDown_Basic;
public class PlayerMainManager : MonoBehaviour
{
    public static PlayerMainManager instance;
    public TopDownCharacterController controlscrip;
    // Start is called before the first frame update
    void Start()
    {
      instance=this;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
