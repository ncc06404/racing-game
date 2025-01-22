using System;
using UnityEngine;

public class ItemGas : MonoBehaviour
{
    public float gasAmount = 30f;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            gameManager.IncreaseGas(gasAmount);
            gameObject.SetActive(false);
        }
    }
}