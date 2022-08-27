using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField]
    private int health;
    [SerializeField]
    private int damage;
    [SerializeField]
    private Sprite characterSwap;
    [SerializeField]
    private ScriptableObjectCharacter scripableObject;

    // Start is called before the first frame update
    void Start()
    {
        health = scripableObject.health;
        damage = scripableObject.damage;
        characterSwap = scripableObject.characterSwap;

        
        this.gameObject.GetComponent<SpriteRenderer>().sprite = characterSwap;
    }
}
