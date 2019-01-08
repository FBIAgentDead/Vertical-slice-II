//this class wil manage both players mana and tell the players when they can attack

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaManager : MonoBehaviour {
	[SerializeField]
	List<CharacterStats> players = new List<CharacterStats>();
	[SerializeField]
	private List<Slider> manaBars = new List<Slider>();

	void Update()
	{
		if(!players[0].canAttack){
			if(!players[1].canAttack)
				SlideUp();
		}
	}

	private void SlideUp()
	{
        players[0].mana += Time.timeScale;
        players[1].mana += Time.timeScale;
		for(int i = 0; i < manaBars.Count; i++){
			manaBars[i].value = players[i].mana;
		}
	}
	
}
