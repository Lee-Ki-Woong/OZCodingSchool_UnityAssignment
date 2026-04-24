using UnityEngine;

public class GetShotGun : MonoBehaviour
{
    [SerializeField] private Transform MyTransform;
    [SerializeField] private float m_shotRange = 3.0f;
    [SerializeField] private RaycastHit[] m_hitList = new RaycastHit[100];

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)) ShotGunOnUpdate();
    }

    private void ShotGunOnUpdate()
    {
        int hitList = Physics.RaycastNonAlloc(ShotPosition(), MyTransform.right, m_hitList, m_shotRange);

        for (int i = 0; i < hitList; i++)
        {
            Destroy(m_hitList[i].collider.gameObject);
        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(ShotPosition(), MyTransform.right * m_shotRange);
    }

    private Vector3 ShotPosition()
    {
        var shotPosition = MyTransform.position;
        return shotPosition;
    }
}