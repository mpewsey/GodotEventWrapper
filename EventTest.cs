using Godot;

[GlobalClass]
public partial class EventTest : Node
{
    // This is a delegate that would normally be wrapped with the Signal attribute.
    // [Signal]
    public delegate void OnHitPointsChangedEventHandler();

    // *** Generated Class Contents Begin Here ***
    private OnHitPointsChangedEventHandler backing_OnHitPointsChanged;

    public OnHitPointsChangedEventWrapper OnHitPointsChanged
    {
        get => new OnHitPointsChangedEventWrapper(this);
        set { } // This needs to be exposed so that we can use the += and -= operators, but it does nothing.
    }

    public readonly struct OnHitPointsChangedEventWrapper
    {
        /// The source type should match the generated class name.
        private EventTest Source { get; }

        public OnHitPointsChangedEventWrapper(EventTest source)
        {
            Source = source;
        }

        public static OnHitPointsChangedEventWrapper operator +(OnHitPointsChangedEventWrapper wrapper, OnHitPointsChangedEventHandler value)
        {
            if (IsInstanceValid(wrapper.Source))
                wrapper.Source.backing_OnHitPointsChanged += value;
            return wrapper;
        }

        public static OnHitPointsChangedEventWrapper operator -(OnHitPointsChangedEventWrapper wrapper, OnHitPointsChangedEventHandler value)
        {
            if (IsInstanceValid(wrapper.Source))
                wrapper.Source.backing_OnHitPointsChanged -= value;
            return wrapper;
        }

        /// The signature of this would changed based on signal arguments.
        public void Emit()
        {
            if (IsInstanceValid(Source))
                Source.backing_OnHitPointsChanged?.Invoke();
        }
    }

    // *** Example Usage Begins Here ***
    public override void _Ready()
    {
        base._Ready();
        OnHitPointsChanged += Action1;
        OnHitPointsChanged += Action2;
        OnHitPointsChanged.Emit();
        OnHitPointsChanged -= Action2;
        OnHitPointsChanged.Emit();
    }

    private void Action1()
    {
        GD.Print("Action 1 Fired.");
    }

    private void Action2()
    {
        GD.Print("Action 2 Fired.");
    }
}