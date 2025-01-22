using UnityEngine;

public class ItemGas : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            Debug.Log("ㅊㄷ");
            gameObject.SetActive(false);
        }
    }
}