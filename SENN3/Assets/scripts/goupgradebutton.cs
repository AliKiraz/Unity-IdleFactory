using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goupgradebutton : MonoBehaviour
{
    public Camera kamera;
    public Canvas bazaar;
    public Canvas menu, basem,upgrademenu;
    // Start is called before the first frame update
    void Start()
    {
        upgrademenu.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseUpAsButton()
    {
        menu.gameObject.SetActive(false);
        basem.gameObject.SetActive(false);
        bazaar.gameObject.SetActive(false);
        upgrademenu.gameObject.SetActive(true);
        kamera.transform.position = new Vector3(-18, 0, -10);
    }
}
