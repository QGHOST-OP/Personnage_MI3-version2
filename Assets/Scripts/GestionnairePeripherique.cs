using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class GestionnairePeripherique : MonoBehaviour
{
    private PeripheriqueEntree peripheriqueEntree;

    [SerializeField]
    private Vector2 deplacement;
    [SerializeField]
    private Vector2 regard;

    public float mouvementRegardHorizontal;
    public float mouvementRegardVertical;

    public float mouvementDeplacementHorizontal;
    public float mouvementDeplacementVertical;
    
    public bool courrirActif;

    public UnityEvent sauter;
    public UnityEvent cliquer;
    public UnityEvent changementCamera;


    private void Awake()
    {
        peripheriqueEntree = new PeripheriqueEntree();

        peripheriqueEntree.JoueurAuSol.Deplacer.performed += LireMouvementDeplacement;
        peripheriqueEntree.JoueurAuSol.Deplacer.canceled += LireMouvementDeplacement;

        peripheriqueEntree.JoueurAuSol.Regarder.performed += LireMouvementRegard;
        peripheriqueEntree.JoueurAuSol.Regarder.canceled += LireMouvementRegard;


        peripheriqueEntree.JoueurAuSol.Sauter.started += LireSaut;

        peripheriqueEntree.JoueurAuSol.Courir.started += LireCourrir;
        peripheriqueEntree.JoueurAuSol.Courir.canceled += LireCourrir;

        peripheriqueEntree.JoueurAuSol.Cliquer.started += LireClic;

        peripheriqueEntree.JoueurAuSol.ChangementCamera.started += LireChangementCamera;

    }

    private void OnEnable()
    {
        peripheriqueEntree.JoueurAuSol.Enable();
    }
    private void OnDisable()
    {
        peripheriqueEntree.JoueurAuSol.Disable();
    }

    private void LireCourrir(InputAction.CallbackContext context)
    {
        courrirActif = context.ReadValueAsButton();
    }

    private void LireClic(InputAction.CallbackContext context)
    {
        cliquer.Invoke();
    }

    private void LireMouvementRegard(InputAction.CallbackContext context)
    {
        regard = Vector2.ClampMagnitude( context.ReadValue<Vector2>(), 1 );

        mouvementRegardHorizontal = regard.x;
        mouvementRegardVertical = regard.y;
    }

    private void LireSaut(InputAction.CallbackContext context)
    {
        sauter.Invoke();
    }

    private void LireMouvementDeplacement(InputAction.CallbackContext context)
    {
        deplacement = context.ReadValue<Vector2>();

        mouvementDeplacementHorizontal = deplacement.x;
        mouvementDeplacementVertical = deplacement.y;
    }

    private void LireChangementCamera(InputAction.CallbackContext context)
    {
        changementCamera.Invoke();
    }

}
