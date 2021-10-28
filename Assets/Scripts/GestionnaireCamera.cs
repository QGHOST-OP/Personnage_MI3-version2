using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using System;

public class GestionnaireCamera : MonoBehaviour
{
    [SerializeField]
    private GestionnairePeripherique gestionnairePeripherique;

    [SerializeField]
    private CinemachineVirtualCamera cameraFPS;

    [SerializeField]
    private CinemachineFreeLook cameraTPS;

    [SerializeField]
    public bool cameraFPSActive = false;



    // Start is called before the first frame update
    void Start()
    {
        gestionnairePeripherique.changementCamera.AddListener(ProduireChangementCamera);
    }

    private void ProduireChangementCamera()
    {
        cameraFPSActive = !cameraFPSActive;

        if (cameraFPSActive)
        {
            cameraFPS.Priority = 2;
        }
        else
        {
            cameraFPS.Priority = 0;
        }
    }
}
