using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LooseCollider : MonoBehaviour
{
    //[SerializeField] private SceneLoader sceneLoader;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //sceneLoader.LoadNextScene();
        SceneManager.LoadScene("Game Over");
    }
}
