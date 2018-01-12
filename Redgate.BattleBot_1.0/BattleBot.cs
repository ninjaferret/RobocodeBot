// Access to standard .NET System

// Access to the public Robocode API

using Robocode;

// The namespace with your initials, in this case FNL is the initials
namespace Redgate.BattleBot
{
    // The name of your robot is BattleBot, and the robot type is Robot
    public class BattleBot : Robot
    {
        // The main method of your robot containing robot logics
        public override void Run()
        {
            // -- Initialization of the robot --

            // Here we turn the robot to point upwards, and move the gun 90 degrees
            TurnLeft(Heading - 90);
            TurnGunRight(90);

            // Infinite loop making sure this robot runs till the end of the battle round
            while (true)
            {
                // -- Commands that are repeated forever --

                // Move our robot 5000 pixels ahead
                Ahead(5000);

                // Turn the robot 90 degrees
                TurnRight(90);
                // Our robot will move along the borders of the battle field
                // by repeating the above two statements.
            }
        }

        // Robot event handler, when the robot sees another robot
        public override void OnScannedRobot(ScannedRobotEvent e)
        {
            // We fire the gun with bullet power = 1
            Fire(1);
        }
    }
}