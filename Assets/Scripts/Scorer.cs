using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            // hits = hits + 1;
            hits++;
            Debug.Log("You've bumped into an obstacle this many times: " + hits);
        }

        // Debug.Log("You've bumped into an obstacle this many times: " + hits);    
    }

}
