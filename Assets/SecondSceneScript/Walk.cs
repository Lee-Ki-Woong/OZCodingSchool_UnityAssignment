using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    [SerializeField] private GameObject myObject;
    [SerializeField] private Transform myTransform;
    [SerializeField] private float m_shotRange = 5.0f;
    private bool m_jumpable = true;

    private void Update()
    {
        Turn();
        Walking();
        MaxJump();
        Jumping();
        Shot();
    }

    private void Walking()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            myObject.transform.Translate(Vector3.right * 2 * Time.deltaTime, Space.Self);
        }
    }

    private void MaxJump()
    {
        if(myObject.transform.position.y > 2)
        {
            m_jumpable = false;
        }
        else if(myObject.transform.position.y < 1)
        {
            m_jumpable = true;
        }
    }


    private void Jumping()
    {
        if(Input.GetKey(KeyCode.LeftControl) && m_jumpable)
        {
            myObject.transform.Translate(Vector3.up *0.05f);
        }
    }
    
    private void Turn()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            myObject.transform.rotation = Quaternion.Euler(0, -90f, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            myObject.transform.rotation = Quaternion.Euler(0, 90f, 0);
        }
    }

    private void Shot()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            RaycastHit[] hits;
            hits = Physics.RaycastAll(ShotPosition(), transform.right, m_shotRange);

            List<RaycastHit> hitList = new List<RaycastHit>();

            for (int i = 0; i < hits.Length; i++)
            {
                hitList.Add(hits[i]);
            }

            Destroy(hits[1].collider.gameObject);


        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(ShotPosition(), transform.right * m_shotRange);
    }

    private Vector3 ShotPosition()
    {
        var shotPosition = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
        return shotPosition;
    }
}
