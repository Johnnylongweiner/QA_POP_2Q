
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Input : MonoBehaviour
{
    [SerializeField] Swordsman swordsman;
    [SerializeField] Archer archer;
    [SerializeField] Mage mage;
    [SerializeField] knight knight;
    [SerializeField] DemonKing king;

    private string PlayerLabel = "Pick Your Hero";
    private string CompanionLabel = "Your Knight Has Arrived";
    private string BossLabel = "The Ground Starts Shaking*";
    private string Battle = "Fight!!";
    private PlayerStats Player;

    private void OnGUI()
    {
        var FontSize = 20;


        UnityEngine.GUI.Label(new Rect(350, 470, 1000, 1000), PlayerLabel);
        UnityEngine.GUI.Label(new Rect(20, 400, 1000, 1000), CompanionLabel);
        UnityEngine.GUI.Label(new Rect(950, 100, 1000, 1000), BossLabel);
        UnityEngine.GUI.Label(new Rect(690, 350, 100, 100), Battle);
        UnityEngine.GUI.skin.label.fontSize = FontSize;

        if (UnityEngine.GUI.Button(new Rect(25, 600, 150, 50), "Swordsman"))
        {
            Player = swordsman;
            PlayerLabel = "Player: " + "\nHealth: " + swordsman.Health + "\nAttack: " + swordsman.Attack + "\nDefences: " + swordsman.Defense;
        }

        if (UnityEngine.GUI.Button(new Rect(250, 600, 150, 50), "Archer"))
        {
            Player = archer;
            PlayerLabel = "Player: " + "\nHealth: " + archer.Health + "\nAttack: " + archer.Attack + "\nDefences: " + archer.Defense;
        }

        if (UnityEngine.GUI.Button(new Rect(490, 600, 150, 50), "Mage"))
        {
            Player = mage;
            PlayerLabel = "Player: " + "\nHealth: " + mage.Health + "\nAttack: " + mage.Attack + "\nDefences: " + mage.Defense;
        }

        if (UnityEngine.GUI.Button(new Rect(25, 500, 150, 50), "Companion Knight"))
        {
            CompanionLabel = "Companion Knight: " + "\nHealth: " + knight.Health + "\nAttack: " + knight.Attack + "\nDefences: " + knight.Defences;
        }

        if (UnityEngine.GUI.Button(new Rect(1050, 350, 150, 50), "Demon King"))
        {
            BossLabel = "Demon King: " + "\nHealth: " + king.Health + "\nAttack: " + king.Attack + "\nDefences: " + king.Defences;
        }

        if (UnityEngine.GUI.Button(new Rect(1050, 500, 150, 50), "HIT!"))
        {
            if (king != null)
            {
                king.Health -= Player.Attack;
            }
            if (Player != null)
            {
                Player.Health -= king.Attack;
            }
            if (knight != null)
            {
                knight.Health -= king.Attack;
            }
            AttackDamage();

            if (king.Health <= 0)
            {
                PlayerLabel = "";
                CompanionLabel = "";
                BossLabel = "";
                Battle = "Player Wins!";
            }

            if (Player.Health <= 0)
            {
                PlayerLabel = "";
                CompanionLabel = "";
                BossLabel = "";
                Battle = "Demon King Wins!";
            }

            if (knight.Health <= 0)
            {
                knight.Health = 0;
            }
        }
    }

    private void AttackDamage()
    {
        BossLabel = "Demon King: " + "\nHealth: " + king.Health + "\nAttack: " + king.Attack + "\nDefences: " + king.Defences;
        PlayerLabel = "Player: " + "\nHealth: " + Player.Health + "\nAttack: " + Player.Attack + "\nDefences: " + Player.Defense;
        CompanionLabel = "Companion Knight: " + "\nHealth: " + knight.Health + "\nAttack: " + knight.Attack + "\nDefences: " + knight.Defences;
    }

}

