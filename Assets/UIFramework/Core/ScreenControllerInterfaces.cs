using System;

namespace UIFramework {
    /// <summary>
    /// Interface that all UI Screens must implement directly or indirectly
    /// </summary>
    public interface IScreenController {
        string ScreenId { get; set; }
        bool IsVisible { get; }

        void Show(IScreenProperties props = null);
        void Hide(bool animate = true);

        Action<IScreenController> InTransitionFinished { get; set; }
        Action<IScreenController> OutTransitionFinished { get; set; }
        Action<IScreenController> CloseRequest { get; set; }
        Action<IScreenController> ScreenDestroyed { get; set; }
    }

    /// <summary>
    /// Interface that all Windows must implement
    /// </summary>
    public interface IWindowController : IScreenController {
        bool HideOnForegroundLost { get; }
        bool IsPopup { get; }
        WindowPriority WindowPriority { get; }
    }

    /// <summary>
    /// Interface that all Panels must implement
    /// </summary>
    public interface IPanelController : IScreenController {
        PanelPriority Priority { get; }
    }
}
