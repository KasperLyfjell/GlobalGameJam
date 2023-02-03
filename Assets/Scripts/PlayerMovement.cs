using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private float playerSpeed = 2.0f;

    public GameObject wateringCan;
    Animator canAnim;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        canAnim = wateringCan.GetComponent<Animator>();
    }

    void Update()
    {

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        controller.Move(playerVelocity * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            UseWateringCan();
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            StopWateringCan();
        }
    }

    void UseWateringCan()
    {
        canAnim.SetBool("Tilt", true);
    }

    void StopWateringCan()
    {
        canAnim.SetBool("Tilt", false);
    }
}
