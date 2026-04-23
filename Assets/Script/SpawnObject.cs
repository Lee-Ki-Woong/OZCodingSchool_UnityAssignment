using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject NewGameObject;
    public Transform Transform_Spawn;
    public GameObject SpawnPrefabPoint;
    public int m_number = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnEnable()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnPrefabOnUpdate();
        }
    }

    private void SpawnPrefabOnUpdate()
    {

        m_number++;
        NewGameObject.name = $"Object{m_number}";
        Instantiate(NewGameObject, Transform_Spawn);
    }
}
