using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerload : MonoBehaviour
{

    public savemanager sv;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (sv != null)
            {
                // Attempt to load data
                sv.JsonLoad();
                Debug.Log("Attempting to load player data...");

                // Check if loading was successful
                if (sv.recepkaan != null)
                {
                    Debug.Log("Player data loaded successfully.");
                }
                else
                {
                    Debug.LogWarning("Player data load failed or data is null.");
                }
            }
            else
            {
                Debug.LogWarning("SaveManager is not assigned.");
            }
        }
    }
}