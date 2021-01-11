using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private int _count;
    [SerializeField] private Text score;

    private void Start() => score.text = $"Score: {_count}";

    public void SetScore()
    {
        _count++;
        score.text = $"Score: {_count}";
    }

    public void ClearScore() => _count = 0;
}
