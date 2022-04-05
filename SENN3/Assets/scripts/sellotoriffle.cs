using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sellotoriffle : MonoBehaviour
{

    public Text paramiz;

    public static float boosto;


    // Start is called before the first frame update
    void Start()
    {

         boosto = 72;
        if (PlayerPrefs.HasKey("boosto"))
        {
            boosto = PlayerPrefs.GetFloat("boosto");
        }
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        PlayerPrefs.SetFloat("boosto", boosto);


        paramiz.text = "MONEY= " + based.para;


    }
    private void OnMouseUpAsButton()
    {

        if (based.otorifle >= 1)
        {
            based.para += boosto*based.otorifle;
            based.otorifle=1;


        }
    }

}
