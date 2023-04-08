using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PindahScene : MonoBehaviour
{
   public string namaScenePindah;

        public void PindahSceneKe(){
            SceneManager.LoadSceneAsync(namaScenePindah);
        }
}
