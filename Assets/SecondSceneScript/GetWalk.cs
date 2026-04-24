using UnityEngine;

public class GetWalk : MonoBehaviour
{
    [SerializeField] private Transform MyTransform;
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space)) WalkingOnUpdate();
    }
    private void WalkingOnUpdate()
    {
        MyTransform.Translate(Vector3.right * 2 * Time.deltaTime, Space.Self);

    }
}
