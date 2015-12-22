﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerController))]
public class Player : MonoBehaviour {

    public float moveSpeed = 5;

    Camera viewCamera;
    PlayerController controller;

    void Start()
    {
        controller = GetComponent<PlayerController>();
    }

	void Update ()
    {
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector3 moveVelocity = moveInput.normalized * moveSpeed;
        controller.Move(moveVelocity);
	}
}
