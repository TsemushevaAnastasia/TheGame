using UnityEngine;

public class CamMove : MonoBehaviour
{
    public GameObject player;

    void Start()
    {

    }

    void Update()
    {
        transform.position = new Vector3(player.transform.position.x+5, player.transform.position.y+2, -10f);
    }
}
