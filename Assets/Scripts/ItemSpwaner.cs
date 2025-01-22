using UnityEngine;
using Random = UnityEngine.Random;


public class ItemSpwaner : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    private enum GasPosition
    {
        Left,
        Center,
        Right
    }
    public Transform leftPosition;
    public Transform centerPosition;
    public Transform rightPosition;

    public GameObject itemSpwaner;
    public GameObject gas;
    
    private void Start()
    {
        SetRandomGas();
    }

    private void SetRandomGas()
    {
        GasPosition randomPosition = (GasPosition)Random.Range(0, 3);
        
        switch (randomPosition)
        {
            case GasPosition.Left:
                gas.transform.position = leftPosition.position;
                break;
            case GasPosition.Center:
                gas.transform.position = centerPosition.position;
                break;
            case GasPosition.Right:
                gas.transform.position = rightPosition.position;
                break;
        }
    }

    private void Update()
    {
        
        itemSpwaner.transform.position -= Vector3.forward * moveSpeed * Time.deltaTime;

            if (itemSpwaner.transform.position.z <= -30f)
            {
                Debug.Log("Itemtest");
                itemSpwaner.transform.position = new Vector3(itemSpwaner.transform.position.x, itemSpwaner.transform.position.y, 60f);
                SetRandomGas();
            }
        
    }
}
