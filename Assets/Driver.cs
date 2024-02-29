using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // essas variavéis nao precisam ficar mudando, então estao fora do update
    [SerializeField] float steerSpeed = 1f; 
    [SerializeField] float moveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // precisa calcular cada frame, então a varíavel precisa estar dentro do update
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float velocity = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, velocity, 0);
    }
}
