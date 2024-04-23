using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MushroomTouched : MonoBehaviour
{
   public UnityEvent mushroomWasTouched;

   [SerializeField] private int pointsPerCollect;

   private ScoreManager _scoreController;

   private void Awake()
   {
        _scoreController = FindObjectOfType<ScoreManager>();
   }

    public void OnTriggerEnter2D(Collider2D other)
    {
        ScoreManager.Instance.IncreaseScore(pointsPerCollect);
        mushroomWasTouched.Invoke();
        Destroy(this.gameObject);
    }


}
