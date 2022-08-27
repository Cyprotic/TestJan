using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "ScriptableObjects/ScriptableObjectCharacter", order = 1)]
public class ScriptableObjectCharacter : ScriptableObject
{
    public int health;
    public int damage;
    public Sprite characterSwap;
}
