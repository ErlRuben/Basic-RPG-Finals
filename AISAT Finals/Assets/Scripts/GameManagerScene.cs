using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScene : MonoBehaviour
{

    public string sceneToLoad;

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void QuitGame ()
        {
            Debug.Log("QUIT!");
            Application.Quit();
        }



}
 