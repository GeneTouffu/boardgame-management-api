namespace Boardgame_Management.Domain.BoardGames;

public class BoardGame
{
 public Guid Id { get; private set; }
 public string Title { get; private set; }
 public int PlayerCount { get; private set; }
 public CollectionStatus CollectionStatus { get; private set; } = CollectionStatus.NotOwned;


public BoardGame(string title, int playerCount)
 {
  Id = Guid.NewGuid();
  Title = title;
  PlayerCount = playerCount;
 }
public BoardGame(string title, int playerCount, CollectionStatus collectionStatus)
 {
  Id = Guid.NewGuid();
  Title = title;
  PlayerCount = playerCount;
  CollectionStatus = collectionStatus;
 }

public void UpdateCollectionStatus(CollectionStatus newStatus)
 {
  CollectionStatus = newStatus;
 }

public void UpdatePlayerCount(int newPlayerCount)
 {
  PlayerCount = newPlayerCount;
 }

public void UpdateTitle(string newTitle)
 {
  Title = newTitle;
 }


}
