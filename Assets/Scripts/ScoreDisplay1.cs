using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class ScoreDisplay1 : MonoBehaviour
{
   private TMP_Text _scoreText;

   private void Awake()
   {
        _scoreText = GetComponent<TMP_Text>();
   }

   public void UpdateScore(ScoreManager scoreController)
   {
        _scoreText.text = $"Mushrooms Collected: {scoreController.score}";
   }
}
