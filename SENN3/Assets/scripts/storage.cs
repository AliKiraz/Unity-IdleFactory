using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class storage : MonoBehaviour
{   public Text depoT;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnMouseEnter() 
    {
        depoT.text = "Depodakiler: " + "\n Tabanca= " + based.tabanca + "\n";
    }
    private void OnMouseExit()
    {
        depoT.text = "Depo";
    }
}
