
using TMPro;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    public FollowCamera followCamera;
    public GameObject[] charPrefabs;
    public GameObject player;

    TextMeshPro textMeshPro;

    private string playerName = null;

    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponentInChildren<TextMeshPro>();

        player = Instantiate(charPrefabs[(int)GameManager.instance.currentPlayer]);
        player.transform.position = transform.position;
        followCamera.SetTarget(player.transform);

        playerName = GameManager.instance.CurrentPlayerNameLoad();
        player.GetComponentInChildren<TextMeshPro>().text = playerName;
    }
}