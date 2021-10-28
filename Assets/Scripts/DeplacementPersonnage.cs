using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementPersonnage : MonoBehaviour
{
    [SerializeField]
    private GestionnairePeripherique gestionnairePeripherique;
    [SerializeField]
    private CharacterController characterController;

    [SerializeField]
    private Camera mainCamera;

    [SerializeField]
    private float vitesseMarche = 6f;
    [SerializeField]
    private float vitesseCourse = 12f;
    [SerializeField]
    private float hauteurSaut = 2f;

    [SerializeField]
    private float gravite = -9.81f;
    [SerializeField]
    private Transform verifToucheSol;
    [SerializeField]
    private float distanceDuSol = 0.1f;
    [SerializeField]
    private LayerMask layerSol;

    private bool toucheSol;
    private Vector3 vitesseVertical;


    // Start is called before the first frame update
    void Start()
    {
        gestionnairePeripherique.sauter.AddListener(ProduireSaut);
    }

    // Update is called once per frame
    void Update()
    {
        //Vérification si le personnage touche le sol avec un GameObject qui est au pied du personnage.
        toucheSol = Physics.CheckSphere(verifToucheSol.position, distanceDuSol, layerSol);

        //Comme le personnage tombe toujours,
        //la vitesse de descente verticale diminue toujours (pour tomber).
        //Si la vitesse verticale descend au-dessous de zéros,
        //nous réinitialisons la vitesse verticale à 0.
        if (toucheSol && vitesseVertical.y < 0)
        {
            vitesseVertical.y = 0;
        }

        Deplacement();
        AppliqueGravite();
    }

    private void Deplacement()
    {
        float x = gestionnairePeripherique.mouvementDeplacementHorizontal;
        float y = gestionnairePeripherique.mouvementDeplacementVertical;

        float vitesseDeplacement = vitesseMarche;

        if (gestionnairePeripherique.courrirActif)
        {
            vitesseDeplacement = vitesseCourse;
        }


        Vector3 move = mainCamera.transform.right * x + mainCamera.transform.forward * y;

        characterController.Move(move * vitesseDeplacement * Time.deltaTime);

        if (move.magnitude <= 0.1f)
        {
            float targetAngle = Mathf.Atan2(move.x, move.y) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.Euler(0f, targetAngle, 0f);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, 1 * Time.deltaTime);
        }
    }

    // Le personnage va continuellement tomber.
    // Il va s'arrêter sur les GameObject qui ont un collider.
    private void AppliqueGravite()
    {
        vitesseVertical.y += gravite * Time.deltaTime * 2;

        characterController.Move(vitesseVertical * Time.deltaTime);
    }

    //Le saut est produit en lui donnant une vitesse verticale plus grande
    //que la gravité qui est appliquée pour tomber.
    private void ProduireSaut()
    {
        if (toucheSol)
        {
            vitesseVertical.y = Mathf.Sqrt(hauteurSaut * -3.0f * gravite);
        }
    }

}
