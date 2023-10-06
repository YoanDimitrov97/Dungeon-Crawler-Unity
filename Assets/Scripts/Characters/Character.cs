using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Character/Character", order = 0)]
public class Character : ScriptableObject {
    new public string name = "";
    public Texture2D sprite;
    public int SPD = 0;
    public int HP = 0;
    public int MANA = 0;
    public int ATK = 0;
    public int DEF = 0;
    public int WIS = 0;
    public int RES = 0;


    public Role role;
    public Race race;
}