using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MushroomTouched : MonoBehaviour
{
   public UnityEvent mushroomWasTouched;
    AudioSource soundEffect;
    Collider2D trigger;

   [SerializeField] private int pointsPerCollect;

   private ScoreManager _scoreController;

   private void Awake()
   {
        _scoreController = FindObjectOfType<ScoreManager>();
        soundEffect = GetComponent<AudioSource>();
        trigger = GetComponent<Collider2D>();

   }

    public void OnTriggerEnter2D(Collider2D other)
    {
        soundEffect.Play();
        ScoreManager.Instance.IncreaseScore(pointsPerCollect);
        mushroomWasTouched.Invoke();

        Destroy(this.gameObject,0.1f);
    }


}
