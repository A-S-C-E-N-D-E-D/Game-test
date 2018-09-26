using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject focus;
    Transform pos;
    public Vector3 offset;
	// Use this for initialization
	void Start () {
        pos = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        pos.position = focus.transform.position + offset;
	}
}
