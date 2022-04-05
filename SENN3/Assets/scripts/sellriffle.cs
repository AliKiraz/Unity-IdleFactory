using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sellriffle : MonoBehaviour
{

    public Text paramiz;
  
    public static float boostr;


    // Start is called before the first frame update
    void Start()
    {
     
        boostr = 25;
        if (PlayerPrefs.HasKey("boostr"))
        {
            boostr = PlayerPrefs.GetFloat("boostr");
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {


        PlayerPrefs.SetFloat("boostr", boostr);


        paramiz.text = "MONEY= " + based.para;


    }
    private void OnMouseUpAsButton()
    {

        if (based.rifle >= 1)
        {
            based.para += boostr*based.rifle;
            based.rifle=1;


        }
    }

}
