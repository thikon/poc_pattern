using RobotRDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample
{
    //public abstract class Document
    //{
    //    private List<Page> _pages = new List<Page>();
    //    public Document()
    //    {
    //        this.CreatePages();
    //    }
    //    public List<Page> Pages
    //    {
    //        get { return _pages; }
    //    }

    //    // Factory Method
    //    public abstract void CreatePages();
    //}

    //public class Resume : Document
    //{
    //    public override void CreatePages()
    //    {
    //        Pages.Add(new SkillPage());
    //        Pages.Add(new EducationPage());
    //    }
    //}

    //public class Report : Document
    //{
    //    public override void CreatePages()
    //    {
    //        Pages.Add(new ResultsPage());
    //    }
    //}

    public interface RobotFreeRdp
    {
        
    }

    public class RobotFreeRdpBundle : RobotFreeRdp
    {

    }

    public class RobotFreeRdpSeperator : RobotFreeRdp
    {

    }

    public abstract class RobotFreeRdpOption
    {
        public abstract void FactoryMethod(string type);
    }

    public class ConcretRobotFreeRdpOption : RobotFreeRdpOption
    {
        public override void FactoryMethod(string type)
        {
            switch (type)
            {
                case "Bundle":
                    var tmp = new RdpCore();
                    tmp.BuildSession(type);
                    tmp.CloseSession(type);
                    break;
                case "Seperate":
                    var tmp1 = new RdpCore();
                    tmp1.BuildSession(type);
                    tmp1.CloseSession(type);
                    break;
                default:
                    throw new ArgumentException("Invalid type", "type");
            }
        }
    }
}
