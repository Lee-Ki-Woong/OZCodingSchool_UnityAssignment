using Unity.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    // [Field] ====================================================
    #region Field

    private Rigidbody m_playerRigidbody;
    private GameObject m_playerGameObject;
    private Transform m_playerTransform;
    private float MoveX = 0;

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
        PlayerRotate();
        PlayerJump();
    }

    // [Get] ====================================================

    private void GetPlayerRigidbody()
    {
        m_playerRigidbody = this.transform.GetComponent<Rigidbody>();
    }

    private void GetPlayerGameObject()
    {
        m_playerGameObject = this.gameObject;
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

    private void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && JumpCount < 2)
        {
            m_playerRigidbody.AddForce(Vector3.up * JumpPoint, ForceMode.Impulse);
            JumpCount++;
        }
    }

    private void PlayerRotate()
    {
        float mouseX = Input.GetAxis("Mouse X");

        MoveX += mouseX * RotateSpeed * Time.deltaTime;
        m_playerTransform.rotation = Quaternion.Euler(0, MoveX, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            JumpCount = 0;
        }
    }
}
