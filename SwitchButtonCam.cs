using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class switchViewCam : MonoBehaviour {

    // Serialisasi Component Kamera
    [SerializeField]
    Camera firstCamera;
    [SerializeField]
    Camera secondCamera;
    [SerializeField]
    Camera thirdCamera;

    void Start()
    {
        // Kondisi Awal Kamera
        firstCamera.GetComponent<Camera>().enabled = true;
        secondCamera.GetComponent<Camera>().enabled = false;
        thirdCamera.GetComponent<Camera>().enabled = false;
    }

    public void ActiveCameraOne(){
        firstCamera.GetComponent<Camera>().enabled = true;
        secondCamera.GetComponent<Camera>().enabled = false;
        thirdCamera.GetComponent<Camera>().enabled = false;
    }

    public void ActiveCameraTwo(){
        firstCamera.GetComponent<Camera>().enabled = false;
        secondCamera.GetComponent<Camera>().enabled = false;
        thirdCamera.GetComponent<Camera>().enabled = true;
    }

    public void ActiveCameraThree(){
        firstCamera.GetComponent<Camera>().enabled = false;
        secondCamera.GetComponent<Camera>().enabled = true;
        thirdCamera.GetComponent<Camera>().enabled = false;
    }
}