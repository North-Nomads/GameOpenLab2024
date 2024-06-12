using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float playerRotationSpeed;
    [SerializeField] private float playerSpeed;

    private CharacterController _characterController;


    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 movementVector = Vector3.ClampMagnitude(new(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")), 1);
        _characterController.SimpleMove(movementVector * playerSpeed);
        gameObject.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(movementVector, Vector3.up), playerRotationSpeed * Time.deltaTime);
        
    }
}
