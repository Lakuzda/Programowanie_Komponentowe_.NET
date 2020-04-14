using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnobControl;

namespace Compass
{
    public partial class UserControl1: UserControl
    {
        private int currentValue;
        private int expectedValue;
        private int differenceValue;
        public UserControl1()
        {
            InitializeComponent();
            currentValue = knobControl1.Value;
            expectedValue = 270;
        }

        /// <summary>
        /// Difference value of directions
        /// </summary>
        public int Difference
        {
            get 
            {
                differenceValue = expectedValue - currentValue;
                if((differenceValue < -180)&&(differenceValue > 180))
                {
                    if (differenceValue < 0)
                    {
                        differenceValue += 360;
                    }
                    else
                    {
                        differenceValue -= 360;
                    }
                }
                return differenceValue; 
            }
            private set
            {
                differenceValue = value;
                Invalidate();
            }
        }
        /// <summary>
        /// expected value of direction
        /// </summary>
        [Description("Set expected value of direction")]
        [Category("CompassSettings")]
        public int ExpectedValue
        {
            get { return expectedValue; }
            set
            {
                expectedValue = value;
                Invalidate();
            }
        }

        /// <summary>
        /// current value of direction
        /// </summary>
        [Description("Set current value of direction")]
        [Category("CompassSettings")]
        public int CurrentValue
        {
            get 
            {
                currentValue = knobControl1.Value;
                return currentValue; 
            }
            set
            {
                currentValue = value;
                knobControl1.Value = value;
                Invalidate();
            }
        }

    }
}
