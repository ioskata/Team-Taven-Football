namespace TeamTavenFootball.Interfaces
{
    using TeamTavenFootball.Vector;

    public interface IGameObject
    {
        string Name { get; }
        Vector2D Position { get; }
        bool Active { get; }
    }
}
