
using UnityEngine;

public class TransitionToForest : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Go to forest scene
            SceneController.instance.LoadScene("Forest_Outside");
        }
    }   
}
