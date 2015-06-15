using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Collections;

namespace AC10
{
    public partial class Form1 : Form
    {
        private SerialPort comport = new SerialPort();

        public Form1()
        {
            InitializeComponent();

            // The main control for communicating through the RS-232 port

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool error = false;

            if (comport.IsOpen) comport.Close();
            else
            {
                // Set the port's settings
                comport.BaudRate = 115200;
                comport.DataBits = 8;
                comport.StopBits = StopBits.One;
                comport.Parity = Parity.None;
                comport.PortName = comboBox1.Text;

                try
                {
                    // Open the port
                    comport.Open();
                }
                catch (UnauthorizedAccessException) { error = true; }
                //catch (IOException) { error = true; }
                catch (ArgumentException) { error = true; }

                if (error) MessageBox.Show(this, "Could not open the COM port.  Most likely it is already in use, has been removed, or is unavailable.", "COM Port Unavalible", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {

                }
            }

            Read_All();
          


            //ComPortTimer.Enabled = true;
            //timer1.Enabled = true;
            if(comport.IsOpen)
            { 
              backgroundWorker1.RunWorkerAsync();
             }
        }

        private void Read_All()
        {
            SendData("version");
            Thread.Sleep(40);
            SendData("gpio_r *");
            Thread.Sleep(40);
            SendData("batchg_r *");
            Thread.Sleep(40);
            SendData("adc_r *");
            Thread.Sleep(40);
            //SendData("gpio_r DCDC_ENABLE");
            //Thread.Sleep(40);
        }



        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
                comboBox1.Items.Add(s);

        }
        private string get_comms()
        {
            // If the com port has been closed, message box, return -1;
            if (!comport.IsOpen)
            {
                MessageBox.Show("comport not open");
                return "-2";
            }
            else
            {
                try
                {
                    string read = comport.ReadLine();
                    return read;      //returns -1 if end of stream has been read
                }
                catch
                {
                    return "-1";
                }
            }

        }

        /// <summary> Send the user's data currently entered in the 'send' box.</summary>
        private void SendData(string data)
        {
            // if (CurrentDataMode == DataMode.Text)
            // {
            // Send the user's text straight out the port
            try
            {
                comport.Write(string.Format("{0}\r",data));
            }
            catch (Exception)
            {
              //  Log(LogMsgType.Error, "Send problem: Is com port selected? " + "\n");
            }

            txtSendData.SelectAll();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            bool Do_Work = true;

            while (Do_Work)
            {
                string com_string = get_comms();


                richTextBox1.Invoke(new EventHandler(delegate
                        {

                            richTextBox1.Text = com_string + richTextBox1.Text;
                           // richTextBox1.Text += string.Format("{0:x}", com_byte.ToString("x2"));
                           // List<Reader> searchResultR = myReaderList.FindAll(Rtest => Rtest.ReaderAdd != "");
                            if(richTextBox1.Lines.Count()>=50)
                            {
                                while(richTextBox1.Lines.Count()>=50)
                                {
                                    richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1, 1);
                                }

                            }

                        }));




                if (com_string == "-1")
                {
                    // reached end of buffer
                    //So we can stop the background worker for now start again on buffer RX
                    backgroundWorker1.CancelAsync();
                    Do_Work = false;
                }
                if (com_string == "-2")
                {
                    Do_Work = false;
                }

               /*
                * 
                */

                string[] com_string_array = com_string.Split(new char[] { ' ' });
                string com_string_command = com_string_array[0];
                int com_string_array_length = com_string_array.Count()-1;

                switch (com_string_command)
                {

                    /*
                     * BAT_I_0: BAT_I_1: BAT_I_2: BAT_I_3: 
                     * CARTRIDGE_PWR: VALVE_OPEN_CLOSE: VALVE_DRIVE_EN: 
                     * ENABLE_MAINS: ENABLE_STK: ENABLE_BAT: MCU_WAKE_EN: USB_EN: DIVIDER_MODE_SEL: DCDC_ENABLE: 
                     * NCHRG_ENABLE: V_BAT_MEAS_EN: HYDRATE: RED_LED: GREEN_LED: */


                    case "\rDCDC_ENABLE:":
                        if (com_string_array[com_string_array.Count() - 1] == "1")
                        {
                            DCDC_ENABLE_checkBox.Invoke(new EventHandler(delegate
                            {
                                DCDC_ENABLE_checkBox.Checked = true;
                            }));


                        }
                         else if (com_string_array[com_string_array.Count() - 1] == "0")
                        {
                            DCDC_ENABLE_checkBox.Invoke(new EventHandler(delegate
                            {
                                DCDC_ENABLE_checkBox.Checked = false;
                            }));
                        }
                        else { break; }
                        break;
                    
                    case "\rGREEN_LED:":
                        if (com_string_array[com_string_array.Count() - 1] == "1")
                        {
                            GREEN_LED_checkBox.Invoke(new EventHandler(delegate
                            {
                                GREEN_LED_checkBox.Checked = true;
                            }));


                        }
                        else if (com_string_array[com_string_array.Count() - 1] == "0")
                        {
                            GREEN_LED_checkBox.Invoke(new EventHandler(delegate
                            {
                                GREEN_LED_checkBox.Checked = false;
                            }));
                        }
                        else { break; }
                        break;
                    
                    case "\rRED_LED:":
                        if (com_string_array[com_string_array.Count() - 1] == "1")
                        {
                            RED_LED_checkBox.Invoke(new EventHandler(delegate
                            {
                                RED_LED_checkBox.Checked = true;
                            }));


                        }
                        else if (com_string_array[com_string_array.Count() - 1] == "0")
                        {
                            RED_LED_checkBox.Invoke(new EventHandler(delegate
                            {
                                RED_LED_checkBox.Checked = false;
                            }));
                        }
                        else { break; }
                        break;

                    case "\rHYDRATE:":
                        if (com_string_array[com_string_array.Count() - 1] == "1")
                        {
                            HYDRATE_checkBox.Invoke(new EventHandler(delegate
                            {
                                HYDRATE_checkBox.Checked = true;
                            }));


                        }
                        else if (com_string_array[com_string_array.Count() - 1] == "0")
                        {
                            HYDRATE_checkBox.Invoke(new EventHandler(delegate
                            {
                                HYDRATE_checkBox.Checked = false;
                            }));
                        }
                        else { break; }
                        break;
                    
                    case "\rV_BAT_MEAS_EN:":
                        if (com_string_array[com_string_array.Count() - 1] == "1")
                        {
                            V_BAT_MEAS_EN_checkBox.Invoke(new EventHandler(delegate
                            {
                                V_BAT_MEAS_EN_checkBox.Checked = true;
                            }));


                        }
                        else if (com_string_array[com_string_array.Count() - 1] == "0")
                        {
                            V_BAT_MEAS_EN_checkBox.Invoke(new EventHandler(delegate
                            {
                                V_BAT_MEAS_EN_checkBox.Checked = false;
                            }));
                        }
                        else { break; }
                        break;

                    case "\rDIVIDER_MODE_SEL:":
                        if (com_string_array[com_string_array.Count() - 1] == "1")
                        {
                            DIVIDER_MODE_SEL_checkBox.Invoke(new EventHandler(delegate
                            {
                                DIVIDER_MODE_SEL_checkBox.Checked = true;
                            }));


                        }
                        else if (com_string_array[com_string_array.Count() - 1] == "0")
                        {
                            DIVIDER_MODE_SEL_checkBox.Invoke(new EventHandler(delegate
                            {
                                DIVIDER_MODE_SEL_checkBox.Checked = false;
                            }));
                        }
                        else { break; }
                        break;
                    
                    case "\rCARTRIDGE_PWR:":
                        if(com_string_array[com_string_array.Count()-1] == "1")
                        {
                            CARTRIDGE_PWR_checkBox.Invoke(new EventHandler(delegate
                            {
                               CARTRIDGE_PWR_checkBox.Checked = true;
                            }));

                           
                        }
                        else if (com_string_array[com_string_array.Count() - 1] == "0")
                        {
                            CARTRIDGE_PWR_checkBox.Invoke(new EventHandler(delegate
                            {
                                USB_EN_CheckBox.Checked = false;
                            }));
                        }
                        else { break; }
                        break;

                    
                    case "\rUSB_EN:": 
                        if(com_string_array[com_string_array.Count()-1] == "1")
                        {
                            USB_EN_CheckBox.Invoke(new EventHandler(delegate
                            {
                                USB_EN_CheckBox.Checked = true;
                            }));

                           
                        }
                        else if (com_string_array[com_string_array.Count() - 1] == "0")
                        {
                            USB_EN_CheckBox.Invoke(new EventHandler(delegate
                            {
                                USB_EN_CheckBox.Checked = false;
                            }));
                        }
                        else { break; }
                        break;

                    case "\rENABLE_MAINS:":
                        if (com_string_array[com_string_array.Count() - 1] == "1")
                        {
                            USB_EN_CheckBox.Invoke(new EventHandler(delegate
                            {
                                ENABLE_MAINS_checkBox.Checked = true;
                            }));


                        }
                        else if (com_string_array[com_string_array.Count() - 1] == "0")
                        {
                            USB_EN_CheckBox.Invoke(new EventHandler(delegate
                            {
                                ENABLE_MAINS_checkBox.Checked = false;
                            }));
                        }
                        else { break; }
                        break;

                    case "\rENABLE_STK:":
                        if (com_string_array[com_string_array.Count() - 1] == "1")
                        {
                            USB_EN_CheckBox.Invoke(new EventHandler(delegate
                            {
                                ENABLE_STK_checkbox.Checked = true;
                            }));


                        }
                        else if (com_string_array[com_string_array.Count() - 1] == "0")
                        {
                            USB_EN_CheckBox.Invoke(new EventHandler(delegate
                            {
                                ENABLE_STK_checkbox.Checked = false;
                            }));
                        }
                        else { break; }
                        break;

                    case "\rENABLE_BAT:":
                        if (com_string_array[com_string_array.Count() - 1] == "1")
                        {
                            USB_EN_CheckBox.Invoke(new EventHandler(delegate
                            {
                                ENABLE_BAT_checkBox.Checked = true;
                            }));


                        }
                        else if (com_string_array[com_string_array.Count() - 1] == "0")
                        {
                            USB_EN_CheckBox.Invoke(new EventHandler(delegate
                            {
                                ENABLE_BAT_checkBox.Checked = false;
                            }));
                        }
                        else { break; }
                        break;
            //I2C
                    case "\rRegister01":
                        Reg1_textBox.Invoke(new EventHandler(delegate
                            {
                                Reg1_textBox.Text = com_string_array[com_string_array.Count() - 1];
                            }));
                        break;  
                    case "\rRegister02":
                        Reg2_textBox.Invoke(new EventHandler(delegate
                        {
                            Reg2_textBox.Text = com_string_array[com_string_array.Count() - 1];
                        }));
                        break;
                    case "\rRegister03":
                        Reg3_textBox.Invoke(new EventHandler(delegate
                        {
                            Reg3_textBox.Text = com_string_array[com_string_array.Count() - 1];
                        }));
                        break;
                    case "\rRegister04":
                        Reg4_textBox.Invoke(new EventHandler(delegate
                        {
                            Reg4_textBox.Text = com_string_array[com_string_array.Count() - 1];
                        }));
                        break;

                //ADC
                    /*
                     * EXT_5V: V_DROP: VUSB_MEAS: I_BAT: V_STK: DCDC_IN: I_USB: VBOP: I_BOP: PRESS_H2: V_BAT: I_STK: TEMP_STK: */

                    case "\rTEMP_STK:":
                        TEMP_STK_textBox.Invoke(new EventHandler(delegate
                        {
                            TEMP_STK_textBox.Text = com_string_array[com_string_array.Count() - 1];
                        }));
                        break;
                    
                    case "\rPRESS_H2:":
                    PRESS_H2_textBox.Invoke(new EventHandler(delegate
                        {
                            PRESS_H2_textBox.Text = com_string_array[com_string_array.Count() - 1];
                        }));
                        break;
                    
                    case "\rEXT_5V:":
                        EXT_5V_textBox.Invoke(new EventHandler(delegate
                        {
                            EXT_5V_textBox.Text = com_string_array[com_string_array.Count() - 1];
                        }));
                        break;

                    case "\rV_DROP:":
                        VDROP_textBox.Invoke(new EventHandler(delegate
                        {
                            VDROP_textBox.Text = com_string_array[com_string_array.Count() - 1];
                        }));
                        break;

                    case "\rVUSB_MEAS:":
                        VUSB_textBox.Invoke(new EventHandler(delegate
                        {
                            VUSB_textBox.Text = com_string_array[com_string_array.Count() - 1];
                        }));
                        break;

                    case "\rI_BAT:":
                        I_BAT_textBox.Invoke(new EventHandler(delegate
                        {
                            I_BAT_textBox.Text = com_string_array[com_string_array.Count() - 1];
                        }));
                        break;

                    case "\rV_STK:":
                        V_STK_textBox.Invoke(new EventHandler(delegate
                        {
                            V_STK_textBox.Text = com_string_array[com_string_array.Count() - 1];
                        }));
                        break;

                    case "\rDCDC_IN:":
                        DCDC_IN_textBox.Invoke(new EventHandler(delegate
                        {
                            DCDC_IN_textBox.Text = com_string_array[com_string_array.Count() - 1];
                        }));
                        break;

                    case "\rI_USB:":
                        I_USB_textBox.Invoke(new EventHandler(delegate
                        {
                            I_USB_textBox.Text = com_string_array[com_string_array.Count() - 1];
                        }));
                        break;

                    case "\rVBOP:":
                        VBOP_textBox.Invoke(new EventHandler(delegate
                        {
                            VBOP_textBox.Text = com_string_array[com_string_array.Count() - 1];
                        }));
                        break;

                    case "\rI_BOP:":
                        I_BOP_textBox.Invoke(new EventHandler(delegate
                        {
                            I_BOP_textBox.Text = com_string_array[com_string_array.Count() - 1];
                        }));
                        break;

                    case "\rV_BAT:":
                        V_BAT_textBox.Invoke(new EventHandler(delegate
                        {
                            V_BAT_textBox.Text = com_string_array[com_string_array.Count() - 1];
                        }));
                        break;

                    case "\rI_STK:":
                        I_STK_textBox.Invoke(new EventHandler(delegate
                        {
                            I_STK_textBox.Text = com_string_array[com_string_array.Count() - 1];
                        }));
                        break;


                    default: break;
                }


           

            }
            // backgroundWorker1.ReportProgress(1,e);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SendData(txtSendData.Text);
        }



        private void USB_EN_CheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            var control = sender as CheckBox;

            if (control.Checked)
            {
                SendData("gpio_s USB_EN");
            }
            else
            {
                SendData("gpio_c USB_EN");
            }
        }

        private void ENABLE_MAINS_checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (ENABLE_MAINS_checkBox.Checked)
            {
                SendData("gpio_s ENABLE_MAINS");
            }
            else
            {
                SendData("gpio_c ENABLE_MAINS");
            }
        }

        private void ENABLE_STK_checkbox_CheckStateChanged(object sender, EventArgs e)
        {
            if (ENABLE_STK_checkbox.Checked)
            {
                SendData("gpio_s ENABLE_STK");
            }
            else
            {
                SendData("gpio_c ENABLE_STK");
            }
        }


        private void ENABLE_BAT_checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (ENABLE_BAT_checkBox.Checked)
            {
                SendData("gpio_s ENABLE_BAT");
            }
            else
            {
                SendData("gpio_c ENABLE_BAT");
            }
        }

        private void DCDC_ENABLE_checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (DCDC_ENABLE_checkBox.Checked)
            {
                SendData("gpio_s DCDC_ENABLE");
            }
            else
            {
                SendData("gpio_c DCDC_ENABLE");
            }
        }

        private void NCHRG_ENABLE_checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (NCHRG_ENABLE_checkBox.Checked)
            {
                SendData("gpio_s NCHRG_ENABLE");
            }
            else
            {
                SendData("gpio_c NCHRG_ENABLE");
            }
        }

        private void read_gpio_button_Click(object sender, EventArgs e)
        {
            SendData("gpio_r *");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void batchg_r_button_Click(object sender, EventArgs e)
        {
            SendData("batchg_r *");
        }

        private void txtSendData_KeyPress(object sender, KeyPressEventArgs e)
        {
          if(e.KeyChar==13)
          {
            SendData(txtSendData.Text);
          }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendData(string.Format("fan1 {0}",textBox6.Text));
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendData(string.Format("fan2 {0}", textBox7.Text));
            }
        }

        private void Read_ADC_button_Click(object sender, EventArgs e)
        {
            SendData("adc_r *");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Read_All();
        }

        private void Auto_Read_checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            var control = sender as CheckBox;

            if (control.Checked)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }

        }

        private void CARTRIDGE_PWR_checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            var control = sender as CheckBox;

            if (control.Checked)
            {
                SendData("gpio_s CARTRIDGE_PWR");
            }
            else
            {
                SendData("gpio_c CARTRIDGE_PWR");
            }

        }

        private void purge_duty_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
     
            if (e.KeyChar == 13)
            {
                SendData(string.Format("purge_duty {0}", purge_duty_textBox.Text));
            }
       
        }

        private void inlet_duty_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendData(string.Format("inlet_duty {0}", inlet_duty_textBox.Text));
            }
        }

        private void DIVIDER_MODE_SEL_checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            var control = sender as CheckBox;

            if (control.Checked)
            {
                SendData("gpio_s DIVIDER_MODE_SEL");
            }
            else
            {
                SendData("gpio_c DIVIDER_MODE_SEL");
            }
        }

        private void V_BAT_MEAS_EN_checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            var control = sender as CheckBox;

            if (control.Checked)
            {
                SendData("gpio_s V_BAT_MEAS_EN");
            }
            else
            {
                SendData("gpio_c V_BAT_MEAS_EN");
            }
        }

        private void HYDRATE_checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            var control = sender as CheckBox;

            if (control.Checked)
            {
                SendData("gpio_s HYDRATE");
            }
            else
            {
                SendData("gpio_c HYDRATE");
            }
        }

        private void RED_LED_checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            var control = sender as CheckBox;

            if (control.Checked)
            {
                SendData("gpio_s RED_LED");
            }
            else
            {
                SendData("gpio_c RED_LED");
            }
        }

        private void GREEN_LED_checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            var control = sender as CheckBox;

            if (control.Checked)
            {
                SendData("gpio_s GREEN_LED");
            }
            else
            {
                SendData("gpio_c GREEN_LED");
            }
        }

        private void DAC1_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendData(string.Format("dac1 {0}", DAC1_textBox.Text));
            }
        }

        private void Reg4_textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tbVvalue = sender as TextBox;
            string crop = tbVvalue.Text.Substring(2, (tbVvalue.TextLength - 2));
            int bValue = int.Parse(crop, System.Globalization.NumberStyles.HexNumber);
            bool bValue_b7 = (bValue & (1 << 7)) != 0;
            bool bValue_b6 = (bValue & (1 << 6)) != 0;
            bool bValue_b5 = (bValue & (1 << 5)) != 0;
            bool bValue_b4 = (bValue & (1 << 4)) != 0;
            bool bValue_b3 = (bValue & (1 << 3)) != 0;
            bool bValue_b2 = (bValue & (1 << 2)) != 0;
            bool bValue_b1 = (bValue & (1 << 1)) != 0;
            bool bValue_b0 = (bValue & (1 << 0)) != 0;

            int I_chg = 500;

            if (bValue_b7) { I_chg += 800; }
            if (bValue_b6) { I_chg += 400; }
            if (bValue_b5) { I_chg += 200; }
            if (bValue_b4) { I_chg += 100; }
            if (bValue_b3) { I_chg += 50; }

            if ((500 <= I_chg)&&(I_chg<=2000))
            {
                Chg_current_trackBar.Value = I_chg;
            }


        }

        private void Reg1_textBox_TextChanged(object sender, EventArgs e)
        {
           TextBox tbVvalue = sender as TextBox;
           string crop = tbVvalue.Text.Substring(2, (tbVvalue.TextLength-2));
           int bValue = int.Parse(crop, System.Globalization.NumberStyles.HexNumber);
           int Fault = bValue & 0x0f;
           int STAT = bValue & 0x30;

           switch (STAT)
           {
               case 0: STAT_textBox.Text = "Ready";
                   break;
               case 16: STAT_textBox.Text = "Charging";
                   break;
               case 17: STAT_textBox.Text = "Done";
                   break;
               case 18: STAT_textBox.Text = "Fault";
                   break;
               default: break;


           }
            switch (Fault)
           {
               case 0: fault_textBox.Text = "Normal";
                   break;
               case 1: fault_textBox.Text = "Input OVP";
                   break;
               case 2: fault_textBox.Text = "Input UVLO";
                   break;
               case 3: fault_textBox.Text = "Sleep";
                   break;
               case 4: fault_textBox.Text = "Bat Temp Fault";
                   break;
               case 5: fault_textBox.Text = "Bat OVP";
                   break;
               case 6: fault_textBox.Text = "Thermal Shutdown";
                   break;
               case 7: fault_textBox.Text = "Timer Fault";
                   break;
               case 8: fault_textBox.Text = "No Bat";
                   break;
               case 9: fault_textBox.Text = "ISET short";
                   break;
               case 10: fault_textBox.Text = "Input Fault & LDO low";
                   break;

               default: break;
           }
        }

        private void V_BAT_textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tbVvalue = sender as TextBox;
            string crop = tbVvalue.Text.Substring(0, (tbVvalue.TextLength - 2));
            int iValue = Convert.ToInt16(crop);
            if ((V_BAT_prog.Maximum > iValue)&(iValue > V_BAT_prog.Minimum))
            {
                V_BAT_prog.Value = iValue;
            }

            if (V_BAT_textBox.Text != "" && I_BAT_textBox.Text != "")
            {
                crop = V_BAT_textBox.Text.Substring(0, (V_BAT_textBox.TextLength - 2));
                int iVolts = Convert.ToInt16(crop);
                float fVolts = ((float)iVolts) / 1000;

                crop = I_BAT_textBox.Text.Substring(0, (I_BAT_textBox.TextLength - 2));
                int iAmps = Convert.ToInt16(crop);
                float fAmps = ((float)iAmps) / 1000;
                double fWatts = Math.Round((fVolts * fAmps), 2);

                W_BAT_textBox.Text = Convert.ToString(fWatts);
            }

        }

        private void Reg1_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void VBOP_textBox_TextChanged(object sender, EventArgs e)
        {
            if (VBOP_textBox.Text != "" && I_BOP_textBox.Text != "")
            {
                string crop = VBOP_textBox.Text.Substring(0, (VBOP_textBox.TextLength - 2));
                int iVolts = Convert.ToInt16(crop);
                float fVolts = ((float)iVolts)/1000;

                crop = I_BOP_textBox.Text.Substring(0, (I_BOP_textBox.TextLength - 2));
                int iAmps = Convert.ToInt16(crop);
                float fAmps = ((float)iAmps) / 1000;
                double fWatts = Math.Round((fVolts * fAmps), 2);

                W_BOP_textBox.Text = Convert.ToString(fWatts);
            }
        }

        private void VUSB_textBox_TextChanged(object sender, EventArgs e)
        {
            if (VUSB_textBox.Text != "" && I_USB_textBox.Text != "")
            {
                string crop = VUSB_textBox.Text.Substring(0, (VUSB_textBox.TextLength - 2));
                int iVolts = Convert.ToInt16(crop);
                float fVolts = ((float)iVolts) / 1000;

                crop = I_USB_textBox.Text.Substring(0, (I_USB_textBox.TextLength - 2));
                int iAmps = Convert.ToInt16(crop);
                float fAmps = ((float)iAmps) / 1000;
                double fWatts = Math.Round((fVolts * fAmps), 2);

                W_USB_textBox.Text = Convert.ToString(fWatts);
            }
        }

        private void Chg_current_trackBar_Scroll(object sender, EventArgs e)
        {
            chg_rate_textBox.Text = "" + Chg_current_trackBar.Value;
        }

        private void Chg_current_trackBar_ValueChanged(object sender, EventArgs e)
        {
            chg_rate_textBox.Text = "" + Chg_current_trackBar.Value;
        }

        private void Chr_rate_send_button_Click(object sender, EventArgs e)
        {
           
            string crop = Reg4_textBox.Text.Substring(2, (Reg4_textBox.TextLength - 2));
            int current_value = int.Parse(crop, System.Globalization.NumberStyles.HexNumber);
            current_value = (current_value) & 7; 


            int new_value = (Convert.ToInt32(chg_rate_textBox.Text)-500);
            BitArray new_value_b = new BitArray(8);   

            if (new_value >= 800) { 
                new_value_b[7] = true;
                new_value -= 800;
            }
            if (new_value >= 400) {
                new_value_b[6] = true;
                new_value -= 400;
            }
            if (new_value >= 200)
            {
                new_value_b[5] = true;
                new_value -= 200;
            }
            if (new_value >= 100)
            {
                new_value_b[4] = true;
                new_value -= 100;
            }
            if (new_value >= 50)
            {
                new_value_b[3] = true;
                new_value -= 50;
            }

            int[] result = new int[1];
            new_value_b.CopyTo(result, 0);

            new_value = result[0] | current_value;
           
            string hex_value = string.Format("{0:X2}", new_value);

            SendData(string.Format("batchg_w 3 {0}", hex_value));

        }

        private void Reg2_textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tbVvalue = sender as TextBox;
            string crop = tbVvalue.Text.Substring(2, (tbVvalue.TextLength - 2));
            int bValue = int.Parse(crop, System.Globalization.NumberStyles.HexNumber);
            int Fault = bValue & 0x0f;
            int Iin_limit = bValue & 0x70;
            int EN_STAT = bValue & 0x8;
            int EN_TERM = bValue & 0x4;
            int nCE= bValue & 0x2;

            switch (Iin_limit)
            {
                case 0: Iin_limit_textBox.Text = "100mA";
                    break;
                case 16: Iin_limit_textBox.Text = "150mA";
                    break;
                case 32: Iin_limit_textBox.Text = "500mA";
                    break;
                case 48: Iin_limit_textBox.Text = "900mA";
                    break;
                case 64: Iin_limit_textBox.Text = "1500mA";
                    break;
                case 80: Iin_limit_textBox.Text = "2000mA";
                    break;
                case 96: Iin_limit_textBox.Text = "Ext ILIM";
                    break;
                case 112: Iin_limit_textBox.Text = "none";
                    break;
                default: break;
            }
           switch (EN_STAT)
           {
               case 0: EN_STAT_checkbox.Checked = false;
                   break;
               case 8: EN_STAT_checkbox.Checked = true;
                   break;
               default: break;
           }
           switch (EN_TERM)
           {
               case 0: EN_TERM_checkBox.Checked = false;
                   break;
               case 4: EN_TERM_checkBox.Checked = true;
                   break;
               default: break;
           }
              switch (nCE)
           {
               case 0:  nCH_checkBox.Checked = false;
                   break;
               case 2: nCH_checkBox.Checked = true;
                   break;
               default: break;
           }
        }


       

 

    }
    }
