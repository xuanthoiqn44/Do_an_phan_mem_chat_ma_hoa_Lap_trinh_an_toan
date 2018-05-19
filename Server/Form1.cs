using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Numerics;
using System.Security.Cryptography;

namespace Server
{
    public partial class FormServer : Form
    {
        MD5 md5;
        Aes_256 aes;
        SHA256 mySHA256;
        byte[] key;
        byte[] iv;
        BigInteger p, g;
        delegate void SetTextCallback(string text);
        TcpListener listener;
        TcpClient client;
        NetworkStream ns;
        Thread t = null;
        IPEndPoint ipe;
        diffie_hellman dh;
        bool sesion = false;
        int i = 0;
        bool status = false;
        public FormServer()
        {
            InitializeComponent();
            aes = new Aes_256();
            mySHA256 = SHA256Managed.Create();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9090);
                listener = new TcpListener(ipe);
                listener.Start();
                client = listener.AcceptTcpClient();
                ns = client.GetStream();
                t = new Thread(DoWork);
                t.Start();
                //if (!status) { this.Invoke((MethodInvoker)delegate () { timer(); status = true; }); }
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void DoWork()
        {
            md5 = new MD5();
            byte[] bytes = new byte[1024];
            while (true)
            {
                int bytesRead = ns.Read(bytes, 0, bytes.Length);
                string text = Encoding.UTF8.GetString(bytes, 0, bytesRead);
                string[] mess = text.Split(';');
                switch(mess[0])
                {
                    case "1":
                       gen_keychung_va_send_key_public(mess);
                        sesion = true;
                        status = true;
                        break;
                    case "2":
                            gen_key_chung_from_key_public_receive(mess);
                        sesion = true;
                        break;
                    case "3":
                        if (!sesion)
                        {
                            this.Invoke((MethodInvoker)delegate () { gui_key(1); timer(); });
                        }
                        else
                        {
                            timer();
                            if (check_md5(mess[1], mess[4]))
                            {
                                decrypt_mess(mess);
                            }
                            else
                            {
                                this.SetText("Tin nhắn đã bị thay đổi", "Client");
                            }
                        }
                        break;
                    

                }
            }
        }

        private void SetText(string text, string type)
        {
            if (listBoxserver.InvokeRequired)
            {
                listBoxserver.Invoke(new MethodInvoker(delegate
                {
                    listBoxserver.Items.Add(type + ": " + text);
                }));
            }
        }
        private void insert(string text, string type)
        {
            listBoxserver.Items.Add(type + ": " + text);
        }

        
        private void buttonsend_Click(object sender, EventArgs e)
        {
            
        }
        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //tinh p, g
        public void Tao_p_g()
        {
            do
            {
                p = soNgauNhien();
                g = (p - 1) / 2;
            } while (!kiemTraNguyenTo((int)p));
        }

        //randdom p
        private int soNgauNhien()
        {
            Random rd = new Random();
            return rd.Next(1, 10000);
        }
        //kt nguyen to
        private bool kiemTraNguyenTo(int i)
        {
            bool kiemtra = true;
            for (int j = 2; j < i; j++)
                if (i % j == 0)
                    kiemtra = false;
            return kiemtra;
        }
        public void senddata(string text)
        {
            byte[] byteTime = Encoding.UTF8.GetBytes(text);
            ns.Write(byteTime, 0, byteTime.Length);
        }
        public void encryptmess(string mess)
        {
            md5 = new MD5();
            aes = new Aes_256();
            mySHA256 = SHA256Managed.Create();
            //array bytes message
            byte[] mess1 = Encoding.UTF8.GetBytes(mess);
            ////array bytes key chung
            byte[] key1 = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(Convert.ToString(dh.Key_Chung)));
            //get daytime
            string ivc = getdatime();
            //array bytes iv from daytime , start index 2
            byte[] iv = create_init_vector(ivc, 2);
            textBoxiv.Text = Convert.ToBase64String(iv);
            //get 32 byte from datime for padding
            byte[] dayhash = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(ivc));
            //encrypt message
            string encrypt = aes.EncryptString(mess1, key1, iv, dayhash);
            string[] enc1 = encrypt.Split(';');
            string mess_md5 = md5.GetMD5(enc1[0]+ Convert.ToString(dh.Key_Chung)) ;
            //byte[] enc = Encoding.ASCII.GetBytes(encrypt);
            string messsend = "3;"+ encrypt + ";" + ivc +";"+mess_md5;
            textBoxmessnoise.Text = messsend;
            senddata(messsend);
        }
        public string getdatime()
        {
            //DateTime thisDay = DateTime.Today;
            //return DateTime.Now.ToString("h:mm:ss tt");
            return DateTime.Now.ToString("dd - MM - yyyy hh: mm: ss tt");
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            labeltimer1.Text = "Timer: "+ i;
            if(i == 20)
            {
                sesion = false;
                //this.Invoke((MethodInvoker)delegate () { senddata("message;1"); });
                timer1.Stop();
                i = 0;
            }
        }

        public byte[] create_init_vector(string iv, int index)
        {
            SHA256 mySHA256 = SHA256Managed.Create();
            byte[] tmp = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(iv));
            byte[] ivc = new byte[16];
            for (int i = 0; i < 16; i++)
            {
                ivc[i] = tmp[i + index];
            }
            return ivc;
        }
        public void gui_key(int x)
        {
            Tao_p_g();
            dh = new diffie_hellman(p, g);
            string s = x + ";" + p + ";" + g + ";" + dh.Publickey;
            senddata(s);
        }
        
        public void decrypt_mess(string[] mess)
        {
            string encrypt = mess[1];
            string ivc = mess[3];
            int count = Convert.ToInt32(mess[2]);
            iv = create_init_vector(ivc, 2);
            textBoxiv.Text = Convert.ToBase64String(iv);
            string decrypt = aes.DecryptString(encrypt, key, iv, count);
            this.SetText(Convert.ToString(decrypt), "Client");
            
        }
        public void gen_keychung_va_send_key_public(string [] mess)
        {
            p = Convert.ToInt32(mess[1]);
            g = Convert.ToInt32(mess[2]);
            dh = new diffie_hellman(p, g);
            dh.Tinh_key_chung(Convert.ToInt32(mess[3]));
            key = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(Convert.ToString(dh.Key_Chung)));
            senddata(Convert.ToString(2 + ";" + dh.Publickey));
            this.SetText(Convert.ToString(dh.Key_Chung), "Client");
            textBoxkey.Text = Convert.ToBase64String(key);
            sesion = true;
        }
        public void gen_key_chung_from_key_public_receive(string[] mess)
        {
            dh.Tinh_key_chung(Convert.ToInt32(mess[1]));
            key = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(Convert.ToString(dh.Key_Chung)));
            this.SetText(Convert.ToString(dh.Key_Chung), "Client");
            textBoxkey.Text = Convert.ToBase64String(key);
            sesion = true;
        }

        private void buttonsend_Click_1(object sender, EventArgs e)
        {
            if (sesion == false)
            {
                gui_key(1);
                this.Invoke((MethodInvoker)delegate() { timer(); }) ;
            }
            else 
            {
                if (textBoxmessage.Text != "")
                {
                    encryptmess(textBoxmessage.Text);
                    this.insert(textBoxmessage.Text, "Me");
                    textBoxmessage.Clear();
                    this.Invoke((MethodInvoker)delegate () { timer(); });
                }
            }
        }

        private void buttonsendnoise_Click(object sender, EventArgs e)
        {
            senddata(textBoxmessnoise.Text);
            timer();
        }

        public bool check_md5(string encrypt,string md5_encrypt)
        {
            bool check = false;
            md5 = new MD5();
            string result = md5.GetMD5(encrypt + Convert.ToString(dh.Key_Chung));
            if (result == md5_encrypt)
            {
                check =  true;
            }
            return check;
        }
        private void timer()
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            i = 0;
            sesion = true;
        }
    }
}
