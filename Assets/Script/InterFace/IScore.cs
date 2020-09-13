using Assets.Data;

public interface IScore
{
    void ShowScore(string name,float score);
    void ShowScore(Score score);
    void ShowScore(float score);
}