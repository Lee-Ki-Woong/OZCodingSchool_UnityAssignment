using UnityEngine;

public class GetGunScope : MonoBehaviour
{
    [SerializeField] private Transform MyTransform;
    [SerializeField] private float m_shotRange = 5.0f;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(ShotPosition(), MyTransform.right * m_shotRange);
    }

    private Vector3 ShotPosition()
    {
        var shotPosition = MyTransform.position;
        return shotPosition;
    }
}
