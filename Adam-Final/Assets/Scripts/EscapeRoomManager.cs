
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EscapeRoomManager : MonoBehaviour
{
    public XRSocketInteractor[] sockets; 
    public GameObject button;
    public GameObject stand;
    public GameObject falseButton;
    public GameObject falseStand;          

    void Start()
    {
        button.SetActive(false);
        falseButton.SetActive(true); 
        stand.SetActive(false); 
        falseStand.SetActive(true); 
    }

    void Update()
    {
        CheckSockets();
    }

    void CheckSockets()
    {
        foreach (var socket in sockets)
        {
            if (!socket.hasSelection)
            {
                
                return;
            }
        }
        button.SetActive(true);
        falseButton.SetActive(false); 
        stand.SetActive(true); 
        falseStand.SetActive(false);
    }
}
