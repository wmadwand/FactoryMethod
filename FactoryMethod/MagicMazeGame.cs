using System;
namespace FactoryMethod
{
    #region MagicMazeParts
    public class MagicRoom : Room
    {
        private string _spellForOpen;

        public MagicRoom(int number) : base(number)
        {

        }

        //specific stuff so that make room way more magic
    }

    public class MagicDoorNeedingSpell : Door
    {
        //specific stuff so that make room way more magic
    }
    #endregion

    public class MagicMazeGame : MazeGame
    {
        public MagicMazeGame()
        {
        }

        public override Room MakeRoom(int n)
        {
            return new MagicRoom(n);
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            return new MagicDoorNeedingSpell();
        }
    }
}
