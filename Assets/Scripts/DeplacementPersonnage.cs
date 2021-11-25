using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementPersonnage : MonoBehaviour
{
    [SerializeField]
    private GestionnairePeripherique gestionnairePeripherique;
    [SerializeField]
    private GestionnaireCamera gestionnaireCamera;
    [SerializeField]
    private CharacterController characterController;

    [SerializeField]
    private Camera mainCamera;
    [SerializeField]
    private Animator animatorPersonnage;

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
        //V�rification si le personnage touche le sol avec un GameObject qui est au pied du personnage.
        toucheSol = Physics.CheckSphere(verifToucheSol.position, distanceDuSol, layerSol);

        //Comme le personnage tombe toujours,
        //la vitesse de descente verticale diminue toujours (pour tomber).
        //Si la vitesse verticale descend au-dessous de z�ros,
        //nous r�initialisons la vitesse verticale � 0.
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
            animatorPersonnage.SetBool("Courir", true);
        }
        else
        {
            animatorPersonnage.SetBool("Courir", false);
        }


        Vector3 move = mainCamera.transform.right * x + mainCamera.transform.forward * y;
        move.y = 0;

        characterController.Move(move * vitesseDeplacement * Time.deltaTime);

        if (gestionnaireCamera.cameraFPSActive) // Si premi�re personne
        {
            //Rotation du joueur a la premi�re personne selon la rotation de la cam�ra
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, mainCamera.transform.eulerAngles.y, transform.eulerAngles.z);
        }
        else
        {
            if (move.magnitude <= 0.1f) //Si le personnage bouge ou avance
            {
                float targetAngle = Mathf.Atan2(move.x, move.y) * Mathf.Rad2Deg;
                Quaternion rotation = Quaternion.Euler(0f, targetAngle, 0f);
                transform.rotation = Quaternion.Lerp(transform.rotation, rotation, 1 * Time.deltaTime);
            }
        }

        if (move != Vector3.zero) //Si personnage bouge
        {
            animatorPersonnage.SetBool("Marche", true);
        }
        else
        {
            animatorPersonnage.SetBool("Marche", false);
        }



    }

    // Le personnage va continuellement tomber.
    // Il va s'arr�ter sur les GameObject qui ont un collider.
    private void AppliqueGravite()
    {
        vitesseVertical.y += gravite * Time.deltaTime * 2;

        characterController.Move(vitesseVertical * Time.deltaTime);
    }

    //Le saut est produit en lui donnant une vitesse verticale plus grande
    //que la gravit� qui est appliqu�e pour tomber.
    private void ProduireSaut()
    {
        if (toucheSol)
        {
            vitesseVertical.y = Mathf.Sqrt(hauteurSaut * -3.0f * gravite);
            animatorPersonnage.SetTrigger("Saut");
        }
    }

}
