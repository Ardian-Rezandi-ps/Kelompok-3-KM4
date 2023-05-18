using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class QuizManager : MonoBehaviour
{
    public TextMeshProUGUI soalTex;
       public TextMeshProUGUI judulKuis;
       public SoalJawab[] soaljawabArray;

       public string[] pilihanGanda;
        public TextMeshProUGUI[] pilGandaUitx;
       public int indexSoal=0;
       public int kunciJawabanSekarang;
       public GameObject benarSalahUi;
         public GameObject kuisSelesaiUi;
              public GameObject buttnRetry;
            public TextMeshProUGUI kuisSelesaiTx;
       public int maxJumlahSoal=3;
       public int skorBenar=0;

         public TextMeshProUGUI benarSalahTx;
    // Start is called before the first frame update
    void Start()
    {
        GenerateSoal();
    }
    void GenerateSoal(){
        soalTex.text = soaljawabArray[indexSoal].soal;
        pilihanGanda = soaljawabArray[indexSoal].pilihanGanda;
        kunciJawabanSekarang=soaljawabArray[indexSoal].kuncijawaban;
        for(int i=0;i< pilihanGanda.Length;i++){
         pilGandaUitx[i].text=  pilihanGanda[i];
        }
    }
    public void KlikPilihanGanda(int indexJawab){
        benarSalahUi.gameObject.SetActive(true);
        indexSoal++;
        if(indexJawab == kunciJawabanSekarang){
            benarSalahTx.text="Jawaban Benar!";
            skorBenar++;
            //benar
        }else{
            //salah
            
            benarSalahTx.text="Jawaban Salah!";
        }
    }

    public void SetelahMenjawab(){

        if(indexSoal < maxJumlahSoal){
            //next soal
            GenerateSoal();
        }else{
            kuisSelesaiUi.SetActive(true);
            if(skorBenar == maxJumlahSoal){
                kuisSelesaiTx.text="Selamat Kuis Selesai dengan jawaban Benar semua!";
                buttnRetry.SetActive(false);
                //dapat hadiah/menang
                SistemInventori.instance.TambahItem(GameManagerLatihan.instance.hadiahInventori[0]);
            }else{
                 kuisSelesaiTx.text="Maaf terdapat soal dengan jawaban yang salah, coba lagi?";
                 buttnRetry.SetActive(true);
            }
            //Kuis selesai
        }
    }
    public void Retry(){
         kuisSelesaiUi.SetActive(false);
      benarSalahUi.SetActive(false);  
        indexSoal=0;
        skorBenar=0;
        GenerateSoal();
    }
   
}
