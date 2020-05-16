using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10.0f;
    
    // Use this for initialization
    void Start()
    {
        // 回転しない設定
        rb.constraints = RigidbodyConstraints.FreezeRotation;


    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            
        }
        if (Input.GetKey("down"))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("right"))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("left"))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
    }
}
