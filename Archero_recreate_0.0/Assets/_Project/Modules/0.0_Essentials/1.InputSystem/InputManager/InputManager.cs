using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    #region Initialization/Subscribtion 
    public InputReader _inputReader;
    [Header("Input Values")]
    public Vector2 move = new Vector2();
    public Vector2 look = new Vector2();
    public bool jump = false;
    public bool sprint = false;
    public bool analogMovement = false;
    private void Start()
    {

        _inputReader.Activate();
        _inputReader.MoveEvent += OnMove;
        _inputReader.LookEvent += OnLook;
        _inputReader.JumpEvent += OnJump;
        _inputReader.SprintEvent += OnSprint;
    }
    private void OnApplicationQuit()
    {
        _inputReader.MoveEvent -= OnMove;
        _inputReader.LookEvent -= OnLook;
        _inputReader.JumpEvent -= OnJump;
        _inputReader.SprintEvent -= OnSprint;
    }
    #endregion

    #region Listeners
    public void OnMove(Vector2 dir) => move = dir;
    public void OnLook(Vector2 dir) => look = dir;
    public void OnJump(bool state) => jump = state;
    public void OnSprint(bool newSprintState) => sprint = newSprintState;
    #endregion
}
