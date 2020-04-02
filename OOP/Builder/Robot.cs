using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OOP.Builder
{
    public class Robot : RobotPlan
    {
        private String robotHead;
        private String robotTorso;
        private String robotArms;
        private String robotLegs;

        public void setRobotArms(string arms)
        {
            robotArms = arms;
        }

        public String getRobotArms()
        {
            return robotArms;
        }

        public void setRobotHead(string head)
        {
            robotHead = head;
        }
        public String getRobotHead()
        {
            return robotHead;
        }

        public void setRobotLegs(string legs)
        {
            robotLegs = legs;
        }
        public String getRobotLegs()
        {
            return robotLegs;
        }

        public void setRobotTorso(string torso)
        {
            robotTorso = torso;
        }
        public String getRobotTorso()
        {
            return robotTorso;
        }
    }
}
