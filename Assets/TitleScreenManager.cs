using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

// Defining the Scope of the StartGame Title Screen in the Project
namespace StartGame
{
    public class TitleScreenManager : MonoBehaviour
    {
        public void StartNetworkAsHost()
        {
            NetworkManager.Singleton.StartHost();
        }
    }
}