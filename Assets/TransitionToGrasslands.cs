
using UnityEngine;

public class TransitionToGrasslands : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Go to grasslands scene
            SceneController.instance.LoadScene("Grasslands_Outside");
        }
    }   
}
