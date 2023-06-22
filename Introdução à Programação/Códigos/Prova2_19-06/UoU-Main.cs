using System;

public class UoU
{
        private static readonly short STARTING = 0;
        private static readonly short RUNNING = 1;
        private static readonly short GAMEOVER = 2;
        private static readonly short VIDA = 80;

        private short Status;

        public UoU() 
        {
          this.Status = UoU.STARTING;
        }

        public void Print()
        {
         Console.WriteLine(this.Status);
        }

        public static void Main ()
        {
            UoU game = new UoU ();

            game.Print();

        }
}