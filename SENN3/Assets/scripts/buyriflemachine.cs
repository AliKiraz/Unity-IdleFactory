using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buyriflemachine : MonoBehaviour
{
    public static int isriflebuy;
    public GameObject rifflebutton,money;
    public Text rifflemoney;
    // Start is called before the first frame update
    void Start()
    {
        isriflebuy = 0;
        PlayerPrefs.GetInt("isriflebuy");
      

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerPrefs.SetInt("isriflebuy", isriflebuy);
        if (based.rifle>=1) { isriflebuy = 1;
            rifflebutton.gameObject.SetActive(false);
            money.gameObject.SetActive(false);
            rifflemoney.gameObject.SetActive(false);


        }
    }
    private void OnMouseUpAsButton()
    {
        if (isriflebuy==0)
        {
            if (based.para >= 10000)
            {
                based.para = based.para - 10000;
                based.rifle = 1;
                isriflebuy = 1;

            }
        }
    }
}
