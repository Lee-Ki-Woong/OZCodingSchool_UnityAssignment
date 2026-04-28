using Unity.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    // [Field] ====================================================
    #region Field
    private Rigidbody m_playerRigidbody;
    private GameObject m_playerGameObject;
    private Transform m_playerTransform;
    #endregion


    // [Inspector Field] ====================================================

    [SerializeField] private float PlayerMoveSpeed;
    [SerializeField] private float RotateSpeed;

    [SerializeField] private float JumpPoint;
    [SerializeField] private int JumpCount;

    // [Life Cycle] ====================================================

    private void OnEnable()
    {
        GetPlayerRigidbody();
        GetPlayerGameObject();
        GetPlayerTransform();
    }

    private void Update()
    {
        PlayerMove();
    }

    // [Get] ====================================================

    private void GetPlayerRigidbody()
    {
        m_playerRigidbody = this.gameObject.GetComponent<Rigidbody>();
    }

    private void GetPlayerGameObject()
    {
        m_playerGameObject = this.gameObject;
        Debug.Log("가나다라");
    }

    private void GetPlayerTransform()
    {
        m_playerTransform = this.transform;
    }


    // [Active] ================================================

    private void PlayerMove()
    {
        float AD = Input.GetAxis("Horizontal");
        float WS = Input.GetAxis("Vertical");

        Vector3 moving = new Vector3(AD, 0, WS);

        moving.Normalize();
        moving = m_playerTransform.TransformDirection(moving);

        m_playerRigidbody.MovePosition(m_playerRigidbody.position +  moving * PlayerMoveSpeed * Time.deltaTime);


    }
}
