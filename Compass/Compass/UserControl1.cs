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
        private Color pointColor;
        private Color knobColor;
        private bool textVisable;
        private Color fontColor;
        private bool numberScale;
        public UserControl1()
        {
            InitializeComponent();
            currentValue = knobControl1.Value;
            expectedValue = 270;
            textVisable = true;
            fontColor = Color.Black;
            knobColor = Color.Black;
            pointColor = Color.Red;
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

        /// <summary>
        /// Color of font
        /// </summary>
        [Description("Set the color of the font")]
        [Category("CompassSettings")]
        public Color FontColor
        {
            get { return fontColor; }
            set
            {
                fontColor = value;
                label1.ForeColor = value;
                label2.ForeColor = value;
                label3.ForeColor = value;
                label4.ForeColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Color of pointer
        /// </summary>
        [Description("Set the color of the pointer")]
        [Category("CompassSettings")]
        public Color PointColor
        {
            get { return pointColor; }
            set
            {
                pointColor = value;
                knobControl1.PointerColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Color of knob
        /// </summary>
        [Description("Set the color of the knob")]
        [Category("CompassSettings")]
        public Color KnobColor
        {
            get { return knobColor; }
            set
            {
                knobColor = value;
                knobControl1.KnobBackColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Setting text visable
        /// </summary>
        [Description("Set the text visable")]
        [Category("CompassSettings")]
        public bool TextVisable
        {
            get { return textVisable; }
            set
            {
                textVisable = value;

                if (textVisable)
                {
                    label1.Text = "N";
                    label2.Text = "S";
                    label3.Text = "E";
                    label4.Text = "W";
                }
                else
                {
                    label1.Text = "";
                    label2.Text = "";
                    label3.Text = "";
                    label4.Text = "";
                }
                Invalidate();
            }
        }

        /// <summary>
        /// Setting scale
        /// </summary>
        [Description("Set the number scale")]
        [Category("CompassSettings")]
        public bool NumberScale
        {
            get { return numberScale; }
            set
            {
                numberScale = value;
                knobControl1.ShowLargeScale = value;
                knobControl1.ShowSmallScale = value;
            }
        }
    }
}
