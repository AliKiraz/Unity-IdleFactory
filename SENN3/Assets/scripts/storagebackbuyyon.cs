using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class storagebackbuyyon : MonoBehaviour
{
  
    public Canvas pazar,baseekraný,upgrademenu,shopmenu;
    public Camera kameram;
    // Start is called before the first frame update
    void Start()
    {
        pazar.gameObject.SetActive(false);
        shopmenu.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseUpAsButton()
    {

        kameram.transform.position = new Vector3(0,0,-10);
        pazar.gameObject.SetActive(false);
        upgrademenu.gameObject.SetActive(false);
        shopmenu.gameObject.SetActive(false);
        baseekraný.gameObject.SetActive(true);
        
    }
}
