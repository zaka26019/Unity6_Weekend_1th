using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // 플레이어를 지정할 변수
    public float smoothSpeed = 0.125f; // 카메라 이동 속도
    public Vector3 offset; // 카메라와 플레이어 사이의 거리

    void LateUpdate()
    {
        // 목표 위치 계산 (플레이어의 위치 + 오프셋)
        Vector3 desiredPosition = target.position + offset;

        // 현재 카메라 위치에서 목표 위치까지 부드럽게 이동
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}