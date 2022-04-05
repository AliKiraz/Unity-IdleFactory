using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buypistolmachine : MonoBehaviour
{
    public static int ispistolbuy;
    public GameObject pistolbuybutton,money;
    public Text pistolmoney;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetInt("ispistolbuy");
        ispistolbuy = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerPrefs.GetInt("ispistolbuy",ispistolbuy);
        if (based.tabanca >= 1) { ispistolbuy = 1;
            pistolbuybutton.gameObject.SetActive(false);
            money.gameObject.SetActive(false);
            pistolmoney.gameObject.SetActive(false);
        }
    }
    private void OnMouseUpAsButton()
    {
        if (ispistolbuy==0) {
            if (based.para >= 1000) {
                based.para = based.para - 1000;
                based.tabanca = 1;
                ispistolbuy = 1;

            }
        }

    }
}
