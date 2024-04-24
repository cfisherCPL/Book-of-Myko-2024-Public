using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressToStart : MonoBehaviour
{
    public string sceneToLoad;
    public Vector2 playerPositionToSpawn;
    public VectorValue playerStorage;

    // Update is called once per frame
    void Update()
    {
     if (Input.anyKey)
        {
            playerStorage.initialValue = playerPositionToSpawn;
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
