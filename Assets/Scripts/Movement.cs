using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f; // Kecepatan gerakan player

    // Update is called once per frame
    void Update()
    {
        // Input horizontal (gerakan ke kanan dan kiri)
        float horizontalInput = Input.GetAxis("Horizontal");
        // Input vertical (gerakan ke atas dan bawah)
        float verticalInput = Input.GetAxis("Vertical");

        // Tentukan vektor gerakan berdasarkan input
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;

        // Gerakkan player sesuai dengan vektor movement
        transform.Translate(movement);
    }
}