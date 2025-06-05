using UnityEngine;

public class MySelf : MonoBehaviour
{
    string myName = "조규현";
    int age = 26;
    float height = 172.0f;
    float weight = 65.0f;
    string location = "대구";
    string hobby = "음악감상";
    string favoriteGame = "롤";
    string[] favoriteSports = { "풋살", "헬스" };
    string alcoholLimit = "소주 한 병";
    string mbti = "INTP";

    void PrintMyInfo()
    {
        Debug.Log("이름: " + myName);
        Debug.Log("나이: 만 " + age + "살");
        Debug.Log("키: " + height + "cm");
        Debug.Log("몸무게: " + weight + "kg");
        Debug.Log("사는 곳: " + location);
        Debug.Log("취미: " + hobby);
        Debug.Log("좋아하는 게임: " + favoriteGame);
        Debug.Log("좋아하는 운동: " + string.Join(", ", favoriteSports));
        Debug.Log("주량: " + alcoholLimit);
        Debug.Log("MBTI: " + mbti);
    }

    void Start()
    {
        PrintMyInfo();
    }
}