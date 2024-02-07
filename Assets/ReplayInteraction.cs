using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReplayInteraction : MonoBehaviour
{
    [SerializeField] Button replayButton;
    private void Awake()
    {
        replayButton.onClick.AddListener(Replay);
    }
    void Replay()
    {
        SceneManager.LoadScene(1);
    }
}
