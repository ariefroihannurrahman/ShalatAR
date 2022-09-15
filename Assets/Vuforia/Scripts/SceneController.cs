using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public string scene;

    public void loadSceneMainMenu()
    {
        SceneManager.LoadScene(scene);
    }

    public void loadSceneSampleScenes()
    {
        SceneManager.LoadScene(scene);
    }
}
