using System;
namespace Demo1
{
class program
    {
        public static void Main()
        {
            Ball ball = new Ball();

            Player P11 = new Player() { Name = "P11", Team = "Team01" };
            Player P12 = new Player() { Name = "P12", Team = "Team01" };
            Player P21 = new Player() { Name = "P21", Team = "Team02" };
            Player P22 = new Player() { Name = "P22", Team = "Team02" };
            Player P23 = new Player() { Name = "P23", Team = "Team02" };
            Refree R01 = new Refree() { Name = "R01" };

            ball.BallLocation = new Location() { X = 20, Y = 20, Z = 20 };
            Console.WriteLine(ball);

            //ball.BallLocationChanged += new Action(P11.Run);
            ball.BallLocationChanged += new Action<Location>(P11.Run);
            ball.BallLocationChanged += P12.Run;
            ball.BallLocationChanged += P21.Run;
            ball.BallLocationChanged += P22.Run;
            ball.BallLocationChanged += R01.Look;
            //ball.BallLocationChanged += () => Console.WriteLine("Adhock Method");
            ball.BallLocationChanged += D => Console.WriteLine("Adhock Method");

            ball.BallLocation = new Location() { X = 70, Y = 70, Z = 70 };
            Console.WriteLine(ball);

            ball.BallLocationChanged -= P22.Run;
            ball.BallLocationChanged += P23.Run;

            Console.WriteLine("After Substitution");
            ball.BallLocation = new Location() { X = 90, Y = 90, Z = 90 };



        }
    }
    }

