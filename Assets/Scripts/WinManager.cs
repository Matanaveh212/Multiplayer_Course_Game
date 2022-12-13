using UnityEngine;
using Photon.Pun;
using TMPro;

public class WinManager : MonoBehaviourPunCallbacks
{
    public Canvas canvas;
    public TMP_Text nameText;

    public void OnPlayerWon(string playerName)
    {
        nameText.text = playerName + " Won!";
        canvas.gameObject.SetActive(true);
    }

    public void OnLeavePressed()
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnLeftRoom()
    {
        PhotonNetwork.LoadLevel("Lobby");
    }
}
