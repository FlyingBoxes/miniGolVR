using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class PutterHeadBehavior : MonoBehaviour
{
    [SerializeField] private ActionBasedController rightController;
    [SerializeField] private AudioSource putterSound;
    [SerializeField] public Text strokeText;

    void Start()
    {
        ScoreKeeper.score = 0;
        strokeText.text = ScoreKeeper.score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            putterSound.Play(0);
            rightController.SendHapticImpulse(0.08f, .05f);

            ScoreKeeper.score++;
            strokeText.text = ScoreKeeper.score.ToString();
        }
        
    }

    
}
