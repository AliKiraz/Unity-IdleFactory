using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buyotoriffle : MonoBehaviour
{
    public static int isotoriflebuy;
    public GameObject otorifflebutton, money;
    public Text otorifflemoney;
    // Start is called before the first frame update
    void Start()
    {
        isotoriflebuy = 0;
        isotoriflebuy=PlayerPrefs.GetInt("isotoriflebuy");
        isotoriflebuy = 0;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerPrefs.SetInt("isotoriflebuy", isotoriflebuy);
        if (based.otorifle >= 1)
        {
            isotoriflebuy = 1;
            otorifflebutton.gameObject.SetActive(false);
            money.gameObject.SetActive(false);
            otorifflemoney.gameObject.SetActive(false);


        }
    }
    private void OnMouseUpAsButton()
    {
        if (isotoriflebuy == 0)
        {
            if (based.para >= 35000)
            {
                based.para = based.para - 35000;
                based.otorifle = 1;
                isotoriflebuy = 1;

            }
        }
    }
}
