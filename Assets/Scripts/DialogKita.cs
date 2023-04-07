using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
public class DialogKita : MonoBehaviour
{
    public static DialogKita instance;
    public DialogManager DialogManager;
    public GameObject objekPrinter;
    public GameObject[] Example;

    void Awake()
    {
        instance=this;
    }
    void Update()
    {
     // if(!objekPrinter.activeSelf){
       //   GameManagerLatihan.instance.joystickGO.SetActive(true);
   //   }
    }
    public void BicarasamaNpcBurung()
    {
        GameManagerLatihan.instance.joystickGO.SetActive(false);
         var dialogTexts = new List<DialogData>();

         dialogTexts.Add(new DialogData("/color:black/Welcome To /size:up/Mentoring",""
        // ,() => Show_Example(0)
         ));
             dialogTexts.Add(new DialogData("Ini /color:black/latihan Dialog","Sa"));
           
             var TexQuest= new DialogData("Apa kabar?");
            TexQuest.SelectList.Add("Syukurlah","Baik kak");
            TexQuest.SelectList.Add("Semangat","Sedih kak");
                TexQuest.Callback = () =>CekKabar();
                
            dialogTexts.Add(TexQuest);
            
            
          //  CekKabar();
           dialogTexts.Add((new DialogData("Terima kasih infonya","", () => MunculkanJoystik())));
           DialogManager.Show(dialogTexts);
         // GameManagerLatihan.instance.joystickGO.SetActive(true);
        
    }   
    void CekKabar(){
         
        if(DialogManager.Result=="Syukurlah"){
             var dialogTexts = new List<DialogData>();
             dialogTexts.Add(new DialogData("Oh Syukurlah","Sa", () => MunculkanJoystik()));
              DialogManager.Show(dialogTexts);
            
        }else  if(DialogManager.Result=="Semangat"){
             var dialogTexts = new List<DialogData>();
             dialogTexts.Add(new DialogData("Tetap semangat!","Sa", () => MunculkanJoystik()));
           //  dialogTexts.
              DialogManager.Show(dialogTexts);
          
              
        }
    }
    void MunculkanJoystik(){
        print("masuk munculkan");
         GameManagerLatihan.instance.joystickGO.SetActive(true);
    }
    private void Show_Example(int index)
    {
        
        Example[index].SetActive(true);
        
    }

}
