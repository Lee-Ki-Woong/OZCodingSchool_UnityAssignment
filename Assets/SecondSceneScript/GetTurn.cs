using UnityEngine;

public class GetTurn : MonoBehaviour
{
    [SerializeField] private Transform MyTransform;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            RightTurn();
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            LeftTurn();
        }
    }

    private void RightTurn()
    {
        MyTransform.rotation = Quaternion.Euler(0, 90f, 0);
    }

    private void LeftTurn()
    {
        MyTransform.rotation = Quaternion.Euler(0, -90f, 0);
    }
}
