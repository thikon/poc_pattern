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
        public void Sample()
        {
            var tmp = new RdpCore();
            tmp.BuildSession("RobotFreeRdpBundle");
        }
    }

    public class RobotFreeRdpSeperator : RobotFreeRdp
    {
        public void Sample()
        {
            var tmp = new RdpCore();
            tmp.BuildSession("RobotFreeRdpSeperator");
        }
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
                    var tmp = new RobotFreeRdpBundle();
                    tmp.Sample();
                    break;

                case "Seperate":
                    var tmp1 = new RobotFreeRdpSeperator();
                    tmp1.Sample();
                    break;

                default:
                    throw new ArgumentException("Invalid type", "type");
            }
        }
    }
}
