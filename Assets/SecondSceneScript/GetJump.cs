using UnityEngine;

public class GetJump : MonoBehaviour
{
    [SerializeField] private Transform MyTransform;
    private bool m_jumpable = true;

    private void Update()
    {
        if (m_jumpable && Input.GetKey(KeyCode.LeftControl)) Jump();
        if (m_jumpable == false && MyTransform.position.y < 1 ) MaxPoint();
    }

    private void Jump()
    {
        MyTransform.Translate(Vector3.up * 0.04f);
        if (MyTransform.position.y > 2) m_jumpable = false;    
    }

    private void MaxPoint()
    {
        m_jumpable = true;
    }
}
