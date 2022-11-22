using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.ActionEvent onFoot;
    // Start is called before the first frame update
    void Awake()
    {
        playerInput = new PlayerInput;
        onFoot = PlayerInput.Onfoot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
