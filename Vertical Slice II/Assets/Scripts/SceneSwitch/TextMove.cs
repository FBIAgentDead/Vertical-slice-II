using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMove : MonoBehaviour {


	void Move ()
    {
        transform.position += Vector3.up * Time.deltaTime;
	}


}
