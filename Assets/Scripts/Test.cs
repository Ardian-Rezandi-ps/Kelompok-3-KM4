using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Test : MonoBehaviour
{
    public TextMeshProUGUI namatx;
    public string namaUser="Ardian";
    void Start()
    {
        namatx.text=namaUser;
    }
}
