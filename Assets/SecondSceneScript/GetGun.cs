using UnityEngine;

public class GetGun : MonoBehaviour
{
    [SerializeField] private Transform MyTransform;
    [SerializeField] private float m_shotRange = 5.0f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) GunOnUpdate();
    }

    private void GunOnUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(ShotPosition(), MyTransform.right, out hit, m_shotRange))
        {

            Destroy(hit.collider.gameObject);
        }

    }
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