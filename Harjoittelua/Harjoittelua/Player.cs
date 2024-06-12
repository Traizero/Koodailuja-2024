using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Harjoittelua
{

    // holds all the player information
    internal class Player
    {
        public class Storage
        {
            List<Ball> ball = new List<Ball>();
        }

        Player player { get; set; }
        int playerSPD = 100;
        int playerAcc = 30;

        public void addBall(Ball ball)
        {
            ball.Add(ball);
            Console.WriteLine("Player got a ball!");
        }



        //handles the play logic
        internal void playBall()
        {


            //Ball newBall = ball.getBall();
            //player.Add(newBall);
        }



    }


}
