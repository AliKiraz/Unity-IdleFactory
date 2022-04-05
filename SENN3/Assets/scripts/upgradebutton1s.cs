using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgradebutton1s : MonoBehaviour
{
    int b1, b2, b3;
    public GameObject star0, star1, star2;
    // Start is called before the first frame update
    void Start()
    {
        star0.gameObject.SetActive(false);
        star1.gameObject.SetActive(false);
        star2.gameObject.SetActive(false);
        b1 = 0;
        b2 = 0;
        b3 = 0;
        if (PlayerPrefs.HasKey("b1"))
        {
            b1 = PlayerPrefs.GetInt("b1");
            b2 = PlayerPrefs.GetInt("b2");
            b3 = PlayerPrefs.GetInt("b3");
        }
     
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (b1 == 1 & b2 == 1 & b3 == 1) { star0.gameObject.SetActive(true); star1.gameObject.SetActive(true); star2.gameObject.SetActive(true); }
        if (b1 == 1 & b2 == 1 ) { star0.gameObject.SetActive(true); star1.gameObject.SetActive(true); }
        if (b1 == 1 ) { star0.gameObject.SetActive(true); }
        PlayerPrefs.SetInt("b1", b1);
        PlayerPrefs.SetInt("b2", b2);
        PlayerPrefs.SetInt("b3", b3);
    }
    private void OnMouseUpAsButton()
    {
        if (based.rifle >= 1)
        {
            if (b1 == 0)
            {
                if (based.para >= 2000)
                {

                    based.para = based.para - 2000;
                    sellriffle.boostr = 45;
                    b1 = 1;
                    star0.gameObject.SetActive(true);
                }
            }
            if (b2 == 0)
            {
                if (based.para >= 10000)
                {

                    based.para = based.para - 10000;
                    sellriffle.boostr = 70;
                    b2 = 1;
                    star1.gameObject.SetActive(true);
                }
            }
            if (b3 == 0)
            {
                if (based.para >= 15000)
                {

                    based.para = based.para - 15000;
                    sellriffle.boostr = 200;
                    b3 = 1;
                    star2.gameObject.SetActive(true);
                }
            }
        }
    }
}
