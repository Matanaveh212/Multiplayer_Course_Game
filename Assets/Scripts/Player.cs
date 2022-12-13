using UnityEngine;
using Photon.Pun;
using TMPro;

public class Player : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text scoreText;
    int score;
    string playerName;

    void Start()
    {
        score = 0;
        scoreText.text = score.ToString() + " / 5";

        playerName = GetComponentInParent<PhotonView>().Owner.NickName;
        nameText.text = playerName;
    }

    private void OnCollisionEnter(Collision collision)
    {
        transform.position = SpawnManager.Instance.GetSpawnPoint().position;
        transform.rotation = SpawnManager.Instance.GetSpawnPoint().rotation;
    }

    public void OnRingCollected()
    {
        score++;
        scoreText.text = score.ToString() + " / 5";

        if (score >= 3)
        {
            FindObjectOfType<WinManager>().OnPlayerWon(playerName);
        }
    }

}
