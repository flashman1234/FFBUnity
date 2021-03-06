﻿using Fumbbl.Model.Types;

namespace Fumbbl.View
{
    public class PushbackSquare : IKeyedObject<PushbackSquare>
    {
        public Coordinate Coordinate { get; set; }
        public string Direction;
        public bool HomeChoice;
        public bool Locked;
        public bool Selected;

        public object Key => Coordinate.X * 100 + Coordinate.Y;

        public PushbackSquare(Ffb.Dto.ModelChanges.PushbackSquare square)
        {
            Coordinate = Coordinate.Create(square.coordinate);
            Direction = square.direction.key;
            HomeChoice = square.homeChoice;
            Locked = square.locked;
            Selected = square.selected;
        }

        public void Refresh(PushbackSquare square)
        {
            Coordinate = square.Coordinate;
            Direction = square.Direction;
            HomeChoice = square.HomeChoice;
            Locked = square.Locked;
            Selected = square.Selected;
        }
    }
}
