using UnityEngine;
using Photon.Pun;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance;
    public GameObject playerPrefab;

    SpawnPoint[] spawnpoints;

    private void Awake()
    {
        Instance = this;

        spawnpoints = GetComponentsInChildren<SpawnPoint>();
        Transform spawn = GetSpawnPoint();

        PhotonNetwork.Instantiate(playerPrefab.name, transform.position, transform.rotation);
    }

    public Transform GetSpawnPoint()
    {
        return spawnpoints[Random.Range(0, spawnpoints.Length)].transform;
    }

}
