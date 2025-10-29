using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private float movementX;
    private float movementY;
    private float movementZ;
    public float speed;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 movement = new(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    private void OnMove(InputValue movement)
    {
        Vector2 actualMovement = movement.Get<Vector2>();
        Debug.Log("Movement Input: " + actualMovement);

        movementX = actualMovement.x;
        movementY = actualMovement.y;
    }
}
