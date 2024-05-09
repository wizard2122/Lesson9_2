using System;

public class GameplayMediator : IDisposable
{
    private readonly Level _level;
    private readonly DefeatPanel _defeatPanel;
    
    public GameplayMediator(Level level, DefeatPanel defeatPanel)
    {
        _level = level;
        _defeatPanel = defeatPanel;
        _level.Defeat += OnLevelDefeat;
        _defeatPanel.LevelRestarting += RestartLevel;
    }

    private void OnLevelDefeat() => _defeatPanel.Show();

    public void Dispose()
    {
        _level.Defeat -= OnLevelDefeat;
        _defeatPanel.LevelRestarting -= RestartLevel;
    }
    
    private void RestartLevel()
    {
        _defeatPanel.Hide();
        _level.Restart();
    }
}
