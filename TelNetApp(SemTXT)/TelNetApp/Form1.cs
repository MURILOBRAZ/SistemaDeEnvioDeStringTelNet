using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
namespace TelNetApp
{
    public partial class Form1 : Form
    {
        private IPAddress ip;
        public Form1()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            ip = IPAddress.Parse("192.168.5.70"); // Endere�o IP est�tico definido

        }

        #region BOT�O1
        private void button1_Click(object sender, EventArgs e)
        {

            string texto = txtBx1.Text;


            EnviarTextoTelnet(texto);

        }
        #endregion

        #region BOT�O2
        private void buttonEnviar2_Click(object sender, EventArgs e)
        {
            string texto = txtBx2.Text;

            EnviarTextoTelnet(texto);
        }
        #endregion

        #region BOT�O3
        private void button2_Click(object sender, EventArgs e)
        {
            string texto = txtBx3.Text;

            EnviarTextoTelnet(texto);
        }
        #endregion

        #region BOT�O4
        private void button3_Click(object sender, EventArgs e)
        {
            string texto = txtBx4.Text;

            EnviarTextoTelnet(texto);
        }
        #endregion

        #region BOT�O5
        private void button4_Click(object sender, EventArgs e)
        {
            string texto = txtBx5.Text;

            EnviarTextoTelnet(texto);
        }
        #endregion

        #region ENVIAR TelNet
        private void EnviarTextoTelnet(string texto)
        {
            int porta = 22201; // Endere�o da porta;
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    client.Connect(ip, porta);
                    using (StreamWriter writer = new StreamWriter(client.GetStream()))
                    using (StreamReader reader = new StreamReader(client.GetStream()))
                    {
                        // Enviar o texto para o servidor
                        writer.WriteLine("RT=" + texto);
                        writer.Flush();

                        // Ler a resposta do servidor (opcional)
                        //string resposta = reader.ReadToEnd();
                        //MessageBox.Show(resposta);
                    }
                    //client.EndConnect(ip, porta);
                }
            }
            catch (SocketException)
            {
                MessageBox.Show("N�o foi poss�vel conectar ao servidor Telnet.");
            }
        }
        #endregion

        private void load(object sender, EventArgs e)
        {

        }
    }
}