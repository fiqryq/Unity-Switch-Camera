using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchViewCam : MonoBehaviour {

    // Serialisasi Component Kamera
    [SerializeField]
    Camera firstCamera;
    [SerializeField]
    Camera secondCamera;
    [SerializeField]
    Camera thirdCamera;

    // Inisialisasi State
    private bool switchCam = false;
    private bool backCam = false;
    // Start is called before the first frame update

    void Start()
    {
        firstCamera.GetComponent<Camera>().enabled = false;
        secondCamera.GetComponent<Camera>().enabled = true;
        thirdCamera.GetComponent<Camera>().enabled = false;
    }

    // Update is called once per frame
    void Update() {
        // Input Key
        if (Input.GetKeyDown("t")) {
            switchCam = !switchCam;
            backCam = false;
        }

        if (Input.GetKeyDown("b")) {
            switchCam = false;
            backCam = true;
        }

        if(switchCam == true){
            firstCamera.GetComponent<Camera>().enabled = true;
            secondCamera.GetComponent<Camera>().enabled = false;
            thirdCamera.GetComponent<Camera>().enabled = false;
        } else if (backCam == true){
            firstCamera.GetComponent<Camera>().enabled = false;
            secondCamera.GetComponent<Camera>().enabled = false;
            thirdCamera.GetComponent<Camera>().enabled = true;
        } else {
            firstCamera.GetComponent<Camera>().enabled = false;
            secondCamera.GetComponent<Camera>().enabled = true;
            thirdCamera.GetComponent<Camera>().enabled = false;
        }
    }
}
