using System.Collections;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public GameObject prefab; // ������ ������
    public Vector3 spawnPosition; // ���� ��ġ
    public float spawnInterval = 3f; // ���� ����

    private void Start()
    {
        // 3�ʸ��� SpawnPrefab() �޼��带 ȣ���ϴ� �ڷ�ƾ ����
        StartCoroutine(SpawnPrefabCoroutine());
        spawnPosition = new Vector3(0f, 15f, 0f);
    }

    private IEnumerator SpawnPrefabCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            // ������ ��ġ�� ������ ����
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }
}