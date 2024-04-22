
using UnityEngine;

public class TransitionToCabinOutside : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Go to cabin outside scene
            SceneController.instance.LoadScene("Cabin_Outside");
        }
    }   
}
