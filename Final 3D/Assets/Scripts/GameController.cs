using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _maxTimeSeconds;
    [SerializeField] private GameObject _startGameUI;
    [SerializeField] private GameObject _gameOverUI;

    // Add member variables to store references to all of the UI text.
    [SerializeField] private TMP_Text _timerText;
    [SerializeField] private TMP_Text _commonPointsText;
    [SerializeField] private TMP_Text _uncommonPointsText;
    [SerializeField] private TMP_Text _rarePointsText;
    [SerializeField] private TMP_Text _finalScoreText;

    private int _commonPoints;
    private int _uncommonPoints;
    private int _rarePoints;

    private float _timeRemaining;
    private bool _runGame;

    // ------------------------------------------------------------------------
    // You don't need to code anything in this method :)
    private void Start()
    {
        SetGameEnabled(false);
        UpdatePointsText();
    }

    // ------------------------------------------------------------------------
    private void Update()
    {
        if (_runGame)
        {
            _timeRemaining -= Time.deltaTime;

            // Update the game timer text.
            _timerText.text = _timeRemaining.ToString();
            if (_timeRemaining <= 0)
            {
                EndGame();
            }
        }
    }

    // ------------------------------------------------------------------------
    public void StartGame()
    {
        _startGameUI.SetActive(false);
        _gameOverUI.SetActive(false);
        
        SetGameEnabled(true);

        _timeRemaining = _maxTimeSeconds;

        // Update the game timer text.
        _timerText.text = _timeRemaining.ToString();
    }

    // ------------------------------------------------------------------------
    // You don't need to code anything in this method :)
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    // ------------------------------------------------------------------------
    private void EndGame()
    {
        SetGameEnabled(false);
        _gameOverUI.SetActive(true);

        // Update the final score text in the game over UI.
        SetGameEnabled(false);
        _gameOverUI.SetActive(true);

        int finalScore = _commonPoints + _uncommonPoints * 2 + _rarePoints * 3;
        _finalScoreText.text = finalScore.ToString();
    }

    // ------------------------------------------------------------------------
    // You don't need to code anything in this method :)
    private void SetGameEnabled(bool enabled)
    {
        Cursor.lockState = enabled ? CursorLockMode.Locked : CursorLockMode.None;
        _player.enabled = enabled;
        _runGame = enabled;
    }

    // ------------------------------------------------------------------------
    // Add a paramter to this method to represent the item's rarity.
    public void CollectItem (Rarity rarity)
    {
        // Using a SWITCH STATEMENT,
        // based on the item's rarity, update the appropriate points variable.
        switch (rarity)
        {
            case Rarity.Common:
                _commonPoints++;
                break;

            case Rarity.Uncommon:
                _uncommonPoints++;
                break;

            case Rarity.Rare:
                _rarePoints++;
                break;
        }



        UpdatePointsText();
    }

    // ------------------------------------------------------------------------
    public void RemoveItem (Rarity rarity)
    {
        // Using a SWITCH STATEMENT,
        // based on the item's rarity, update the appropriate points variable.
        switch (rarity)
        {   
            case Rarity.Common:
                _commonPoints--;
                break;

            case Rarity.Uncommon:
                _uncommonPoints--;
                break;

            case Rarity.Rare:
                _rarePoints--;
                break;
        }

        UpdatePointsText();
    }

    // ------------------------------------------------------------------------
    private void UpdatePointsText()
    {
        // Update your points text.
        /*
        _commonPointsText.text = _commonPoints.ToString();
        _uncommonPointsText.text = _uncommonPoints.ToString();
        _rarePointsText.text = _rarePoints.ToString();
        */
    }
}