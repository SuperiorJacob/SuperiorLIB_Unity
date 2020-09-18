using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneAnim : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
