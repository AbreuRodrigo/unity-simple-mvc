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
            player.dead.AddObserver(OnPlayerDied);
        }
	}

    private void OnPlayerLifeChanges(int life)
    {
        playerView.UpdateLife(life);
    }

    private void OnPlayerDied(bool dead)
    {
        if (dead)
        {
            Debug.Log("Player died");
        }
    }
}
