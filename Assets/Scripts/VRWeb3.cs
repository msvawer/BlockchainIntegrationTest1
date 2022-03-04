using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FusedVR.Web3;


public class VRWeb3 : MonoBehaviour
{
    public async void Authenticate()
    {
        if (await Web3Manager.Login("test", "michelle.vawer@icloud.com")) { }
        {
            Debug.LogError("AUTH");
        }
    }
}
