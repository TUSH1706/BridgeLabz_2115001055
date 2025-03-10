using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCourseHierarchy
{
    public class Course
    {
        public string courseName;
        public int duration;

        public Course(string courseName, int duration)
        {
            this.courseName = courseName;
            this.duration = duration;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Course: {courseName}, Duration: {duration} hours");
        }
    }


    class OnlineCourse : Course
    {
        public string platform;
        public bool isRecorded;

        public OnlineCourse(string courseName, int duration, string platform, bool isRecorded) : base(courseName, duration)
        {
            this.platform = platform;
            this.isRecorded = isRecorded;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Platform: {platform}, Recorded: {(isRecorded ? "Yes" : "No")}");
        }

    }

    class PaidOnlineCourse : OnlineCourse
    {
        public double fee;
        public double discount;

        public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount) : base(courseName, duration, platform, isRecorded)
        {
            this.fee = fee;
            this.discount = discount;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Fee: Rs.{fee}, Discount: {discount}%");
        }
    }
}
