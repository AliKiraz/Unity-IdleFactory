using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goshopbutton : MonoBehaviour
{
    public Camera kamera;
    public Canvas bazaar;
    public Canvas  basem, upgrademenu,shopmenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseUpAsButton()
    {
       
        basem.gameObject.SetActive(false);
        bazaar.gameObject.SetActive(false);
        upgrademenu.gameObject.SetActive(false);
        shopmenu.gameObject.SetActive(true);
        kamera.transform.position = new Vector3(-24, 0, -10);
    }
}
