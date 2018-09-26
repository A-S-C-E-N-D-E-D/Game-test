using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    Rigidbody rigid;
    float vacc;
    float hacc;
    public float acc;
    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        vacc = Input.GetAxis("Vertical");
        hacc = Input.GetAxis("Horizontal");
        Vector3 movevec = new Vector3(hacc * acc, 0, vacc * acc);
        rigid.AddForce(movevec);
	}
}
