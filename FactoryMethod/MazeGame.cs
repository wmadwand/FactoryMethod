using System;
namespace FactoryMethod
{
    public class MazeGame
    {
        public MazeGame()
        {
        }

        public Maze CreateMaze()
        {
            Maze aMaze = MakeMaze();

            Room r1 = MakeRoom(1);
            Room r2 = MakeRoom(2);
            Door door = MakeDoor(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            //r1.SetSide(Direction.North);
            //r1.SetSide(Direction.South);
            //r1.SetSide(Direction.East);
            //r1.SetSide(Direction.West);

            return aMaze;

        }

        public virtual Maze MakeMaze()
        {
            return new Maze();
        }

        public virtual Room MakeRoom(int n)
        {
            return new Room(n);
        }

        public virtual Wall MakeWall()
        {
            return new Wall();
        }

        public virtual Door MakeDoor(Room r1, Room r2)
        {
            return new Door();
        }
    }
}
