﻿namespace ClockV10
{
    public class Clock
    {
        #region Instance fields
        private int _minutes;
        private int _hours;
        #endregion

        #region Constructor
        public Clock(int hours, int minutes)
        {
            _minutes = minutes;
            _hours = hours;
        }
        #endregion

        #region Properties
        public int Minutes
        {
            get { return _minutes; }
            set { _minutes = value; }
        }

        public int Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }

        public string Display
        {
            get { return $"{Hours:00}:{Minutes:00}"; }
        }
        #endregion

        #region Methods
        public void AdvanceOneMinute()
        {
            _minutes = (_minutes + 1) % 60;
            _hours = (_hours + (60 - _minutes) / 60) % 24;
        } 
        #endregion
    }
}