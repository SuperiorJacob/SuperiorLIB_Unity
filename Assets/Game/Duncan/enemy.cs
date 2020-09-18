using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] private SkinnedMeshRenderer render;
    [SerializeField] private Transform player;

    private bool jumpScare = false;
    private playerGame ply;

    // Start is called before the first frame update
    void Start()
    {
        ply = player.GetComponent<playerGame>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = Camera.main.transform.position;

        if (!jumpScare && ply.hasStatue)
        {
            if (!render.isVisible || Vector3.Distance(target, transform.position) > 8)
            {
                transform.position = Vector3.MoveTowards(transform.position, player.position, 0.01f);
                transform.LookAt(new Vector3(player.position.x, 0, player.position.z));
            }
            else
            {
                //Laggy meme
                //render.SetBlendShapeWeight(0, Mathf.Clamp(100 - Vector3.Distance(target, transform.position) * 10, 0, 100));
            }
        }
        else
        {
            //transform.position = target;
            //head.position = target;

            //player.LookAt(head);
        }
    }
}
