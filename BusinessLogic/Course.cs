using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        private string instructorName;
        private byte numberOfCredits;
        private string courseName;

        public Course(string courseName)
        {
            CourseName = courseName;
            InstructorName = "STAFF";
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get => instructorName; set => instructorName = value; }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName {
            get => courseName;
            set
            {
                if (value == null)
                    throw new ArgumentNullException();

                courseName = value;
            }
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits
        {
            get => numberOfCredits;
            set
            {
                if (value > 0 && value < 30)
                    numberOfCredits = value;
                else
                    throw new ArgumentException();
            }
        }

    }
}
