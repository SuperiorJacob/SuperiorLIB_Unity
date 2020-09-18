using UnityEngine;
using UnityEngine.SceneManagement;

public class menuCameraFollow : MonoBehaviour
{
    public XboxCursor mouse;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
    }

    void Update()
    {
        // Cute
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        var mousePosition = new Vector3(ray.origin.x, transform.position.y, ray.origin.z);

        transform.LookAt(mousePosition);
    }

    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void ExitGame()
    {
        Application.Quit(); 
    }
}
