using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgradebutton2 : MonoBehaviour
{
    int c1, c2, c3;
    public GameObject star0, star1, star2;
    // Start is called before the first frame update
    void Start()
    {
        star0.gameObject.SetActive(false);
        star1.gameObject.SetActive(false);
        star2.gameObject.SetActive(false);
        c1 = 0;
        c2 = 0;
        c3 = 0;
        if (PlayerPrefs.HasKey("c1"))
        {
            c1 = PlayerPrefs.GetInt("c1");
            c2 = PlayerPrefs.GetInt("c2");
            c3 = PlayerPrefs.GetInt("c3");
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (c1 == 1 & c2 == 1 & c3 == 1) { star0.gameObject.SetActive(true); star1.gameObject.SetActive(true); star2.gameObject.SetActive(true); }
        if (c1 == 1 & c2 == 1) { star0.gameObject.SetActive(true); star1.gameObject.SetActive(true); }
        if (c1 == 1) { star0.gameObject.SetActive(true); }
        PlayerPrefs.SetInt("c1", c1);
        PlayerPrefs.SetInt("c2", c2);
        PlayerPrefs.SetInt("c3",c3);
    }
    private void OnMouseUpAsButton()
    {
        if (based.rifle >= 1)
        {
            if (c1 == 0)
            {
                if (based.para >= 20000)
                {

                    based.para = based.para - 20000;
                    sellotoriffle.boosto = 500;
                    c1 = 1;
                    star0.gameObject.SetActive(true);
                }
            }
            if (c2 == 0)
            {
                if (based.para >= 70000)
                {

                    based.para = based.para - 70000;
                    sellotoriffle.boosto = 950;
                    c2 = 1;
                    star1.gameObject.SetActive(true);
                }
            }
            if (c3 == 0)
            {
                if (based.para >= 100000)
                {

                    based.para = based.para - 100000;
                    sellotoriffle.boosto = 2000;
                    c3 = 1;
                    star2.gameObject.SetActive(true);
                }
            }
        }
    }
}
