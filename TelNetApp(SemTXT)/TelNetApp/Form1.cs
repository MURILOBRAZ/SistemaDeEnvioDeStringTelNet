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

            ip = IPAddress.Parse("192.168.5.70"); // Endereço IP estático definido

        }

        #region BOTÃO1
        private void button1_Click(object sender, EventArgs e)
        {

            string texto = txtBx1.Text;


            EnviarTextoTelnet(texto);

        }
        #endregion

        #region BOTÃO2
        private void buttonEnviar2_Click(object sender, EventArgs e)
        {
            string texto = txtBx2.Text;

            EnviarTextoTelnet(texto);
        }
        #endregion

        #region BOTÃO3
        private void button2_Click(object sender, EventArgs e)
        {
            string texto = txtBx3.Text;

            EnviarTextoTelnet(texto);
        }
        #endregion

        #region BOTÃO4
        private void button3_Click(object sender, EventArgs e)
        {
            string texto = txtBx4.Text;

            EnviarTextoTelnet(texto);
        }
        #endregion

        #region BOTÃO5
        private void button4_Click(object sender, EventArgs e)
        {
            string texto = txtBx5.Text;

            EnviarTextoTelnet(texto);
        }
        #endregion

        #region ENVIAR TelNet
        private void EnviarTextoTelnet(string texto)
        {
            int porta = 22201; // Endereço da porta;
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
                MessageBox.Show("Não foi possível conectar ao servidor Telnet.");
            }
        }
        #endregion

        private void load(object sender, EventArgs e)
        {

        }
    }
}