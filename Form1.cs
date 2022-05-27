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

namespace AtividadeN1
{
    public partial class Form1 : Form
    {
        string protocolo, RxData;
        string usuario = "JULIO";
        string senha = "1010";
        delegate void ExecutaMetodo();
        public Form1()
        {
            InitializeComponent();
        }

        void LeituraPortaSerial()
        {
            RxData = serialPort1.ReadLine();
            txbRxData.Text = RxData;

            if (RxData.IndexOf("[M1ON]") != -1) { motor1.Value = true; }
            if (RxData.IndexOf("[M2ON]") != -1) { motor2.Value = true; }
            if (RxData.IndexOf("[M3ON]") != -1) { motor3.Value = true; }
            if (RxData.IndexOf("[M4ON]") != -1) { motor4.Value = true; }
            if (RxData.IndexOf("[M5ON]") != -1) { motor5.Value = true; }

            if (RxData.IndexOf("[M1OFF]") != -1) { motor1.Value = false; }
            if (RxData.IndexOf("[M2OFF]") != -1) { motor2.Value = false; }
            if (RxData.IndexOf("[M3OFF]") != -1) { motor3.Value = false; }
            if (RxData.IndexOf("[M4OFF]") != -1) { motor4.Value = false; }
            if (RxData.IndexOf("[M5OFF]") != -1) { motor5.Value = false; }

            if (RxData.IndexOf("[EXA1ON]") != -1) { fan1.Value = true; }
            if (RxData.IndexOf("[EXA2ON]") != -1) { fan2.Value = true; }
            if (RxData.IndexOf("[EXA3ON]") != -1) { fan3.Value = true; }
            if (RxData.IndexOf("[EXA4ON]") != -1) { fan4.Value = true; }
            if (RxData.IndexOf("[EXA5ON]") != -1) { fan5.Value = true; }

            if (RxData.IndexOf("[EXA1OFF]") != -1) { fan1.Value = false; }
            if (RxData.IndexOf("[EXA2OFF]") != -1) { fan2.Value = false; }
            if (RxData.IndexOf("[EXA3OFF]") != -1) { fan3.Value = false; }
            if (RxData.IndexOf("[EXA4OFF]") != -1) { fan4.Value = false; }
            if (RxData.IndexOf("[EXA5OFF]") != -1) { fan5.Value = false; }

            if (RxData.IndexOf("[STON]") != -1) { pilotoSistOn.Value = true; }
            if (RxData.IndexOf("[STOFF]") != -1) { pilotoSistOn.Value = false; }
            if (RxData.IndexOf("[EMON]") != -1) 
            {
                pilotoLEM.Value = true;
                motor1.Value = motor2.Value = motor3.Value = motor4.Value = motor5.Value = false;
                fan1.Value = fan2.Value = fan3.Value = fan4.Value = fan5.Value = false;
                btnEn.Enabled = false;
            }
            if (RxData.IndexOf("[EMOFF]") != -1)
            {
                pilotoLEM.Value = false;
                btnEn.Enabled = true;
                
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ExecutaMetodo obj_delegate = new ExecutaMetodo(LeituraPortaSerial);
            Invoke(obj_delegate);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region ConfigPorta
            string[] PortaCom = SerialPort.GetPortNames();
            string[] BaudRate = { "1200", "2400", "4800", "9600" };
            cbxPortCom.Items.AddRange(PortaCom);
            cbxBaudRate.Items.AddRange(BaudRate);

            #endregion
            MessageBox.Show("Atenção; para habilitar o sistema é necessario Conectar\na uma porta serial e acionar EN");
        }

        void TesteMotor()
        {
            if (cbxContrMot.Text == "MOTOR1ON") {protocolo = "[MOTOR1ON]"; }
            if (cbxContrMot.Text == "MOTOR2ON") {protocolo = "[MOTOR2ON]"; }
            if (cbxContrMot.Text == "MOTOR3ON") {protocolo = "[MOTOR3ON]"; }
            if (cbxContrMot.Text == "MOTOR4ON") {protocolo = "[MOTOR4ON]"; }
            if (cbxContrMot.Text == "MOTOR5ON") {protocolo = "[MOTOR5ON]"; }

            if (cbxContrMot.Text == "MOTOR1OFF") { protocolo = "[MOTOR1OFF]"; }
            if (cbxContrMot.Text == "MOTOR2OFF") { protocolo = "[MOTOR2OFF]"; }
            if (cbxContrMot.Text == "MOTOR3OFF") { protocolo = "[MOTOR3OFF]"; }
            if (cbxContrMot.Text == "MOTOR4OFF") { protocolo = "[MOTOR4OFF]"; }
            if (cbxContrMot.Text == "MOTOR5OFF") { protocolo = "[MOTOR5OFF]"; }
        }

        void TesteExaustor()
        {
            if (cbxContrExa.Text == "EXAUSTOR1ON") { protocolo = "[EXAUSTOR1ON]"; }
            if (cbxContrExa.Text == "EXAUSTOR2ON") { protocolo = "[EXAUSTOR2ON]"; }
            if (cbxContrExa.Text == "EXAUSTOR3ON") { protocolo = "[EXAUSTOR3ON]"; }
            if (cbxContrExa.Text == "EXAUSTOR4ON") { protocolo = "[EXAUSTOR4ON]"; }
            if (cbxContrExa.Text == "EXAUSTOR5ON") { protocolo = "[EXAUSTOR5ON]"; }

            if (cbxContrExa.Text == "EXAUSTOR1OFF") { protocolo = "[EXAUSTOR1OFF]"; }
            if (cbxContrExa.Text == "EXAUSTOR2OFF") { protocolo = "[EXAUSTOR2OFF]"; }
            if (cbxContrExa.Text == "EXAUSTOR3OFF") { protocolo = "[EXAUSTOR3OFF]"; }
            if (cbxContrExa.Text == "EXAUSTOR4OFF") { protocolo = "[EXAUSTOR4OFF]"; }
            if (cbxContrExa.Text == "EXAUSTOR5OFF") { protocolo = "[EXAUSTOR5OFF]"; }
        }

        private void btnConectar_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
            else
            {
                serialPort1.PortName = cbxPortCom.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbxBaudRate.Text);
                serialPort1.Open();
                btnDesconectar.Enabled = true;
                btnConectar.Enabled = false;
                pilotoCom.Value = true;
                pilotoCom.Text = "ON";
            }
        }

        private void btnDesconectar_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                btnDesconectar.Enabled = false;
                btnConectar.Enabled = true;
                pilotoCom.Value = false;
                pilotoCom.Text = "OFF";
            }
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                this.Close();
            }
        }

        private void cbxContrMot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pilotoSistOn.Value == true)
            {
                if (serialPort1.IsOpen == true)
                {
                    TesteMotor();
                    serialPort1.Write(protocolo);
                }
                else
                {
                    MessageBox.Show("Erro de Conexão!..");
                }
            }
           
        }

        private void cbxContrExa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(pilotoSistOn.Value == true)
            {
                if (serialPort1.IsOpen == true)
                {
                    TesteExaustor();
                    serialPort1.Write(protocolo);
                }
                else
                {
                    MessageBox.Show("Erro de Conexão!..");
                }
            }
            
        }


        private void btnEn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("[SISTON]");
            }
            else
            {
                MessageBox.Show("Erro de Conexão!..");
            }
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("[SISTOFF]");
            }
            else
            {
                MessageBox.Show("Erro de Conexão!..");
            }
        }

        private void btnEmer_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("[SISTEMON]");
                
            }
            else
            {
                MessageBox.Show("Erro de Conexão!..");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == usuario && txtSenha.Text == senha) 
            {
                serialPort1.Write("[SISTEMOFF]");
                MessageBox.Show("Sistema Habilitado");
            }
            else
            {
                MessageBox.Show("Usuario/Senha Incorreto");
            }

        }
    }
}
