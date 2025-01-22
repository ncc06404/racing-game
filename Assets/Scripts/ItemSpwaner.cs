using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemSpwaner : MonoBehaviour
{
    public GameObject itemSpwaner;
    public float moveSpeed;
    private void Start()
    {
        RandomItemGas();
    }

    private void RandomItemGas()
    {
        // 아이템 가스 랜덤으로 생성
    }

    private void Update()
    {
        
        itemSpwaner.transform.position -= Vector3.forward * moveSpeed * Time.deltaTime;

            if (itemSpwaner.transform.position.z <= -20f)
            {
                Debug.Log("Roadtest");
                itemSpwaner.transform.position = new Vector3(itemSpwaner.transform.position.x, itemSpwaner.transform.position.y, 70f);
            }
        
    }
}
