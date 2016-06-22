namespace TeamTavenFootball.Interfaces
{
    using TeamTavenFootball.Vector;

    public interface IMovable
    {
        Vector2D Move(Vector2D positionToGo);
    }
}
