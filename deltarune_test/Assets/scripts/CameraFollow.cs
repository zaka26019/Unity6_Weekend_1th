using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // �÷��̾ ������ ����
    public float smoothSpeed = 0.125f; // ī�޶� �̵� �ӵ�
    public Vector3 offset; // ī�޶�� �÷��̾� ������ �Ÿ�

    void LateUpdate()
    {
        // ��ǥ ��ġ ��� (�÷��̾��� ��ġ + ������)
        Vector3 desiredPosition = target.position + offset;

        // ���� ī�޶� ��ġ���� ��ǥ ��ġ���� �ε巴�� �̵�
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}