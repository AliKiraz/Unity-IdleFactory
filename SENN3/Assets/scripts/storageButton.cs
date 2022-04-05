using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class storageButton : MonoBehaviour
{
    public Camera kamera;
    public Canvas shopekrani,baseekraný;
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
       shopekrani.gameObject.SetActive(true);
       baseekraný.gameObject.SetActive(false);

        kamera.transform.position = new Vector3(-6, 0, -10);
    }
}
