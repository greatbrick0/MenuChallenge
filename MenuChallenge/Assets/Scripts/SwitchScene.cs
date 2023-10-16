using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    [SerializeField]
    string sceneName;

    public void Switch()
    {
        SceneManager.LoadScene(sceneName);
    }
}
