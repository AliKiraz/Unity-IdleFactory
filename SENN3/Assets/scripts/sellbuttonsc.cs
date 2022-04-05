using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sellbuttonsc : MonoBehaviour
{
   
    public Text paramiz;
    public static int tabancasell;
    public static float boost;
   

    // Start is called before the first frame update
    void Start()
    {
       // tabancasell = based.tabanca;
        boost = 3;
        if (PlayerPrefs.HasKey("boost"))
        {
            boost = PlayerPrefs.GetFloat("boost");
        }
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {

       
        PlayerPrefs.SetFloat("boost", boost);
       
            
        paramiz.text = "MONEY= " + based.para;
       
       
    }
    private void OnMouseUpAsButton()
    {
      
        if (based.tabanca>=1) {
            based.para += boost*based.tabanca;
            based.tabanca = 1;
          
            
        } 
    }
  
    }
