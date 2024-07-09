using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileMovement : MonoBehaviour
{
    [Header("RIGIDBODY")]
    public Rigidbody2D rb;

    //[serializeField] private Rigidbody2D rb;
    //[serializeField] IS USED TO KEEP THE VARIABLE 'PRIVATE', i.e, NOT ACCESSIBLE TO ANY OTHER SCRIPTS, BUT STILL BE VISIBLE ON THE UNTIY EDITOR

    [Header("PADDLE FORCES")]
    public float force = 10f;

    private void Start()
    {
        //RIGIDBODY IS NECESSARY FOR APPLYING 'PHYSICS-BASED' MOVEMENTS
        rb = GetComponent<Rigidbody2D>();
    }

    //WHENEVER WE DO 'PHYSICS STUFF', WE DO IT INSIDE THE 'FIXEDUPDATE()' FUNCTION
    void FixedUpdate()
    {
        Vector2 forceDirection = Vector2.zero;

        if (gameObject.CompareTag("Left Paddle"))
        {
            if (Input.GetKey(KeyCode.W))
            {
                // ForceMode2D.Impulse---> THIS PARAMETER SPECIFIES THE 'TYPE OF FORCE BEING APPLIED'. 
                // THE 'ForceMode2D.Impulse' APPLIES AN 'INSTANT FORCE' TO THE 'RIGIDBODY2D'[OBJECT]
                //rb.AddForce(Vector2.up * upwardForce * Time.deltaTime, ForceMode2D.Impulse);

                forceDirection = Vector2.up;
                //Debug.Log("W --- MOVING LEFT PADDLE UPWARDS!");
            }
            else if (Input.GetKey(KeyCode.S))
            {
                forceDirection = Vector2.down;
                //Debug.Log("S --- MOVING LEFT PADDLE DOWNWARDS!");
            }   
        }
        else if (gameObject.CompareTag("Right Paddle"))
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                forceDirection = Vector2.up;
                //Debug.Log("UpArrow --- MOVING RIGHT PADDLE UPWARDS!");
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                forceDirection = Vector2.down;
                //Debug.Log("DownArrow --- MOVING RIGHT PADDLE DOWNWARDS!");
            }
        }

        // Apply force to the paddle
        rb.AddForce(forceDirection * force);
        Debug.Log($"Applied force: {forceDirection * force}");
    }
}