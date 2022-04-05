using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class based : MonoBehaviour
{
    public static int tabanca,rifle,otorifle;
    public static float para;
    public static float targetTime,targettimer,targettimeo,timeK;
    public Text tabancaT,rifleT,param,tabancasayisi,sexu,otorifleT;
    public  Camera kamera;
    public Canvas basem;
    public GameObject pistolmachine,riflemachine,otoriflemachine;
    // Start is called before the first frame update
   
    void Start()
    {
        rifle = 0;
        basem.gameObject.SetActive(false);
        para = 0;
         targetTime = 1;
        timeK = 1;
        if (PlayerPrefs.HasKey("tabancaK"))
        { 
            tabanca = PlayerPrefs.GetInt("tabancaK");
            para = PlayerPrefs.GetFloat("paraK");
            timeK= PlayerPrefs.GetFloat("targettimeK");
            rifle = PlayerPrefs.GetInt("rifleK");
            otorifle = PlayerPrefs.GetInt("otorifleK");
        }
        else { para = 1000; }

      
       /* timeK = 1;
        tabanca = 1;*/

        Application.runInBackground = true;
        
    para = 1000;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (tabanca == 0)
        {
            pistolmachine.gameObject.SetActive(false);
            tabancasayisi.gameObject.SetActive(false);
            sexu.text = "";
        }
        else
        {
            pistolmachine.gameObject.SetActive(true);
            tabancasayisi.gameObject.SetActive(true);

        }
        if (rifle == 0)
        {
            riflemachine.gameObject.SetActive(false);
            rifleT.gameObject.SetActive(false);
        }
        else { riflemachine.gameObject.SetActive(true);
            rifleT.gameObject.SetActive(true);
        }
       
        if (otorifle == 0)
        {
            otoriflemachine.gameObject.SetActive(false);
            otorifleT.gameObject.SetActive(false);
        }
        else
        {
            otoriflemachine.gameObject.SetActive(true);
            otorifleT.gameObject.SetActive(true);
        }
       
        param.text = "MONEY= " + para;
        if (buyriflemachine.isriflebuy==1) {
            targetTime -= Time.deltaTime;
            if (targetTime <= 0.0f)
            {
                rifle++;
                targetTime = 1;
            
            }

        }
        if (buypistolmachine.ispistolbuy==1) {
            targettimer -= Time.deltaTime;
            if (targettimer <= 0.0f)
            {
                tabanca++;
                targettimer = 1;
            }
        }
        if (buyotoriffle.isotoriflebuy == 1)
        {
            targettimeo -= Time.deltaTime;
            if (targettimeo <= 0.0f)
            {
                otorifle++;
                targettimeo = 1;
            }
        }
        tabancaT.text = ("Pistol= "+tabanca);
        rifleT.text = "Riffle= "+rifle;
        otorifleT.text = "Oto Riffle= " + otorifle;
        kaydetmek();
    }
    void kaydetmek()
    {
        PlayerPrefs.SetInt("tabancaK", tabanca);
        PlayerPrefs.SetFloat("paraK", para);
        PlayerPrefs.SetFloat("targettimeK", timeK);
        PlayerPrefs.SetInt("rifleK", rifle);
        PlayerPrefs.SetInt("otorifleK", otorifle);


    }
}
