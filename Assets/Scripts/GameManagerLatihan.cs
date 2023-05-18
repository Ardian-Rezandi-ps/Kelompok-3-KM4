using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerLatihan : MonoBehaviour
{
    public static GameManagerLatihan instance;
    public GameObject joystickGO;
    public GameObject[] hadiahInventori;
    void Awake()
    {
        instance=this;
    }


}
