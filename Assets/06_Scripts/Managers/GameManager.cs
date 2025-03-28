public class GameManager : Singleton<GameManager>
{
    public PlayerController Player { get; private set; }

    protected override void Initialize()
    {
        SetDontDestroyOnLoad();

        Player = FindAnyObjectByType<PlayerController>();
    }
}