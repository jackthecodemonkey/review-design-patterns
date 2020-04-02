using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.Builder
{
    public class OldRobotBuilder : RobotBuilder
    {
        private Robot robot;
        public OldRobotBuilder()
        {
            this.robot = new Robot();
        }
        public void buildRobotArms()
        {
            robot.setRobotArms("Tin arms");
        }

        public void buildRobotHead()
        {
            robot.setRobotHead("Tin head");
        }

        public void buildRobotLegs()
        {
            robot.setRobotLegs("Tin legs");
        }

        public void buildRobotTorso()
        {
            robot.setRobotArms("Tin torso");
        }

        public Robot getRobot()
        {
            return this.robot;
        }
    }
}
