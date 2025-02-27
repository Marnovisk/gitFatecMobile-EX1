using UnityEngine;
public class PlayerBehaviour : MonoBehaviour
{
    
    private Rigidbody rb; 

    public float dodgeSpeed = 5; 

    public float rollSpeed = 5;

    public void Start() 
    { 
        rb = GetComponent<Rigidbody>(); 
    } 
    void FixedUpdate() 
    { 
        var horizontalSpeed = Input.GetAxis("Horizontal") * dodgeSpeed; 
        rb.AddForce(horizontalSpeed, 0, rollSpeed); 
    }
}
