using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraFollow2DPlatformer : MonoBehaviour {
    public Transform target; // Lo que sigue la camara
    public float smoothing; //rapidez de la camara al seguir el objeto

    Vector3 offset; //diferencia entre el objeto y la camara 
    float lowY;


	// Use this for initialization
	void Start () {
        offset = transform.position - target.position;// guarda la diferencia
        lowY = transform.position.y;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 targetCamPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
        if (transform.position.y < lowY) transform.position = new Vector3(transform.position.x, lowY, transform.position.z);
       
	}
}
