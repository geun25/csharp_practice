using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conveyor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct PIO
        {
            public bool blsTrReq;
            public bool blsBusy;
            public bool blsCompt;
            public bool blsUReq;
            public bool blsLReq;
            public bool blsReady;
        }
        PIO pioConv1, pioConv2, pioConv3, pioConv4;

        bool statusCwConv1, statusCwConv2, statusCwConv3, statusCwConv4, statusCwConvS;
        bool statusCcwConv1, statusCcwConv2, statusCcwConv3, statusCcwConv4, statusCcwConvS;

        private void btnTakeIn_Click(object sender, EventArgs e)
        {
            blsTakeIn = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnTakeOut_Click(object sender, EventArgs e)
        {

        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            blsAutoConv1 = false;
            blsAutoConv2 = false;
            blsAutoConv3 = false;
            blsAutoConv4 = false;
            blsAutoConvS = false;
        }

        bool ConvMotionBlink;
        private void ConvMotionProc_Tick(object sender, EventArgs e)
        {
            if(ConvMotionBlink == true)
            {
                btnConveyor1.Text = "";
                btnConveyor2.Text = "";
                btnConveyor3.Text = "";
                btnConveyor4.Text = "";
                btnConveyorS.Text = "";
                ConvMotionBlink = false;
            }
            else
            {
                if (!statusCwConv1 && !statusCcwConv1)
                    btnConveyor1.Text = "";
                else if (statusCwConv1)
                    btnConveyor1.Text = "CW";
                else if(statusCcwConv1)
                    btnConveyor1.Text = "CCW";
                if (!statusCwConv2 && !statusCcwConv2)
                    btnConveyor2.Text = "";
                else if (statusCwConv2)
                    btnConveyor2.Text = "CW";
                else if (statusCcwConv1)
                    btnConveyor2.Text = "CCW";
                if (!statusCwConv3 && !statusCcwConv3)
                    btnConveyor3.Text = "";
                else if (statusCwConv3)
                    btnConveyor3.Text = "CW";
                else if (statusCcwConv3)
                    btnConveyor3.Text = "CCW";
                if (!statusCwConv4 && !statusCcwConv4)
                    btnConveyor4.Text = "";
                else if (statusCwConv4)
                    btnConveyor4.Text = "CW";
                else if (statusCcwConv4)
                    btnConveyor4.Text = "CCW";
                if (!statusCwConvS && !statusCcwConvS)
                    btnConveyorS.Text = "";
                else if (statusCwConvS)
                    btnConveyorS.Text = "CW";
                else if (statusCcwConvS)
                    btnConveyorS.Text = "CCW";

                ConvMotionBlink = true;
            }
        }

        int stepConv1, stepConv2, stepConv3, stepConv4, stepConvS;
        int oldStepConv1, oldStepConv2, oldStepConv3, oldStepConv4, oldStepConvS;
        int countConv1, countConv2, countConv3, countConv4, countConvS;

        bool blsAutoConv1, blsAutoConv2, blsAutoConv3, blsAutoConv4, blsAutoConvS;
        bool blsTakeIn, blsTakeOut;
        private void MainSchedulerProc_Tick(object sender, EventArgs e)
        {
            ProcConv1();
            ProcConv2();
            ProcConv3();
            ProcConv4();
            ProcConvS();
        }

        void ProcConv1()
        {

        }

        void ProcConv2()
        {
            if (blsAutoConv2 == true)
            {
                switch (stepConv2)
                {
                    case 0:
                        pioConv2.blsUReq = false;
                        pioConv2.blsLReq = false;
                        pioConv2.blsReady = false;
                        statusCwConv2 = false;
                        statusCcwConv2 = false;

                        stepConv2 = 100;
                        break;

                    case 100:
                        if (cbSensor2_2.Checked == true)
                        {
                            stepConv2 = 200;
                        }
                        else
                        {
                            if (blsTakeIn == true)
                            {
                                stepConv2 = 110;
                                countConv2 = 0;
                            }
                        }
                        break;

                    case 110:
                        statusCcwConv2 = true;
                        if (cbSensor2_2.Checked == true)
                        {
                            statusCcwConv2 = false;
                            pioConv2.blsUReq = true;
                            stepConv2 = 200;
                        }
                        break;

                    case 200:
                        if (cbSensor2_2.Checked == false)
                        {
                            stepConv2 = 100;
                        }
                        else if(pioConv2.blsTrReq)
                        {
                            stepConv2 = 210;
                            pioConv2.blsReady = true;
                        }
                        break;

                    case 210:
                        if(pioConv2.blsBusy)
                        {
                            pioConv2.blsUReq = true;
                            stepConv2 = 220;
                        }
                        break;

                    case 220:
                        statusCcwConv2 = true;
                        if(!pioConv2.blsTrReq && !pioConv2.blsBusy && pioConv2.blsCompt)
                        {
                            pioConv2.blsUReq = false;
                            statusCcwConv2 = false;
                            stepConv2 = 230;
                        }
                        break;

                    case 230:
                        if (!pioConv2.blsCompt)
                            stepConv2 = 100;
                        break;

                    default:
                        stepConv2 = 0;
                        break;
                }
            }
            else
            {
                stepConv2 = 0;
            }

            if(oldStepConv2 != stepConv2)
            {
                Console.WriteLine($"Conveyor 2 Step = {stepConv2}");
            }
            oldStepConv2 = stepConv2;
            blsTakeIn = false;
        }
        
        void ProcConv3()
        {

        }

        void ProcConv4()
        {

        }

        void ProcConvS()
        {

        }
    }
}
