﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
    public GameObject candyPrefab;
    public float shotForce;
    public float shotTorque;

    // Update is called once per frame
    void Update () {
        if (input.GetButtonDown ("Fire1")) Shot ();
    }
    public void Shot () {
        GameObject candy = INstantiate (
            candyPrefab,
            transform.position,
            Quaternion.identity
        );
        Rigidbody candyRigidBody = candy.GetComponent<Rigidbody> ();
        candyRigidBody.AddForce (transform.forward * shotForce);
        candyRigidBody.AddTorque (new Vector3 (0, shotTorque, 0));
    }
}