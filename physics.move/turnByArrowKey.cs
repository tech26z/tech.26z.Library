//mount directly to a wheel
//reading out the degree exactly

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tech26z.library.hphics.move{

public class TurnByArrowKey : MonoBehaviour {
    float degree;
	// Use this for initialization
	void Start () {
        transform.Translate(new Vector3(1, 0, 0));
        //transform.Rotate(new Vector3(0, 45, 0));
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Translate(new Vector3(1, 0, 0));
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(new Vector3(0, 10, 0)*Time.deltaTime);
            degree += Time.deltaTime*10;
            Debug.Log((int)degree);
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(new Vector3(0, -10, 0) * Time.deltaTime);
            degree -= Time.deltaTime * 10;
            Debug.Log((int)degree);
        }
	}
}
}
