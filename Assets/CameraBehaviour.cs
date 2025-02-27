using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 3, -6);
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        if(target)
        {
            transform.position = target.position + offset;
            transform.LookAt(target);
        }
    }
}
