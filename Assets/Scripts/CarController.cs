using UnityEngine;
using TMPro;

public class CarController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 7f;
    private float minX = -8f;
    private float maxX = 8f;

    void Update()
    {
        TouchMove();
    }

    private void TouchMove()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            {
                if (touch.position.x < Screen.width / 2)
                {
                    MoveCar(-1);
                }
                else
                {
                    MoveCar(1);
                }
            }
        }
        // 터치 테스트용 마우스 클릭
        else if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Input.mousePosition;

            if (mousePosition.x < Screen.width / 2)
            {
                MoveCar(-1);
            }
            else
            {
                MoveCar(1);
            }
        }
    }

    void MoveCar(int direction)
    {
        float newX = transform.position.x + direction * moveSpeed * Time.deltaTime;
        newX = Mathf.Clamp(newX, minX, maxX);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
    
}