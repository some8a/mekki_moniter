using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NationalInstruments.DAQmx;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int measCount = 0;
        double voltStep = 0;
        double outPutValue = 0;
        private Task NiTask;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            range(2);


            buttonStart.Enabled = false;
            buttonStop.Enabled = true;

            voltStep = (double)numericUpDownVoltStep.Value;

            measCount = 0;

            chart1.Series.Clear();
            chart1.Series.Add("cdata");
            chart1.Series["cdata"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.ChartAreas[0].AxisX.Minimum = (double)numericUpDownMinVolt.Value * 1000;
            chart1.ChartAreas[0].AxisX.Maximum = (double)numericUpDownMaxVolt.Value * 1000;
            chart1.ChartAreas[0].AxisY.Minimum = (double)numericUpDownMinVolt.Value * 10000;
            chart1.ChartAreas[0].AxisY.Maximum = (double)numericUpDownMaxVolt.Value * 10000;
            chart1.ChartAreas[0].AxisX.Title = "Voltage [mV]";
            chart1.ChartAreas[0].AxisY.Title = "Current [uA]";

            relay(false);

            outVolt(0);

            richTextBox1.Text += "Status1\n\tPotentio\tCurrent\n";

            timer1.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            measEnd();
        }

        private void relay(bool onOff)
        {

            string portNum = "Dev1/port2";

            try
            {
                NiTask = new Task();
                NiTask.DOChannels.CreateChannel(portNum , "", ChannelLineGrouping.OneChannelForAllLines);
                DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(NiTask.Stream);
                if (onOff) writer.WriteSingleSamplePort(true, (UInt32)1);
                else writer.WriteSingleSamplePort(true, (UInt32)0);
                NiTask.Dispose();

            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message + "relay");
                this.Close();
            }

            System.Threading.Thread.Sleep(100); // リレー切り替え後は過渡現象があるような気がする。
        }

        private void range(int sw)
        {

            string portNum = "Dev1/port0";

            try
            {
                NiTask = new Task();
                NiTask.DOChannels.CreateChannel(portNum, "", ChannelLineGrouping.OneChannelForAllLines);
                DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(NiTask.Stream);

                if (sw == 3)      writer.WriteSingleSamplePort(true, (UInt32)3);
                else if (sw == 2) writer.WriteSingleSamplePort(true, (UInt32)1); //　０１と１０の表現が逆
                else if (sw == 1) writer.WriteSingleSamplePort(true, (UInt32)2);
                else              writer.WriteSingleSamplePort(true, (UInt32)0);

                NiTask.Dispose();
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
                measEnd();
            }

        }

        /// <summary>
        /// 電圧測定
        /// V表示
        /// </summary>
        /// <param name="portName"></param>
        /// <returns></returns>
        private double measVolt(string portName)
        {
            double max = 10;
            double min = -10;
            double[] rtnData = new double[20];
            string portNum;

            if(portName == "pot")
                portNum = "Dev1/ai7";
            
            else
                portNum = "Dev1/ai3";

            try
            {
                NiTask = new Task();                                        //Create a new task
                NiTask.AIChannels.CreateVoltageChannel(portNum, "", AITerminalConfiguration.Rse, min, max, AIVoltageUnits.Volts);                //Create a virtual channel

                AnalogSingleChannelReader reader = new AnalogSingleChannelReader(NiTask.Stream);
                NiTask.Control(TaskAction.Verify);                          //Verify the Task
                for (int i = 0; i < rtnData.Length ; i++)
                {
                    System.Threading.Thread.Sleep(5);
                    rtnData[i] = reader.ReadSingleSample();                  //Plot Multiple Channels to the table
                }
                NiTask.Dispose();                                           //Dispose virtual channel
            }
            catch (DaqException exception)
            {
                MessageBox.Show(exception.Message);
                measEnd();
            }

            return rtnData.Average();
        }

        /// <summary>
        /// 電流計測　
        /// </summary>
        /// <returns>
        /// A表記
        /// </returns>
        /// 

        private double measCur()
        {
            double rtnData = 0;

            range(3);
            
            rtnData = measVolt("cur");
            
            if (Math.Abs(rtnData) < 0.01)//0.1mAレンジ
            {
                range(0);
                rtnData = measVolt("cur");
                rtnData /= 100000;
                richTextBox1.Text += "r0 ";
         }

            else 
 
            if (Math.Abs(rtnData) < 0.1)//1mAレンジ
            {
                range(1);
                rtnData = measVolt("cur");
                rtnData /= 10000;
                richTextBox1.Text += "r1 ";
            }

            else  if (Math.Abs(rtnData) < 1)//10mAレンジ
            {
                range(2);
                rtnData = measVolt("cur");
                rtnData /= 1000;
                richTextBox1.Text += "r2 ";
            }

            else if (Math.Abs(rtnData) < 10.1)//100mAレンジ
            {
                rtnData /= 100;
                richTextBox1.Text += "r3 ";
            }

            else
            {
                measEnd();
                MessageBox.Show("電流測定端子が10Vを超えたので停止します。\n" + rtnData.ToString());
            }
            
            return rtnData;

        }


        /// <summary>
        /// 電圧設定
        /// </summary>
        /// <returns>
        /// A表記
        /// </returns>
        private void outVolt(double oVlt)
        {
            double minVolt = -10;
            double maxVolt = 10;

            try
            {
                NiTask = new Task();
                NiTask.AOChannels.CreateVoltageChannel("Dev1/ao1", "", minVolt, maxVolt, AOVoltageUnits.Volts);
                AnalogSingleChannelWriter writer = new AnalogSingleChannelWriter(NiTask.Stream);
                writer.WriteSingleSample(true, oVlt);
                NiTask.Dispose();
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
                measEnd();
            }

            System.Threading.Thread.Sleep(1);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            double potTmp, curTmp;

            potTmp = measVolt("pot");
            curTmp = measCur();

            timer1.Interval = (int)(numericUpDownMeasInt1.Value * 1000);
            richTextBox1.Text += measCount.ToString() + "\t" + potTmp.ToString("f5") + "\t" + curTmp.ToString("f10") + "\n";
            scrollEnd();
            measCount++;

            if (measCount >= numericUpDownMeasCount1.Value)
            {
                measCount = 0;
                timer2.Interval = (int)(numericUpDownMeasInt2.Value * 1000);
                relay(true);

                timer1.Enabled = false;
                timer2.Enabled = true;

                richTextBox1.Text += "Status2\n";

                outPutValue = (double)numericUpDownStartVolt.Value;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            double[] potData = new double[(int)numericUpDownMeasCount2.Value];
            double[] curData = new double[(int)numericUpDownMeasCount2.Value];
            double potTmp, curTmp;

            outVolt(outPutValue);

            System.Threading.Thread.Sleep(100);

            potTmp = measVolt("pot");
            
            curTmp = measCur();


            richTextBox1.Text += measCount.ToString() + "\t" + potTmp.ToString("f5") + "\t" + curTmp.ToString("f10") + "\n";
            scrollEnd();

            chart1.Series["cdata"].Points.AddXY((int)(potTmp * 1000), (int)(curTmp * 1000000));

            if (voltStep > 0)
                if ((double)numericUpDownMaxVolt.Value <= outPutValue + Math.Abs((double)numericUpDownVoltStep.Value))
                    voltStep = -Math.Abs((double)numericUpDownVoltStep.Value);

            if (voltStep < 0)
                if ((double)numericUpDownMinVolt.Value >= outPutValue - Math.Abs((double)numericUpDownVoltStep.Value))
                    voltStep = Math.Abs((double)numericUpDownVoltStep.Value);

            outPutValue += voltStep;
            measCount++;

            if (measCount >= numericUpDownMeasCount2.Value)
                measEnd();
        }

/// <summary>
/// チャートを書く
/// </summary>
/// <param name="potData"></param>ポテンショ（電圧）　グラフ横軸
/// <param name="curData"></param>カレント（電流）　グラフ縦軸
        private void plotChart(double[] potData, double[] curData)
        {

//                int potData_mV = (int)(potData[i]);
//                double curData_mV = curData[i];
//                chart1.Series["cdata"].Points.AddXY(potData_mV, curData_mV);
        }

        private void measEnd()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;

            outVolt(0);
        }

        private void scrollEnd()
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void maxOfMin(object sender, EventArgs e)
        {
            if (numericUpDownMinVolt.Value > numericUpDownStartVolt.Value)
                numericUpDownMinVolt.Value = numericUpDownStartVolt.Value;
        }

        private void minOfMax(object sender, EventArgs e)
        {
            if (numericUpDownMaxVolt.Value < numericUpDownStartVolt.Value)
                numericUpDownMaxVolt.Value = numericUpDownStartVolt.Value;
        }
    }
}
