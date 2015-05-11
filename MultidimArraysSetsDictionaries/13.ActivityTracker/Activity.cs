using System;
using System.Collections.Generic;
using System.Linq;


namespace ActivityTracker
{
    class Activity: IComparable<Activity>
    {
        private string name;
        private int distance;
        private DateTime date;

        public string Name
        {
            get { return this.name; }
        }

        public int Distance
        {
            get { return this.distance; }
            set { this.distance = value; }
        }

        public DateTime Date
        {
            get { return this.date; }
        }

        public Activity(string name, int distance, DateTime date)
        {
            this.date = date;
            this.distance = distance;
            this.name = name;
        }

        public int CompareTo(Activity act)
        {
            return this.Name.CompareTo(act.Name);
        }
    }
}
