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
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        health = UserPrefs.bundle.LoadAsset<ScriptableObjectCharacter>("Assets/DeathWing.asset").health;
        damage = UserPrefs.bundle.LoadAsset<ScriptableObjectCharacter>("Assets/DeathWing.asset").damage;
        characterSwap = UserPrefs.bundle.LoadAsset<ScriptableObjectCharacter>("Assets/DeathWing.asset").characterSwap;

        this.gameObject.GetComponent<SpriteRenderer>().sprite = characterSwap;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("pilinha");
            gameManager.score += 10;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            gameManager.UploadCaller();
        }
    }
}
