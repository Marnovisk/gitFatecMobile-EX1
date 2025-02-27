using UnityEngine;

public class TileEndBehaviour : MonoBehaviour
{
    public float destroyTime = 1.5f;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<PlayerBehaviour>())
        {
            var gm = GameObject.FindObjectOfType<GameManager>();
            gm.SpawnnextTile();

            Destroy(transform.parent.gameObject, destroyTime);
        }       
    }
}
