using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour{
    //
    public GameObject plane;
    public GameObject spawnPoint;

	// Use this for initialization
	void Start(){
		
	}// End of start function
	
	// Update is called once per frame
	void Update(){
        // 
		if(transform.position.y < plane.transform.position.y - 10){
            transform.position = spawnPoint.transform.position;
        }// End of if
	}// End of update function
}// End of SphereScript Class
