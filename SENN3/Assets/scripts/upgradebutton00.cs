using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgradebutton00 : MonoBehaviour
{
    int a1 ,a2,a3;
    public GameObject star0,star1,star2;
    // Start is called before the first frame update
    void Start()
    {
        star0.gameObject.SetActive(false);
        star1.gameObject.SetActive(false);
        star2.gameObject.SetActive(false);
        a1 = 0;
        a2 = 0;
        a3 = 0;
        if (PlayerPrefs.HasKey("a1"))
        {
           a1= PlayerPrefs.GetInt("a1");
            a2 = PlayerPrefs.GetInt("a2");
            a3 = PlayerPrefs.GetInt("a3");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (a1==1&a2==1&a3==1) { star0.gameObject.SetActive(true); star1.gameObject.SetActive(true); star2.gameObject.SetActive(true); }
        if (a1 == 1 & a2 == 1 ) { star0.gameObject.SetActive(true); star1.gameObject.SetActive(true); }
        if (a1 == 1 ) { star0.gameObject.SetActive(true); }
        PlayerPrefs.SetInt("a1",a1);
        PlayerPrefs.SetInt("a2", a2);
        PlayerPrefs.SetInt("a3", a3);
    }
    private void OnMouseUpAsButton()
    {
        if (based.tabanca >= 1) 
       {
            if (a1 == 0)
            {
            if (based.para >= 100) {

                based.para = based.para - 100;
                sellbuttonsc.boost = 4;
                a1 = 1;
                    star0.gameObject.SetActive(true);
            }
        }
            if (a2 == 0)
            {
                if (based.para >= 450)
                {

                    based.para = based.para - 450;
                    sellbuttonsc.boost = 5;
                    a2 = 1;
                    star1.gameObject.SetActive(true);
                }
            }
            if (a3 == 0)
            {
                if (based.para >= 3000)
                {

                    based.para = based.para - 1000;
                    sellbuttonsc.boost = 10;
                    a3 = 1;
                    star2.gameObject.SetActive(true);
                }
            }
        }
    }
}
