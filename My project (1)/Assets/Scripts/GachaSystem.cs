using System.Collections.Generic;
using UnityEngine;

public class GachaSystem : MonoBehaviour
{
    List<string> characters = new List<string>()
    {
        "헥터", "린", "레니", "그웬",
        "미야", "아모세", "몰리", "플린트",
        "필리", "지나", "제시", "바히티"
    };


    void Start()
    {
        PerformGacha();
    }


    void PerformGacha()
    {
        Debug.Log("🔮 10연차 뽑기 결과 🔮");

        for (int i = 0; i < 10; i++)
        {
            int randomIndex = Random.Range(0, characters.Count);
            string drawnCharacter = characters[randomIndex];
            Debug.Log((i + 1) + "번째 뽑기: " + drawnCharacter);
        }
    }
}