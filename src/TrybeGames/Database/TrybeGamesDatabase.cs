namespace TrybeGames;

public class TrybeGamesDatabase
{
    public List<Game> Games = new List<Game>();

    public List<GameStudio> GameStudios = new List<GameStudio>();

    public List<Player> Players = new List<Player>();

    // 4. Crie a funcionalidade de buscar jogos desenvolvidos por um estúdio de jogos
    public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
    {
        var games = from game in Games
                    where game.DeveloperStudio == gameStudio.Id
                    select game;

        return games.ToList();

    }

    // 5. Crie a funcionalidade de buscar jogos jogados por uma pessoa jogadora
    public List<Game> GetGamesPlayedBy(Player player)
    {
        var games = from game in Games
                    where game.Players.Contains(player.Id)
                    select game;

        return games.ToList();
    }

    // 6. Crie a funcionalidade de buscar jogos comprados por uma pessoa jogadora
    public List<Game> GetGamesOwnedBy(Player playerEntry)
    {
        var games = from game in Games
                    where playerEntry.GamesOwned.Contains(game.Id)
                    select game;

        return games.ToList();
    }


    // 7. Crie a funcionalidade de buscar todos os jogos junto do nome do estúdio desenvolvedor
    public List<GameWithStudio> GetGamesWithStudio()
    {
        var games = from game in Games
                    join studio in GameStudios
                    on game.DeveloperStudio equals studio.Id
                    select new GameWithStudio
                    {
                        GameName = game.Name,
                        StudioName = studio.Name,
                        NumberOfPlayers = game.Players.Count
                    };
        return games.ToList();

    }

    // 8. Crie a funcionalidade de buscar todos os diferentes Tipos de jogos dentre os jogos cadastrados
    public List<GameType> GetGameTypes()
    {
        var typeGame = from game in Games
                       select game.GameType;

        return typeGame.Distinct().ToList();
    }

    // 9. Crie a funcionalidade de buscar todos os estúdios de jogos junto dos seus jogos desenvolvidos com suas pessoas jogadoras
    public List<StudioGamesPlayers> GetStudiosWithGamesAndPlayers()
    {
        // Implementar
        throw new NotImplementedException();
    }

}
