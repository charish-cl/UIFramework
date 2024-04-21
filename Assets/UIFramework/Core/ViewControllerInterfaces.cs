using System;

namespace UIFramework {
    /// <summary>
    /// Interface that all UI Screens must implement directly or indirectly
    /// </summary>
    public interface IViewController {
        string ScreenId { get; set; }
        bool IsVisible { get; }

        void Show(IViewProperties props = null);
        void Hide(bool animate = true);

        Action<IViewController> InTransitionFinished { get; set; }
        Action<IViewController> OutTransitionFinished { get; set; }
        Action<IViewController> CloseRequest { get; set; }
        Action<IViewController> ScreenDestroyed { get; set; }
    }

    /// <summary>
    /// Interface that all Windows must implement
    /// </summary>
    public interface IWindowController : IViewController {
        bool HideOnForegroundLost { get; }
        bool IsPopup { get; }
        WindowPriority WindowPriority { get; }
    }

    /// <summary>
    /// Interface that all Panels must implement
    /// </summary>
    public interface IPanelController : IViewController {
        PanelPriority Priority { get; }
    }
}
