using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    // [SerializeField] float xValue = 0;
    // [SerializeField] float yValue = 0.01f;
    // [SerializeField] float zValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        // transform.Translate(1, 0, 0);

        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        // float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        // float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        // transform.Translate(1, 0, 0);
        // transform.Translate(xValue, yValue, zValue);

        // transform.Translate(xValue, 0, zValue);

        MovePlayer();

    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with the WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
