namespace PoeLurker.UI.Services;

using PoeLurker.Patreon.Services;

/// <summary>
/// Pushover service with Lurker Pro pledge gate permanently unlocked.
/// Sets the inherited pledge flag at construction so push delivery works
/// without contacting Patreon; no pledge check or login is ever performed.
/// </summary>
public class UnlockedPushHoverService : PushHoverService
{
    public UnlockedPushHoverService()
    {
        _isPledging = true;
    }
}
