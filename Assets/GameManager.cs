/* Using UnityEngine;
Using System.Collections;

public enum GameStates {
    Launchpad,
    Home,
    Collect,
    Inventory,
    SignUp,
    SignIn,
    About;
}
public delegate void OnStateChangedHandler ();

public class GameManager {
    protected GameManager () { }
    private static GameManager instance = null;

    public event OnStateChangedHandler OnStateChanged;
    public GameStates gameState { get; private set; }

    public static GameManager Instance {
        get {
            if (GameManager.instance == null) {
                DontDestroyOnLoad (GameManager.instance);
                GameManager.instance = new GameManager ();
            }
            return GameManager.instance;
        }
    }
    public void SetGamesTate (GameStates state) {
        this.gameState = state;
        OnStateChanged ();
    }
    public void OnApplicationQuit () {
        GameManager.instance == null;
    }
} */