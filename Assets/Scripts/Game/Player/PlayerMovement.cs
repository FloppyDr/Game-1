using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SphereCollider))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private LayerMask _obstacleLayer;

    private Rigidbody _rigidbody;
    private SphereCollider _collider;
    private float _checkSphereRadius;

    private bool _isGrounded;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _collider = GetComponent<SphereCollider>();

        _checkSphereRadius = _collider.radius + 0.01f;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && _isGrounded)
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);

        _rigidbody.MovePosition(_rigidbody.position + Vector3.forward * _speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        _isGrounded = Physics.CheckSphere(transform.position, _checkSphereRadius, _obstacleLayer);

    }
}
