using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{

    public float speed;
    public Rigidbody rb; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");          // Up and Down
        float vertical = Input.GetAxisRaw("Vertical");              // Left and Right
        Vector3 direction = new Vector3(horizontal, 0, vertical);   // Tell the cube to move in certain direction

        transform.Translate(direction.normalized * Time.deltaTime * speed); //Move in the direction

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector3(0, 10), ForceMode.Impulse);
        }
    }
}
