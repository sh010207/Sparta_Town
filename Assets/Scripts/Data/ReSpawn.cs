using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    public FollowCamera followCamera;
    public GameObject[] charPrefabs;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = Instantiate(charPrefabs[(int)GameManager.instance.currentPlayer]);
        player.transform.position = transform.position;
        followCamera.SetTarget(player.transform);
    }

}