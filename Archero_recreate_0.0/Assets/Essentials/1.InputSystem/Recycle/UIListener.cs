using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UIListener : MonoBehaviour
{
    public TextMeshProUGUI moveText;
    public TextMeshProUGUI lookText;
    public Image JumpImage;
    public Image SprintImage;
    public Image PauseImage;
    private bool isPaused = false;
    public Image TestImage;
    private void Start()
    {
        InputManager.Instance._inputReader.MoveEvent += UpdateMoveText;
        InputManager.Instance._inputReader.LookEvent += UpdateLookText;

        InputManager.Instance._inputReader.JumpEvent += UpdateJumpImage;
        InputManager.Instance._inputReader.SprintEvent += UpdateSprintImage;
        InputManager.Instance._inputReader.PauseEvent += UpdatePauseImage;
        InputManager.Instance._inputReader.TestEvent += UpdateTestImage;
    }
    private void OnApplicationQuit()
    {
        InputManager.Instance._inputReader.MoveEvent -= UpdateMoveText;
        InputManager.Instance._inputReader.LookEvent -= UpdateLookText;

        InputManager.Instance._inputReader.JumpEvent -= UpdateJumpImage;
        InputManager.Instance._inputReader.SprintEvent -= UpdateSprintImage;
        InputManager.Instance._inputReader.PauseEvent -= UpdatePauseImage;
        InputManager.Instance._inputReader.TestEvent -= UpdateTestImage;
    }
    public void UpdateMoveText(Vector2 dir)
    {
        moveText.text = $"Movement X: {dir.x:F2} Y: {dir.y:F2}"; // Show only 2 decimals after Commata
    }
    public void UpdateLookText(Vector2 dir)
    {
        lookText.text = $"Looking' X: {dir.x:F2} Y: {dir.y:F2}"; // Show only 2 decimals after Commata
    }
    public void UpdateJumpImage(bool status) => JumpImage.color = status ? Color.green : Color.red;
    public void UpdateSprintImage(bool status) => SprintImage.color = status ? Color.green : Color.red;
    public void UpdatePauseImage()
    {
        isPaused = !isPaused;
        PauseImage.color = isPaused ? Color.green : Color.red;
    }
    public void UpdateTestImage(bool status) => TestImage.color = status ? Color.green : Color.red;
}
