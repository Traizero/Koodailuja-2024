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
        int playerStamina = 100;
        bool playerHasBall = false;

        public void addBall(Ball ball)
        {
            storage.balls.Add(ball);
            Console.WriteLine("Player got a ball!");
        }



        //handles the play logic
        internal void playBall()
        {
            if playerStamina == 0 ||  ;

                {

                }

            //Ball newBall = ball.getBall();
            //player.Add(newBall);
        }



    }


}
