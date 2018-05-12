using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Model")]
    public Player player;

    [Header("View")]
    public PlayerView playerView;

	void Start ()
    {
		if(player != null)
        {
            player.life.AddObserver(OnPlayerLifeChanges);
        }
	}

    private void OnPlayerLifeChanges(int life)
    {
        if (playerView != null && playerView.life != null)
        {
            playerView.life.text = "Life: " + life.ToString();
        }
    }
}
