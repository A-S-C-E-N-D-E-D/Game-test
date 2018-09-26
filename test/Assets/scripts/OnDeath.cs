using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeath : MonoBehaviour {
    public Vector3 deathPos;
    public Transform trans;
	// Use this for initialization
	void Start () {
        trans = GetComponent<Transform>();
	}
    public virtual void Die()
    {
        trans.position = deathPos;
        trans.rotation = new Quaternion(0, 0, 0, 0);
    }
}