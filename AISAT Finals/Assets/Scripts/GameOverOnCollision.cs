using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverOnCollision : MonoBehaviour
{

    public string sceneToLoad;

    void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Player")
        {
            SceneManager.LoadScene(sceneToLoad);
        }

       
    }
}
