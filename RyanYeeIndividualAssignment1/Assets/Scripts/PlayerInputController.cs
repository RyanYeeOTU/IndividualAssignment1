using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public PlayerAction inputAction;
    public static PlayerInputController controller;
    private void OnEnable()
    {
        inputAction.Enable();
    }
    private void OnDisable()
    {
        inputAction.Disable();

    }
    // Start is called before the first frame update
    void Awake()
    {
       
        inputAction = new PlayerAction();   
    }

    
}
