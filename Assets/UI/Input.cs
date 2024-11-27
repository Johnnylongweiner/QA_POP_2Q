
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Input : MonoBehaviour
{
    public Texture ButtonImage;
    public Vector2 position; 
    public Vector2 size;

    private void OnGUI()
    {
       
        GUI.Box(new Rect(10, 5, 1450, 718 ), "GAME!");

        if (GUI.Button(new Rect(50, 70, 150, 150), "Archer"))
        {
            Player = archer;
            PlayerLabel = "Player: " + "\nHealth: " + archer.Health + "\nAttack: " + archer.Attack + "\nDefences: " + archer.Defense;
        }
        if (GUI.Button(new Rect(50, 280, 150, 150), "Swordman"))
        {
            Player = swordsman;
            PlayerLabel = "Player: " + "\nHealth: " + swordsman.Health + "\nAttack: " + swordsman.Attack + "\nDefences: " + swordsman.Defense;
        }
        if (GUI.Button(new Rect(50, 480, 150, 150), "Mage"))
        { 
            Player = mage;
            PlayerLabel = "Player: " + "\nHealth: " + mage.Health + "\nAttack: " + mage.Attack + "\nDefences: " + mage.Defense;
        }
        if (GUI.Button(new Rect(300, 280, 150, 150), "Fight"))
        {


        }

       GUI.Label(new Rect(50, 5, 150, 150), PlayerLabel);
       GUI.Label(new Rect(250, 700, 1000, 1000), CompanionLabel);
       GUI.Label(new Rect(1000, 280, 150, 150), BossLabel);
       GUI.Label(new Rect(600, 280, 150, 150), Battle);
      
    }

    [SerializeField] Swordsman swordsman;
    [SerializeField] Archer archer;
    [SerializeField] Mage mage;
    [SerializeField] knight knight;
    [SerializeField] DemonKing king;

    private string PlayerLabel = "Pick Your Fighter";
    private string CompanionLabel = "The Knight has Arrived";
    private string BossLabel = "*The Ground Starts to Shake";
    private string Battle = "FIGHT!!";
    private PlayerStats Player;

    
}

