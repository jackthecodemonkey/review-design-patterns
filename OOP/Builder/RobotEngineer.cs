using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.Builder
{
    public class RobotEngineer
    {
        private RobotBuilder robotBuilder;

        public RobotEngineer(RobotBuilder robotBuilder)
        {
            this.robotBuilder = robotBuilder;
        }

        public Robot getRobot()
        {
            return robotBuilder.getRobot();
        }

        public void makeRobot()
        {
            this.robotBuilder.buildRobotHead();
            this.robotBuilder.buildRobotArms();
            this.robotBuilder.buildRobotLegs();
            this.robotBuilder.buildRobotTorso();
        }
    }
}
