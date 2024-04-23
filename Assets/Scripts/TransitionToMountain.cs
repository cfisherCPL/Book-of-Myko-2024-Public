using UnityEngine;

public class TransitionToMountain : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Go to forest scene
            SceneController.instance.LoadScene("Mountain_Outside");
        }
    }   
}

