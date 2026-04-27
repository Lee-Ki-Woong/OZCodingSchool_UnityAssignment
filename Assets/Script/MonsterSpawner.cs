using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField] private GameObject MonsterPrefab;

    public void OnClickMonsterSpawnButton()
    {
        Instantiate(MonsterPrefab);
    }
}
