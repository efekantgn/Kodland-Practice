using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Oyuncunun hareket hızı

    void Update()
    {
        // Klavye girişlerini al
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Hareket vektörü oluştur
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;

        // Hareket vektörünü dünya koordinatlarına dönüştür
        movement = transform.TransformDirection(movement);

        // Oyuncuyu hareket ettir
        transform.position += movement;
    }
}
