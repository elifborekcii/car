using System;
using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;



public enum Axel
{
    Front,
    Rear
}

[Serializable]

public struct Wheel
{
    public GameObject model;
    public WheelCollider collider;
    public Axel axel;
}
public class Car_controller : MonoBehaviour
{
    [SerializeField]
    private float maxAcceleration = 200.0f;
    [SerializeField]
    private float turnSensitivity = 2.0f;
    [SerializeField]
    private float maxSteerAngle = 35.0f;
    [SerializeField]
    private Vector3 _centerOfMass;
    [SerializeField]
    private List<Wheel> wheels;

    private float inputX, inputY;

    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
      // _rb.centerOfMass = _centerOfMass;//
    }

    private void Update()
    {
        AnimateWheels();
        GetInputs();
    }

    private void LateUpdate()
    {
        Move();
        Turn();
    }

    private void GetInputs()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        foreach (var wheel in wheels)
        {
            wheel.collider.motorTorque = inputY * maxAcceleration * 500 * Time.deltaTime;
        }
    }

    private void Turn()
    {
        foreach (var wheel in wheels)
        {
            if (wheel.axel == Axel.Front)
            {
                var _steerAngle = inputX * turnSensitivity * maxSteerAngle;
                wheel.collider.steerAngle = Mathf.Lerp(wheel.collider.steerAngle, _steerAngle, 0.5f);
            }
        }
    }

    private void AnimateWheels()
    {
        foreach (var wheel in wheels)
        {
            Quaternion _rot;
            Vector3 _pos;
            wheel.collider.GetWorldPose(out _pos, out _rot);
            wheel.model.transform.position = _pos;
            wheel.model.transform.rotation = _rot;
        }
    }
}