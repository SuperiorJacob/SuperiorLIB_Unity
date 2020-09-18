using UnityEngine;
using UnityEngine.SceneManagement;

public class playerGame : MonoBehaviour
{
    [SerializeField] private GameObject statue;
    [SerializeField] private GameObject winState;

    private bool gameOver = false;
    public bool hasStatue = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject == statue)
        {
            hasStatue = true;
            hit.gameObject.SetActive(false);
            gameOver = true;
            winState.SetActive(true);

            Invoke("ReturnToHome", 5);
        }
    }

    void ReturnToHome()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
