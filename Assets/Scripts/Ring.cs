using UnityEngine;

public class Ring : MonoBehaviour
{
    public Material orangeMat;
    public Material blueMat;

    bool isTaken;

    void Start()
    {
        GetComponent<MeshRenderer>().material = orangeMat;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!isTaken)
        {
            isTaken = true;

            GetComponent<MeshRenderer>().material = blueMat;
            other.GetComponent<Player>().OnRingCollected();
        }

    }
}
