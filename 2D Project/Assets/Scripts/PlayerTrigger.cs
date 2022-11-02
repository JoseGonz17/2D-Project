using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    private string PlayerTag = ("Player");

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(PlayerTag))
        {
            OnPlayerEnter(other.gameObject);
        }
    }

    private void OnPlayerEnter(GameObject gameObject)
    {
    }
}