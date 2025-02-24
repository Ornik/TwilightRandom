﻿using System.ComponentModel.DataAnnotations;

namespace Twilight.Domain;

public class Game
{
    public int Id { get; set; }
    public virtual List<PlayerSlot> PlayerSlots { get; set; } = new();

    public required string Name { get; set; }

    [MaxLength(20)]
    public required string Slug { get; set; }
}

public class PlayerSlot
{
    public int Id { get; set; }
    public int GameId { get; set;}
    public virtual Game Game { get; set;}
    public int PlayerId { get; set; }
    public virtual Player Player { get; set;} 
    public PlayerColor Color { get; set;}
    public List<Faction> PossibleFactions { get; set; } = new();
    public Faction? SelectedFaction { get; set; }

    [MaxLength(20)]
    public required string Slug { get; set; }
}
