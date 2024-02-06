using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Transform thisTransform;
    private Rigidbody2D thisRigidbody2D;
    private Animator thisAnimator;
    private VoidDelegate controllerUpdate;
    [Header("Settings")]
    public float gravityAccUp = 0;
    public float gravityAccDown = 0;
    public float walkVelocity = 0;
    public float runVelocity = 0;
    [Header("Current State")]
    public Vector3 velocity = Vector3.zero;

    void Awake() {
        thisTransform = GetComponent<Transform>();
        thisRigidbody2D = GetComponent<Rigidbody2D>();
        thisAnimator = GetComponentInChildren<Animator>();
        controllerUpdate = () => {};
    }

    void Update() {

        controllerUpdate();
        thisRigidbody2D.MovePosition(thisTransform.position + (velocity * Time.deltaTime));
    }

    private void ApplyGravity() {

    }

    private void IsGrounded() {
        
    }

    private void UpdateAir() {

    }

    private void UpdateGround() {

    }
}
