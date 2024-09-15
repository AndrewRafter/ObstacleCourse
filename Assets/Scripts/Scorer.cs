using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag != "Hit") {
            score++;
            Debug.Log("You have bumped into a thing this many times: " + score);
        }
    }
}
