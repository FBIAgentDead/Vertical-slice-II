//this class wil manage both players mana and tell the players when they can attack

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaManager : MonoBehaviour {

	//Player[] 1&2 = getcomponent; so that we can set a bool true when players can attack
	[SerializeField]
	private List<Slider> manaBars = new List<Slider>();
	private List<float> playerMana = new List<float>();

	void Start()
	{
		playerMana.Add(30);
        playerMana.Add(50);
	}

	void Update()
	{
		if(playerMana[0] <= 100){
			if(playerMana[1] <= 100)
				SlideUp();
		}
	}

	private void SlideUp()
	{
		playerMana[0] += Time.timeScale;
		playerMana[1] += Time.timeScale;
		for(int i = 0; i < manaBars.Count; i++){
			manaBars[i].value = playerMana[i];
		}
	}

	//this wil be in the player class but for now is tested here
	public void Attackplayer1(){
		if(playerMana[0] >= 100){
			Debug.Log("attack");
			playerMana[0] -= 50;
		}
	}

	public void Attackplayer2(){
        if (playerMana[1] >= 100)
        {
            Debug.Log("attack");
            playerMana[1] -= 70;
        }
	}
	
}
