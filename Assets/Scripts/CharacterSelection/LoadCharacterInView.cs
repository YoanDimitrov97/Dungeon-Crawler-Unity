using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadCharacterInView : MonoBehaviour
{
    public Character[] characters;
    public Transform  m_ContentContainer;
    public GameObject prefabToInstantiate;
    // Start is called before the first frame update
    void Start()
    {
        foreach(Character i in characters){
            var m_character = Instantiate(prefabToInstantiate);
            m_character.GetComponentsInChildren<Image>()[1].sprite = Sprite.Create(i.sprite, new Rect(0, 0, i.sprite.width, i.sprite.height), Vector2.one * 0.5f);
            m_character.GetComponentInChildren<TextMeshProUGUI>().text = i.name;
            
            m_character.transform.SetParent(m_ContentContainer, false);
            //m_character.transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, -270f)
            m_character.transform.localScale = Vector2.one;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
