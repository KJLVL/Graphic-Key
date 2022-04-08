using System.ComponentModel;
using System.Windows.Forms;

namespace graphicKey
{
    class ButtonRounding : Control
    {
        private bool roundingEnable = false;
        //Вкл/выкл закругление
        public bool RoundingEnable
        {
            get => roundingEnable;
            set
            {
                roundingEnable = value;
            }
        }
        private int roundingPercent = 100;
        [DisplayName("Rounding")]
        [DefaultValue(100)]
        public int Rounding
        {
            get => roundingPercent;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    roundingPercent = value;

                    //Refresh();
                }
            }
        }
        
        

    }
}
