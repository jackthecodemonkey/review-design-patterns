using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.Builder
{
    public interface RobotBuilder
    {
        public void buildRobotHead();
        public void buildRobotTorso();
        public void buildRobotArms();
        public void buildRobotLegs();
        public Robot getRobot();
    }
}
