using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SwitchCamera : MonoBehaviour
{
    [SerializeField] private GameObject fpCam;
    [SerializeField] private GameObject tpCam;
    
    // Start is called before the first frame update
    void Start()
    {
        fpCam.SetActive(true);
        tpCam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ToggleCamera();
        }
    }

    void ToggleCamera()
    {
        if (fpCam.activeSelf)
        {
            fpCam.SetActive(false);
            tpCam.SetActive(true);
        }
        else
        {
            fpCam.SetActive(true);
            tpCam.SetActive(false);
        }
    }
}
