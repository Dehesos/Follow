using UnityEngine;
using System.Collections;

public class DeplacEntitePrincipal : MonoBehaviour {
    

    // Use this for initialization
    void Start () {
	
	}

    //Création du vecteur mouvement en dehors de l'update pour éviter de réinitialiser la position.
    Vector3 move = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Update () {

       
        //création d'un vecteur qui récupere la position de la souris
        Vector3 mousePos = Input.mousePosition;
       
        //la bille se deplace dans une direction si elle se situe dans la quart extreme de la direction souhaité
        //On associe les nouvelles positions à l'objet
        transform.position = move;
    }
}
