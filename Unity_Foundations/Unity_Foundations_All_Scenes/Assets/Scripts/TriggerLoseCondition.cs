using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLoseCondition : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("An enemy has reached your base! You lose.");
        }
    }

  
}
