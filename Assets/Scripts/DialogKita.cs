using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
public class DialogKita : MonoBehaviour
{
    public static DialogKita instance;
    public DialogManager DialogManager;
    public GameObject objekPrinter;
        public GameObject kuisGo;

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
           
             var TexQuest= new DialogData("Kamu mau quiz?");
            TexQuest.SelectList.Add("Syukurlah","Baik kak");
            TexQuest.SelectList.Add("Semangat","ok deh kak");
                TexQuest.Callback = () =>CekKabar();
                
            dialogTexts.Add(TexQuest);
            
            
          //  CekKabar();
           dialogTexts.Add((new DialogData("Terima kasih infonya","", () => MunculkanJoystik())));
           DialogManager.Show(dialogTexts);
         // GameManagerLatihan.instance.joystickGO.SetActive(true);
        
    }   
     public void BicarasamaNpcRoro()
    {   

        GameManagerLatihan.instance.joystickGO.SetActive(false);
         var dialogTexts = new List<DialogData>();

         dialogTexts.Add(new DialogData("/color:black/Tolong Aku!",""
        // ,() => Show_Example(0)
         ));
             dialogTexts.Add(new DialogData("/color:black/Aku Kehilangan Kapak Peninggalan Ayahku",""));
           
             var TexQuest= new DialogData("/color:black/Maukah Kamu membantuku mencarikannya?");
            TexQuest.SelectList.Add("bantu","Baik, Aku akan membantumu!");
            TexQuest.SelectList.Add("tidak","Maaf aku sibuk.");
                TexQuest.Callback = () =>CekBantuCariKapak();
                
            dialogTexts.Add(TexQuest);
            dialogTexts.Add((new DialogData("/color:black/Terima kasih Sebelumnya","", () => MunculkanJoystikNoquiz())));
           DialogManager.Show(dialogTexts);
        //GameManagerLatihan.instance.joystickGO.SetActive(true);
        
    }   
     void CekBantuCariKapak(){
         
        if(DialogManager.Result=="bantu"){
             var dialogTexts = new List<DialogData>();
             dialogTexts.Add(new DialogData("/color:black/Ah Terimakasih Pemuda","", () =>MunculkanJoystikNoquiz()));
              DialogManager.Show(dialogTexts);
            
        }else  if(DialogManager.Result=="tidak"){
             var dialogTexts = new List<DialogData>();
             dialogTexts.Add(new DialogData("/color:black/Yah, Sayang sekali","", () => MunculkanJoystikNoquiz()));
           //  dialogTexts.
              DialogManager.Show(dialogTexts);
          
              
        }

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
     void MunculkanJoystikNoquiz(){
    
         GameManagerLatihan.instance.joystickGO.SetActive(true);
     }
    void MunculkanJoystik(){
        print("masuk munculkan");
         GameManagerLatihan.instance.joystickGO.SetActive(true);
         kuisGo.SetActive(true);
    }
    private void Show_Example(int index)
    {
        
        Example[index].SetActive(true);
        
    }

}
