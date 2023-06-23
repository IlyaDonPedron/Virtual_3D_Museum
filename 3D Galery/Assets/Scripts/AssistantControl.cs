using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssistantControl : MonoBehaviour
{
    public Transform player;
    void Update()
    {
        transform.LookAt(player.position);
    }
}
