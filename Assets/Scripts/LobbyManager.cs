using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    public TMP_Text usernameInputField;
    public void JoinOrCreateRoom()
    {
        if(usernameInputField.text.Length >= 1)
        {
            PhotonNetwork.NickName = usernameInputField.text;
            PhotonNetwork.JoinRandomRoom();
        }
    }   

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = 2 });
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
