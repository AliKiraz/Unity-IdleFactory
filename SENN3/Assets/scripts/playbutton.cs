using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
public class playbutton : MonoBehaviour
{
    public Camera kamera;
    public Canvas menu,basem;
    // Start is called before the first frame update
    void Start()
    {
        kamera.transform.position = new Vector3(-12, 0, -10);
        Application.runInBackground = true;
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    private void OnMouseUpAsButton()
    {
        if (based.tabanca == 0) {

            kamera.transform.position = new Vector3(0, -11, -10);
            Thread.Sleep(100);

        }
        menu.gameObject.SetActive(false);
        basem.gameObject.SetActive(true);
        kamera.transform.position = new Vector3(0, 0, -10);
    }
}
