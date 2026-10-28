using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;
using YS_6000.Module;
namespace YS_6000.Module
{
    class SignalTower : BaseModule
    {
        public Output redLight;
        public Output greenLight;
        public Output yellowLight;
        public Output buzzer;
        public SignalTower(string name, String display, int prefix) : base(name, display, prefix)
        {
            redLight = new Output("Red");
            greenLight = new Output("Green");
            yellowLight = new Output("Yellow");
            buzzer = new Output("Buzzer");
        }



        public void runThread()
        {

            while (!evtEnd.WaitOne(100))
            {

                if (Global.MF.isSystemRun())
                {
                    if (Global.MF.isWarning())
                    {
                        yellowLight.setOn();

                        if (Global.WarningToggle == 0 && MainFrame.buzzerOn)
                            buzzer.setOn();
                        else
                            buzzer.setOff();
                    }
                    else
                    {
                        buzzer.setOff();
                        yellowLight.setOff();
                    }
                    Global.MF.startLamp.setOn();
                    Global.MF.stopLamp.setOff();
                    greenLight.setOn();
                    redLight.setOff();

                }
                else if (Global.MF.isSystemJam())
                {

                    if (Global.HalfSecondToggle && MainFrame.buzzerOn)
                        buzzer.setOn();
                    else
                        buzzer.setOff();

                    Global.MF.startLamp.setOff();
                    Global.MF.stopLamp.setOn();
                    redLight.setOn();
                    greenLight.setOff();
                    yellowLight.setOff();
                }
                else
                {
                    Global.MF.startLamp.setOff();
                    Global.MF.stopLamp.setOn();
                    yellowLight.setOn();
                    redLight.setOff();
                    greenLight.setOff();
                    buzzer.setOff();
                }



            }

            rtState = RunThreadState.END;
        }
    }
}
