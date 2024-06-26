using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            //storage.balls.Add(ball);
            Console.WriteLine("Player got a ball!");
            playerHasBall = true;
        }



        //handles the play logic
        internal void playBall()
        {
            if (playerHasBall = true || playerStamina > 0)

            {
                Console.WriteLine("Player kicked the ball!");
            }

            //else if (playerHasBall = false || playerstamina =< 0) 

            //{
                    //
                    

            //else
            //{
            //    Console.WriteLine("Debug error! Does not work!");
            //}

            //else if

            //    {

            //    }

            


        

            //Ball newBall = ball.getBall();
            //player.Add(newBall);
        }



    }


}
