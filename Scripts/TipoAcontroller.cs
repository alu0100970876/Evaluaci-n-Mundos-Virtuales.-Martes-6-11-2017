using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoAcontroller : MonoBehaviour {

    int poder = 10;

	// Use this for initialization
	void Start () {
        GameController.onDisminuirpoder += disminuirPoder;
        TipoBcontroller.onAumentartamanoA += aumentarTamano;
	}

    void disminuirPoder(int cantidad) {
        if ((poder + (cantidad * -1)) > 0)
            poder += (cantidad * -1);
        else {
            poder = 1;
            Debug.Log("No se puede disminuir mas de los que está");
        }
        Debug.Log("Poder: " + poder.ToString());
    }

    void aumentarTamano() {
        poder += 1;
    }

    void Update() {
        this.GetComponent<Transform>().localScale = new Vector3(poder, poder, poder);
    }
}
