using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0f; // 회전 속도
    void Start()
    {
        // 프레임레이트를 60으로 고정
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // 클릭하면 회전 속도를 설정
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10f;
        }

        // 회전 속도만큼 룰렛을 회전시킴
        transform.Rotate(0f, 0f, this.rotSpeed);
    }
}
