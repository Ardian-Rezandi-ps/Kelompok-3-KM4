using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SistemInventori : MonoBehaviour
{   
    public static SistemInventori instance;
    public  TextMeshProUGUI namaItemTex;
     public  TextMeshProUGUI deskripsiItemTex;
     public List<ItemInventory> semuaItemDipunya;
     public Transform tempatHadiah;

     void Start(){
         UnselectAllItem();
            instance=this;
         GameObject[] objekitem= GameObject.FindGameObjectsWithTag("inventori");
         for(int i=0;i<objekitem.Length;i++){
         semuaItemDipunya.Add(objekitem[i].GetComponent<ItemInventory>());
        }
     }
     public void TambahItem(GameObject go){
        Instantiate(go,tempatHadiah);
     }
    public void SelectAnItem(string nama, string deskripsi){
                UnselectAllItem();
            namaItemTex.text= nama;
            deskripsiItemTex.text=deskripsi;
    }
    void UnselectAllItem(){
          for(int i=0;i<semuaItemDipunya.Count;i++){
         semuaItemDipunya[i].DeSelectItem();
        }
     }
   
}
