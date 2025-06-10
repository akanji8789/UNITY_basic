using UnityEngine;

public class StarPrinter : MonoBehaviour
{
    public int lineCount = 5;

    void Start()
    {
        Debug.Log("⭐ 정방향 별 찍기 ⭐");
        PrintIncreasingStars();

        Debug.Log("⭐ 역방향 별 찍기 ⭐");
        PrintDecreasingStars();
    }

    void PrintIncreasingStars()
    {
        for (int i = 1; i <= lineCount; i++)
        {
            string stars = new string('*', i);
            Debug.Log(stars);
        }
    }

    void PrintDecreasingStars()
    {
        for (int i = lineCount; i >= 1; i--)
        {
            string stars = new string('*', i);
            Debug.Log(stars);
        }
    }
}