using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform tile;
    public Vector3 startpoint;
    public int initSpawnNum = 10;
    private Vector3 nextTileLocation;
    private Quaternion nextTileRotation;
    // Start is called before the first frame update
    void Start()
    { 
        nextTileLocation = startpoint;
        nextTileRotation = Quaternion.identity;

        for(int i = 0; i < initSpawnNum; i++)
        {
            SpawnnextTile();
        }
    }

    public void SpawnnextTile()
    {
       var newTile = Instantiate(tile, nextTileLocation, nextTileRotation);
       var nextTile = newTile.Find("NextSpawnPoint");
       nextTileLocation = nextTile.position;
       nextTileRotation = nextTile.rotation;
    }
}
