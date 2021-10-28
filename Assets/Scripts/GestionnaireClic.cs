using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionnaireClic : MonoBehaviour
{
    [SerializeField]
    private GestionnairePeripherique gestionnairePeripherique;

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
        gestionnairePeripherique.cliquer.AddListener(ProduireClic);
    }

    private void ProduireClic()
    {
        Vector2 milieuEcran = new Vector2(Screen.width / 2, Screen.height / 2);
        GameObject objetCollision;

        Ray ray = mainCamera.ScreenPointToRay(milieuEcran);
        RaycastHit hit;

        //Si le rayon entre en collision avec un GameObject qui a un collider
        //l'objet hit va contenir le GameObject
        if ( Physics.Raycast(ray, out hit) )
        {
            //Le DrawLine permet de tracer une ligne dans l'onglet Scene
            //Permet de voir le rayon qui part de la camera jusqu'à l'object qui entre en colision
            //Debug.DrawLine(ray.origin, hit.point, Color.red, 3);

            objetCollision = hit.transform.gameObject;

            if (objetCollision.tag == "Bloc")
            {
                Destroy(objetCollision);
            }
        }
    }

}
