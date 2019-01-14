using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {

	public float mana;
	public float manaRegeneration;
	public int health;
	public bool canAttack;
	public bool turnBlocked;
	//this wil call the character powers
	IAbilities characterPower;
	CharacterStats a;

	void Start()
	{
		characterPower = gameObject.GetComponent<IAbilities>();
		a = gameObject.GetComponent<CharacterStats>();
	}

	void Update()
	{
		ReadInput();
		if(mana >= 100){
			canAttack = true;
		}
	}

	void ReadInput(){
		if (Input.GetKeyDown(KeyCode.W))
		{
			if(canAttack){
				characterPower.SpecialAttack();
				canAttack = false;
			}
		}
		if(Input.GetKeyDown(KeyCode.S)){
            if (canAttack)
            {
                characterPower.MainAttack();
                canAttack = false;
            }
		}
		//Read all input and do the right behavior
	}
}
