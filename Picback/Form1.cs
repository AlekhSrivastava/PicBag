using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Picback
{
    public partial class Form1 : Form
    {
        private const SortOrder descending = SortOrder.Descending;
        List<Panel> listPanel = new List<Panel>();
        int panelindex;
        private List<Image> loadedImages { get; set; }
        int selectedimageindex = 0;
        string optlink= "0";
        int Link = 0;

        string drive = "Drive";

        string cameraO;//= @"C:\Users\Arush\Desktop\fortesting";                          //might change further location
        string cameraN;//= @"D:\AppName\backups\Camera\";
        string[] allnamesCO;//= Directory.GetFiles(@"C:\Users\Alekh\Desktop\fortesting", "*.jpg");
        string[] allnamesCN;//= Directory.GetFiles(@"D:\AppName\backups\Camera", "*.jpg");
        string[] remain1  ;
        int countCO;//= Directory.GetFiles(@"C:\Users\Alekh\Desktop\fortesting", "*.jpg"/*, SearchOption.AllDirectories*/).Length;
        int countCN;// = Directory.GetFiles(@"D:\AppName\backups\Camera", "*.jpg"/*, SearchOption.AllDirectories*/).Length;
        int num1 = 0;


        string bluetoothO;
        string bluetoothN;
        string[] allnamesBO;
        string[] allnamesBN;
        string[] remain2;
        int countBO;
        int countBN;
        int num2 = 0;

        string SSO;
        string SSN;
        string[] allnamesSSO;
        string[] allnamesSSN;
        string[] remain3;
        int countSSO;
        int countSSN;
        int num3 = 0;

        string instaO;
        string instaN;
        string[] allnamesinstaO;
        string[] allnamesinstaN;
        string[] remain4;
        int countinstaO;
        int countinstaN;
        int num4 = 0;

        string instaLYO;
        string instaLYN;
        string[] allnamesinstaLYO;
        string[] allnamesinstaLYN;
        string[] remain5;
        int countinstaLYO;
        int countinstaLYN;
        int num5 = 0;

        string fbO;
        string fbN;
        string[] allnamesfbO;
        string[] allnamesfbN;
        string[] remain6;
        int countfbO;
        int countfbN;
        int num6 = 0;

        string fbMO;
        string fbMN;
        string[] allnamesfbMO;
        string[] allnamesfbMN;
        string[] remain7;
        int countfbMO;
        int countfbMN;
        int num7 = 0;

        string whatsO;
        string whatsN;
        string[] allnameswhatsO;
        string[] allnameswhatsN;
        string[] remain8;
        int countwhatsO;
        int countwhatsN;
        int num8 = 0;

        string snapO;
        string snapN;
        string[] allnamessnapO;
        string[] allnamessnapN;
        string[] remain9;
        int countsnapO;
        int countsnapN;
        int num9 = 0;

        string LRO;
        string LRN;
        string[] allnamesLRO;
        string[] allnamesLRN;
        string[] remain10;
        int countLRO;
        int countLRN;
        int num10 = 0;

        string PSEXO;
        string PSEXN;
        string[] allnamesPSEXO;
        string[] allnamesPSEXN;
        string[] remain11;
        int countPSEXO;
        int countPSEXN;
        int num11 = 0;

        string PSMIXO;
        string PSMIXN;
        string[] allnamesPSMIXO;
        string[] allnamesPSMIXN;
        string[] remain12;
        int countPSMIXO;
        int countPSMIXN;
        int num12 = 0;

        string PSFIXO;
        string PSFIXN;
        string[] allnamesPSFIXO;
        string[] allnamesPSFIXN;
        string[] remain13;
        int countPSFIXO;
        int countPSFIXN;
        int num13 = 0;

        string CCO;
        string CCN;
        string[] allnamesCCO;
        string[] allnamesCCN;
        string[] remain14;
        int countCCO;
        int countCCN;
        int num14 = 0;

        string YCO;
        string YCN;
        string[] allnamesYCO;
        string[] allnamesYCN;
        string[] remain15;
        int countYCO;
        int countYCN;
        int num15 = 0;

        string B612O;
        string B612N;
        string[] allnamesB612O;
        string[] allnamesB612N;
        string[] remain16;
        int countB612O;
        int countB612N;
        int num16 = 0;

        string PAO;
        string PAN;
        string[] allnamesPAO;
        string[] allnamesPAN;
        string[] remain17;
        int countPAO;
        int countPAN;
        int num17 = 0;

        string PLO;
        string PLN;
        string[] allnamesPLO;
        string[] allnamesPLN;
        string[] remain18;
        int countPLO;
        int countPLN;
        int num18 = 0;

        string PolishO;
        string PolishN;
        string[] allnamesPolishO;
        string[] allnamesPolishN;
        string[] remain19;
        int countPolishO;
        int countPolishN;
        int num19 = 0;

        string instaSQO;
        string instaSQN;
        string[] allnamesinstaSQO;
        string[] allnamesinstaSQN;
        string[] remain20;
        int countinstaSQO;
        int countinstaSQN;
        int num20 = 0;

        string retricaO;
        string retricaN;
        string[] allnamesretricaO;
        string[] allnamesretricaN;
        string[] remain21;
        int countretricaO;
        int countretricaN;
        int num21 = 0;

        string SSeedO;
        string SSeedN;
        string[] allnamesSSeedO;
        string[] allnamesSSeedN;
        string[] remain22;
        int countSSeedO;
        int countSSeedN;
        int num22 = 0;








        public Form1()
        {
            Thread splashTHREAD = new Thread(new ThreadStart(startsplashscreen));
            splashTHREAD.Start();
            Thread.Sleep(3000);                                                                                       
            InitializeComponent();
            splashTHREAD.Abort();
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);

            progress.Visible = false;
 

        }

        public void startsplashscreen()
        {
            Application.Run(new Splash());
        }
        protected override void OnFormClosing(FormClosingEventArgs e)                               // confermation befor quit
        {
            base.OnFormClosing(e);
            if(PreClosingConfermation()== System.Windows.Forms.DialogResult.Yes)
            {
                if (Directory.Exists(drive + @"\BUCKET"))
                {
                    Directory.Delete(drive + @"\BUCKET", true);
                }
                Dispose(true);
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
        private DialogResult PreClosingConfermation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show("Do you want to quit ?", "Close", MessageBoxButtons.YesNo);
            return res;
        }
        private void forward_Click_1(object sender, EventArgs e)
        {
            if (panelindex < listPanel.Count - 1)
                listPanel[++panelindex].BringToFront();
        }
        private void backward_Click(object sender, EventArgs e)
        {
            if (panelindex > 0)
                listPanel[--panelindex].BringToFront();
        }
        public void OnProcessExit(object sender,EventArgs e)   ///this the extra one
        {
            if (Directory.Exists(drive + @"\BUCKET"))
            {
                Directory.Delete(drive + @"\BUCKET", true);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            MaximizeBox = false;
            
            
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel[panelindex].BringToFront();

            driveList.SelectedIndex = 0;

            driveList.Items.Add(" A:");
            driveList.Items.Add(" B:");
            driveList.Items.Add(" C:");
            driveList.Items.Add(" D:");
            driveList.Items.Add(" E:");
            driveList.Items.Add(" F:");
            driveList.Items.Add(" G:");
            driveList.Items.Add(" H:");
            driveList.Items.Add(" I:");
            driveList.Items.Add(" J:");
            driveList.Items.Add(" K:");
            driveList.Items.Add(" K:");
            driveList.Items.Add(" L:");
            driveList.Items.Add(" M:");
            driveList.Items.Add(" N:");
            driveList.Items.Add(" O:");
            driveList.Items.Add(" P:");
            driveList.Items.Add(" Q:");
            driveList.Items.Add(" R:");
            driveList.Items.Add(" S:");
            driveList.Items.Add(" T:");
            driveList.Items.Add(" U:");
            driveList.Items.Add(" V:");
            driveList.Items.Add(" W:");
            driveList.Items.Add(" X:");
            driveList.Items.Add(" Y:");
            driveList.Items.Add(" Z:");
        }
        //private void driveList_SelectionChangeCommitted_1(object sender, EventArgs e)
        //{
        //    drive = driveList.Text;
        //    Directory.CreateDirectory(drive + @"\BUCKET\");
        //}
        private void driveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            drive = driveList.Text;
            if (Directory.Exists(drive + "\\"))
            {
                Directory.CreateDirectory(drive + @"\BUCKET\");

                cameraO = (drive + @"\BUCKET\DCIM\Camera");
                cameraN = (drive + @"\Picbag\bin\Camera\");

                bluetoothO = (drive + @"\BUCKET\Bluetooth");
                bluetoothN = (drive + @"\Picbag\bin\Bluetooth\");

                SSO = (drive + @"\BUCKET\DCIM\Screenshots");
                SSN = (drive + @"\Picbag\bin\Screenshots\");

                instaO = (drive + @"\BUCKET\Pictures\Instagram");
                instaN = (drive + @"\Picbag\bin\Instagram\");

                instaLYO = (drive + @"\BUCKET\Pictures\Layout");
                instaLYN = (drive + @"\Picbag\bin\Layout\");

                fbO = (drive + @"\BUCKET\DCIM\Facebook");
                fbN = (drive + @"\Picbag\bin\Facebook\");

                fbMO = (drive + @"\BUCKET\Pictures\Messenger");
                fbMN = (drive + @"\Picbag\bin\Messenger\");

                whatsO = (drive + @"\BUCKET\WhatsApp\Media\WhatsApp Images");
                whatsN = (drive + @"\Picbag\bin\WhatsApp\");

                snapO = (drive + @"\BUCKET\Snapchat");
                snapN = (drive + @"\Picbag\bin\Snapchat\");

                LRO = (drive + @"\BUCKET\Pictures\AdobeLightroom");
                LRN = (drive + @"\Picbag\bin\Lightroom\");

                PSMIXO = (drive + @"\BUCKET\Pictures\Adobe Photoshop Mix");
                PSMIXN = (drive + @"\Picbag\bin\Photoshop Mix\");

                PSFIXO = (drive + @"\BUCKET\Pictures\Adobe Photoshop Fix");
                PSFIXN = (drive + @"\Picbag\bin\Photoshop Fix\");

                CCO = (drive + @"\BUCKET\DCIM\CandyCam");
                CCN = (drive + @"\Picbag\bin\CandyCam\");

                YCO = (drive + @"\BUCKET\DCIM\YouCam Perfect");
                YCN = (drive + @"\Picbag\bin\YouCam Perfect\");

                B612O = (drive + @"\BUCKET\Pictures\B612");
                B612N = (drive + @"\Picbag\bin\B612\");

                PAO = (drive + @"\BUCKET\Pictures\PicsArt");                            //may add .png later
                PAN = (drive + @"\Picbag\bin\PicsArt\");

                PLO = (drive + @"\BUCKET\Pictures\PhotoLab");
                PLN = (drive + @"\Picbag\bin\Photo Lab\");

                PolishO = (drive + @"\BUCKET\Photo Editor");
                PolishN = (drive + @"\Picbag\bin\Polish (Photo Editor Pro)\");

                instaSQO = (drive + @"\BUCKET\insta_square");
                instaSQN = (drive + @"\Picbag\bin\Insta Square\");

                retricaO = (drive + @"\BUCKET\DCIM\Retrica");
                retricaN = (drive + @"\Picbag\bin\Retrica\");

                SSeedO = (drive + @"\BUCKET\Snapseed");
                SSeedN = (drive + @"\Picbag\bin\Snaapseed\");

                PSEXO = (drive + @"\BUCKET\Pictures\Photoshop Express");
                PSEXN = (drive + @"\Picbag\bin\Photoshop Express\");
            }
        }
        private void BtnCan_Click(object sender, EventArgs e)
        {
            if (PreClosingConfermation() == System.Windows.Forms.DialogResult.Yes)
            {
                if (Directory.Exists(drive + @"\BUCKET"))
                {
                    Directory.Delete(drive + @"\BUCKET",true);
                }
                Dispose(true);
                Application.Exit();
            }
        }

        private void btnsrch_Click(object sender, EventArgs e)
        {
            drive = driveList.Text;
            if (Directory.Exists(drive + @"\BUCKET\"))
            {
                if (drive != "Drive")
                {
                    driveList.Enabled = false;
                }

                if (Directory.Exists(cameraO))
                {
                    Directory.CreateDirectory(cameraN);
                    allnamesCO = Directory.GetFiles(cameraO, "*.jpg");//(@"C:\Users\Alekh\Desktop\fortesting", "*.jpg");
                    allnamesCN = Directory.GetFiles(cameraN, "*.jpg");//(@"D:\AppName\backups\Camera", "*.jpg");
                    countCO = Directory.GetFiles(cameraO, "*.jpg"/*, SearchOption.AllDirectories*/).Length; //(@"C:\Users\Alekh\Desktop\fortesting", "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countCN = Directory.GetFiles(cameraN, "*.jpg"/*, SearchOption.AllDirectories*/).Length; //(@"D:\AppName\backups\Camera", "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countCO == 0)
                    {
                        MessageBox.Show("No backup were found for camera");
                    }
                    else
                    {
                        if (countCN == 0)
                        {
                            foreach (string log in allnamesCO)
                            {
                                remain1 = allnamesCO;
                            }
                            num1 = countCO;

                            Link += 1;//MessageBox.Show("Backup available");
                        }

                        else
                        {
                            foreach (string name in allnamesCO)
                            {
                                if (!(File.Exists(cameraN + Path.GetFileName(name))))
                                {
                                    //remain1[num1] = (name);
                                    //num1 += 1;
                                    remain1 = allnamesCO;
                                    Link += 1;
                                }
                            }
                        }
                    }
                }

                if (Directory.Exists(bluetoothO))
                {
                    Directory.CreateDirectory(bluetoothN);
                    allnamesBO = Directory.GetFiles(bluetoothO, "*.jpg");
                    allnamesBN = Directory.GetFiles(bluetoothN, "*.jpg");
                    countBO = Directory.GetFiles(bluetoothO, "*.jpg"/*, SearchOption.AllDirectories*/).Length; 
                    countBN = Directory.GetFiles(bluetoothN, "*.jpg"/*, SearchOption.AllDirectories*/).Length; 
                    if (countBO == 0)
                    {
                        MessageBox.Show("No backup were found for bluetooth");
                    }
                    else
                    {
                        if (countBN == 0)
                        {
                            foreach (string log in allnamesBO)
                            {
                                remain2 = allnamesBO;
                            }
                            num2 = countBO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamesBO)
                            {
                                if (!(File.Exists(bluetoothN + Path.GetFileName(name))))
                                {
                                    //remain2[num2] = (name);
                                    //num2 += 1;
                                    remain2 = allnamesBO;
                                    Link += 1;
                                }
                            }
                        }
                    }
                }

                if (Directory.Exists(SSO))
                {
                    Directory.CreateDirectory(SSN);
                    allnamesBO = Directory.GetFiles(SSO, "*.jpg");
                    allnamesBN = Directory.GetFiles(SSN, "*.jpg");
                    countBO = Directory.GetFiles(SSO, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countBN = Directory.GetFiles(SSN, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countSSO == 0)
                    {
                        MessageBox.Show("No backup were found for screenshot");
                    }
                    else
                    {
                        if (countSSN == 0)
                        {
                            foreach (string log in allnamesSSO)
                            {
                                remain3 = allnamesSSO;
                            }
                            num3 = countSSO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamesSSO)
                            {
                                if (!(File.Exists(SSN + Path.GetFileName(name))))
                                {
                                    //remain1[num3] = (name);
                                    //num3 += 1;
                                    remain3 = allnamesSSO;
                                    Link += 1;
                                }
                            }

                        }
                    }
                }

                if (Directory.Exists(instaO))
                {
                    Directory.CreateDirectory(instaN);
                    allnamesinstaO = Directory.GetFiles(instaO, "*.jpg");
                    allnamesinstaN = Directory.GetFiles(instaN, "*.jpg");
                    countinstaO = Directory.GetFiles(instaO, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countinstaN = Directory.GetFiles(instaN, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countinstaO == 0)
                    {
                        MessageBox.Show("No backup were found for instagram");
                    }
                    else
                    {
                        if (countinstaN == 0)
                        {
                            foreach (string log in allnamesinstaO)
                            {
                                remain4 = allnamesinstaO;
                            }
                            num4 = countinstaO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamesinstaO)              //here we have to check  AND add Link to else
                            {
                                if (!(File.Exists(instaN + Path.GetFileName(name))))
                                {
                                    //remain4[num4] = (name);
                                    //num4 += 1;
                                    remain4 = allnamesinstaO;
                                    Link += 1;
                                }
                            }

                        }
                    }
                }

                if (Directory.Exists(instaLYO))
                {
                    Directory.CreateDirectory(instaLYN);
                    allnamesinstaLYO = Directory.GetFiles(instaLYO, "*.jpg");
                    allnamesinstaLYN = Directory.GetFiles(instaLYN, "*.jpg");
                    countinstaLYO = Directory.GetFiles(instaLYO, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countinstaLYN = Directory.GetFiles(instaLYN, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countinstaLYO == 0)
                    {
                        MessageBox.Show("No backup were found layout");
                    }
                    else
                    {
                        if (countinstaLYN == 0)
                        {
                            foreach (string log in allnamesinstaLYO)
                            {
                                remain5 = allnamesinstaLYO;
                            }
                            num4 = countinstaLYO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamesinstaLYO)
                            {
                                if (!(File.Exists(instaLYN + Path.GetFileName(name))))
                                {
                                    //remain5[num5] = (name);
                                    //num5 += 1;
                                    remain5 = allnamesinstaLYO;
                                    Link += 1;
                                }
                            }

                        }
                    }
                }

                if (Directory.Exists(fbO))
                {
                    Directory.CreateDirectory(fbN);
                    allnamesfbO = Directory.GetFiles(fbO, "*.jpg");
                    allnamesfbN = Directory.GetFiles(fbN, "*.jpg");
                    countfbO = Directory.GetFiles(fbO, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countfbN = Directory.GetFiles(fbN, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countfbO == 0)
                    {
                        MessageBox.Show("No backup were found for facebook");
                    }
                    else
                    {
                        if (countfbN == 0)
                        {
                            foreach (string log in allnamesfbO)
                            {
                                remain6 = allnamesfbO;
                            }
                            num6 = countfbO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamesfbO)
                            {
                                if (!(File.Exists(fbN + Path.GetFileName(name))))
                                {
                                    //remain6[num6] = (name);
                                    //num6 += 1;
                                    remain6 = allnamesfbO;
                                    Link += 1;
                                }
                            }

                        }
                    }
                }

                if (Directory.Exists(fbMO))
                {
                    Directory.CreateDirectory(fbMN);
                    allnamesfbMO = Directory.GetFiles(fbMO, "*.jpg");
                    allnamesfbMN = Directory.GetFiles(fbMN, "*.jpg");
                    countfbMO = Directory.GetFiles(fbMO, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countfbMN = Directory.GetFiles(fbMN, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countfbMO == 0)
                    {
                        MessageBox.Show("No backup were found massenger");
                    }
                    else
                    {
                        if (countfbMN == 0)
                        {
                            foreach (string log in allnamesfbMO)
                            {
                                remain7 = allnamesfbMO;
                            }
                            num7 = countfbMO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamesfbMO)
                            {
                                if (!(File.Exists(fbMN + Path.GetFileName(name))))
                                {
                                    //remain7[num7] = (name);
                                    //num7 += 1;
                                    remain7 = allnamesfbMO;
                                    Link += 1;
                                }
                            }

                        }
                    }
                }

                if (Directory.Exists(whatsO))
                {
                    Directory.CreateDirectory(whatsN);
                    allnameswhatsO = Directory.GetFiles(whatsO, "*.jpg");
                    allnameswhatsN = Directory.GetFiles(whatsN, "*.jpg");
                    countwhatsO = Directory.GetFiles(whatsO, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countwhatsN = Directory.GetFiles(whatsN, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countwhatsO == 0)
                    {
                        MessageBox.Show("No backup were found for whatsapp");
                    }
                    else
                    {
                        if (countwhatsN == 0)
                        {
                            foreach (string log in allnameswhatsO)
                            {
                                remain8 = allnameswhatsO;
                            }
                            num8 = countwhatsO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnameswhatsO)
                            {
                                if (!(File.Exists(whatsN + Path.GetFileName(name))))
                                {
                                    //remain8[num8] = (name);
                                    //num8 += 1;
                                    remain8 = allnameswhatsO;
                                    Link += 1;
                                }
                            }

                        }
                    }
                }

                if (Directory.Exists(snapO))
                {
                    Directory.CreateDirectory(snapN);
                    allnamessnapO = Directory.GetFiles(snapO, "*.jpg");
                    allnamessnapN = Directory.GetFiles(snapN, "*.jpg");
                    countsnapO = Directory.GetFiles(snapO, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countsnapN = Directory.GetFiles(snapN, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countsnapO == 0)
                    {
                        MessageBox.Show("No backup were found for snapchat");
                    }
                    else
                    {
                        if (countsnapN == 0)
                        {
                            foreach (string log in allnamessnapO)
                            {
                                remain9 = allnamessnapO;
                            }
                            num9 = countsnapO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamessnapO)
                            {
                                if (!(File.Exists(snapN + Path.GetFileName(name))))
                                {
                                    //remain9[num9] = (name);
                                    //num9 += 1;
                                    remain9 = allnamessnapO;
                                    Link += 1;
                                }
                            }

                        }
                    }
                }

                if (Directory.Exists(LRO))
                {
                    Directory.CreateDirectory(LRN);
                    allnamesLRO = Directory.GetFiles(LRO, "*.jpg");
                    allnamesLRN = Directory.GetFiles(LRN, "*.jpg");
                    countLRO = Directory.GetFiles(LRO, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countLRN = Directory.GetFiles(LRN, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countLRO == 0)
                    {
                        MessageBox.Show("No backup were found for lightroom");
                    }
                    else
                    {
                        if (countLRN == 0)
                        {
                            foreach (string log in allnamesLRO)
                            {
                                remain10 = allnamesLRO;
                            }
                            num10 = countLRO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamesLRO)
                            {
                                if (!(File.Exists(LRN + Path.GetFileName(name))))
                                {
                                    //remain10[num10] = (name);
                                    //num10 += 1;
                                    remain10 = allnamesLRO;
                                    Link += 1;
                                }
                            }

                        }
                    }
                }

                if (Directory.Exists(PSEXO))
                {
                    Directory.CreateDirectory(PSEXN);
                    allnamesPSEXO = Directory.GetFiles(PSEXO, "*.jpg");
                    allnamesPSEXN = Directory.GetFiles(PSEXN, "*.jpg");
                    countPSEXO = Directory.GetFiles(PSEXO, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countPSEXN = Directory.GetFiles(PSEXN, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                   // string[] remain11= new string[countPSEXO];
                    if (countPSEXO == 0)
                    {
                        MessageBox.Show("No backup were found for photoshop express");
                    }
                    else
                    {
                        if (countPSEXN == 0)
                        {
                            foreach (string log in allnamesPSEXO)
                            {
                                remain11 = allnamesPSEXO;
                            }
                            num11 = countPSEXO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamesPSEXO)
                            {
                                if (!(File.Exists(PSEXN + Path.GetFileName(name))))             //sab kuch banane ke baad yaha pe problem 25/08/2020
                                {
                                    //remain11[num11] = (name);
                                    // num11 += 1;
                                    remain11 = allnamesPSEXO;
                                    Link += 1;
                                }
                            }
                        }
                    }
                }

                if (Directory.Exists(PSMIXO))
                {
                    Directory.CreateDirectory(PSMIXN);
                    allnamesPSMIXO = Directory.GetFiles(PSMIXO, "*.jpg");
                    allnamesPSMIXN = Directory.GetFiles(PSMIXN, "*.jpg");
                    countPSMIXO = Directory.GetFiles(PSMIXO, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countPSMIXN = Directory.GetFiles(PSMIXN, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countPSMIXO == 0)
                    {
                        MessageBox.Show("No backup were found for photoshop mix");
                    }
                    else
                    {
                        if (countPSMIXN == 0)
                        {
                            foreach (string log in allnamesPSMIXO)
                            {
                                remain12 = allnamesPSMIXO;
                            }
                            num12 = countPSMIXO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamesPSMIXO)
                            {
                                if (!(File.Exists(PSMIXN + Path.GetFileName(name))))
                                {
                                    //remain12[num12] = (name);
                                    //num12 += 1;
                                    remain12 = allnamesPSMIXO;
                                    Link += 1;
                                }
                            }

                        }
                    }
                }

                if (Directory.Exists(PSFIXO))
                {
                    Directory.CreateDirectory(PSFIXN);
                    allnamesPSFIXO = Directory.GetFiles(PSFIXO, "*.jpg");
                    allnamesPSFIXN = Directory.GetFiles(PSFIXN, "*.jpg");
                    countPSFIXO = Directory.GetFiles(PSFIXO, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countPSFIXN = Directory.GetFiles(PSFIXN, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countPSFIXO == 0)
                    {
                        MessageBox.Show("No backup were found for photoshp fix");
                    }
                    else
                    {
                        if (countPSFIXN == 0)
                        {
                            foreach (string log in allnamesPSFIXO)
                            {
                                remain13 = allnamesPSFIXO;
                            }
                            num13 = countPSFIXO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamesPSFIXO)
                            {
                                if (!(File.Exists(PSFIXN + Path.GetFileName(name))))
                                {
                                    //remain13[num13] = (name);
                                    //num13 += 1;
                                    remain13 = allnamesPSFIXO;
                                    Link += 1;
                                }
                            }

                        }
                    }
                }

                if (Directory.Exists(CCO))
                {
                    Directory.CreateDirectory(CCN);
                    allnamesCCO = Directory.GetFiles(CCO, "*.jpg");
                    allnamesCCN = Directory.GetFiles(CCN, "*.jpg");
                    countCCO = Directory.GetFiles(CCO, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countCCN = Directory.GetFiles(CCN, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countCCO == 0)
                    {
                        MessageBox.Show("No backup were found for candycam");
                    }
                    else
                    {
                        if (countCCN == 0)
                        {
                            foreach (string log in allnamesCCO)
                            {
                                remain14 = allnamesCCO;
                            }
                            num14 = countCCO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamesCCO)
                            {
                                if (!(File.Exists(CCN + Path.GetFileName(name))))
                                {
                                    //remain14[num14] = (name);
                                    //num14 += 1;
                                    remain14 = allnamesCCO;
                                    Link += 1;
                                }
                            }

                        }
                    }
                }

                if (Directory.Exists(YCO))
                {
                    Directory.CreateDirectory(YCN);
                    allnamesYCO = Directory.GetFiles(YCO, "*.jpg");
                    allnamesYCN = Directory.GetFiles(YCN, "*.jpg");
                    countYCO = Directory.GetFiles(YCO, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countYCN = Directory.GetFiles(YCN, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countYCO == 0)
                    {
                        MessageBox.Show("No backup were found for youcam ");
                    }
                    else
                    {
                        if (countYCN == 0)
                        {
                            foreach (string log in allnamesYCO)
                            {
                                remain15 = allnamesYCO;
                            }
                            num15 = countYCO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamesYCO)
                            {
                                if (!(File.Exists(YCN + Path.GetFileName(name))))
                                {
                                    //remain15[num15] = (name);
                                    //num15 += 1;
                                    remain15 = allnamesYCO;
                                    Link += 1;
                                }
                            }

                        }
                    }
                }

                if (Directory.Exists(B612O))
                {
                    Directory.CreateDirectory(B612N);
                    allnamesB612O = Directory.GetFiles(B612O, "*.jpg");
                    allnamesB612N = Directory.GetFiles(B612N, "*.jpg");
                    countB612O = Directory.GetFiles(B612O, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countB612N = Directory.GetFiles(B612N, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countB612O == 0)
                    {
                        MessageBox.Show("No backup were found for B612");
                    }
                    else
                    {
                        if (countB612N == 0)
                        {
                            foreach (string log in allnamesB612O)
                            {
                                remain16 = allnamesB612O;
                            }
                            num16 = countB612O;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamesB612O)
                            {
                                if (!(File.Exists(B612N + Path.GetFileName(name))))
                                {
                                    //remain16[num16] = (name);
                                    //num16 += 1;
                                    remain16 = allnamesB612O;
                                    Link += 1;
                                }
                            }

                        }
                    }
                }

                if (Directory.Exists(PAO))
                {
                    Directory.CreateDirectory(PAN);
                    allnamesPAO = Directory.GetFiles(PAO, "*.jpg");
                    allnamesPAN = Directory.GetFiles(PAN, "*.jpg");
                    countPAO = Directory.GetFiles(PAO, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countPAN = Directory.GetFiles(PAN, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countPAO == 0)
                    {
                        MessageBox.Show("No backup were found for picsart");
                    }
                    else
                    {
                        if (countPAN == 0)
                        {
                            foreach (string log in allnamesPAO)
                            {
                                remain17 = allnamesPAO;
                            }
                            num17 = countPAO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamesPAO)
                            {
                                if (!(File.Exists(PAN + Path.GetFileName(name))))
                                {
                                    //remain17[num17] = (name);
                                    //num17 += 1;
                                    remain17 = allnamesPAO;
                                    Link += 1;
                                }
                            }

                        }
                    }
                }

                if (Directory.Exists(PLO))
                {
                    Directory.CreateDirectory(PLN);
                    allnamesPLO = Directory.GetFiles(PLO, "*.jpg");
                    allnamesPLN = Directory.GetFiles(PLN, "*.jpg");
                    countPLO = Directory.GetFiles(PLO, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countPLN = Directory.GetFiles(PLN, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countPLO == 0)
                    {
                        MessageBox.Show("No backup were found for photolab");
                    }
                    else
                    {
                        if (countPLN == 0)
                        {
                            foreach (string log in allnamesPLO)
                            {
                                remain18 = allnamesPLO;
                            }
                            num18 = countPLO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamesPLO)
                            {
                                if (!(File.Exists(PLN + Path.GetFileName(name))))
                                {
                                    //remain18[num18] = (name);
                                    //num18 += 1;
                                    remain18 = allnamesPLO;
                                    Link += 1;
                                }
                            }

                        }
                    }
                }

                if (Directory.Exists(PolishO))
                {
                    Directory.CreateDirectory(PolishN);
                    allnamesPolishO = Directory.GetFiles(PolishO, "*.jpg");
                    allnamesPolishN = Directory.GetFiles(PolishN, "*.jpg");
                    countPolishO = Directory.GetFiles(PolishO, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countPolishN = Directory.GetFiles(PolishN, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countPolishO == 0)
                    {
                        MessageBox.Show("No backup were found for polish");
                    }
                    else
                    {
                        if (countPolishN == 0)
                        {
                            foreach (string log in allnamesPolishO)
                            {
                                remain19 = allnamesPolishO;
                            }
                            num19 = countPolishO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamesPolishO)
                            {
                                if (!(File.Exists(PolishN + Path.GetFileName(name))))
                                {
                                    //remain19[num19] = (name);
                                    //num19 += 1;
                                    remain19 = allnamesPolishO;
                                    Link += 1;
                                }
                            }

                        }
                    }
                }

                if (Directory.Exists(instaSQO))
                {
                    Directory.CreateDirectory(instaSQN);
                    allnamesinstaSQO = Directory.GetFiles(instaSQO, "*.jpg");
                    allnamesinstaSQN = Directory.GetFiles(instaSQN, "*.jpg");
                    countinstaSQO = Directory.GetFiles(instaSQO, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countinstaSQN = Directory.GetFiles(instaSQN, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countinstaSQO == 0)
                    {
                        MessageBox.Show("No backup were found for insta square");
                    }
                    else
                    {
                        if (countinstaSQN == 0)
                        {
                            foreach (string log in allnamesinstaSQO)
                            {
                                remain20 = allnamesinstaSQO;
                            }
                            num20 = countinstaSQO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamesinstaSQO)
                            {
                                if (!(File.Exists(instaSQN + Path.GetFileName(name))))
                                {
                                    //remain20[num20] = (name);
                                    //num20 += 1;
                                    remain20 = allnamesinstaSQO;
                                    Link += 1;
                                }
                            }

                        }
                    }
                }

                if (Directory.Exists(retricaO))
                {
                    Directory.CreateDirectory(retricaN);
                    allnamesretricaO = Directory.GetFiles(retricaO, "*.jpg");
                    allnamesretricaN = Directory.GetFiles(retricaN, "*.jpg");
                    countretricaO = Directory.GetFiles(retricaO, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countretricaN = Directory.GetFiles(retricaN, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countretricaO == 0)
                    {
                        MessageBox.Show("No backup were found for retrica");
                    }
                    else
                    {
                        if (countretricaN == 0)
                        {
                            foreach (string log in allnamesretricaO)
                            {
                                remain21 = allnamesretricaO;
                            }
                            num21 = countretricaO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamesretricaO)
                            {
                                if (!(File.Exists(retricaN + Path.GetFileName(name))))
                                {
                                    //remain21[num21] = (name);
                                    //num21 += 1;
                                    remain21 = allnamesretricaO;
                                    Link += 1;
                                }
                            }

                        }
                    }
                }

                if (Directory.Exists(SSeedO))
                {
                    Directory.CreateDirectory(SSeedN);
                    allnamesSSeedO = Directory.GetFiles(SSeedO, "*.jpg");
                    allnamesSSeedN = Directory.GetFiles(SSeedN, "*.jpg");
                    countSSeedO = Directory.GetFiles(SSeedO, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    countSSeedN = Directory.GetFiles(SSeedN, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
                    if (countSSeedO == 0)
                    {
                        MessageBox.Show("No backup were found for snapseed");
                    }
                    else
                    {
                        if (countSSeedN == 0)
                        {
                            foreach (string log in allnamesSSeedO)
                            {
                                remain22 = allnamesSSeedO;
                            }
                            num22 = countSSeedO;

                            Link += 1;
                        }

                        else
                        {
                            foreach (string name in allnamesSSeedO)
                            {
                                if (!(File.Exists(SSeedN + Path.GetFileName(name))))
                                {
                                    //remain22[num22] = (name);
                                    //num22 += 1;
                                    remain22 = allnamesSSeedO;
                                    Link += 1;
                                }
                            }

                        }
                    }
                }


                if (Link > 0)
                {
                    MessageBox.Show("Backup available");
                }
                else
                {
                    MessageBox.Show("No backup were found");
                }
            }
            else
            {
                MessageBox.Show("No such directory were found","Error");
            }

            
           
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (Link > 0)
            {
                if (num1 > 0)
                {

                    foreach (string name in remain1)
                    {
                        if (!(File.Exists(cameraN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, cameraN + (Path.GetFileName(name)));// change from name to path
                        }
                    }
                    // MessageBox.Show("      Succesfully Uploaded    ");
                    num1 = 0;

                    // Directory.Delete(drive + @"\BUCKET");
                }
                if (num2 > 0)
                {

                    foreach (string name in remain2)
                    {
                        if (!(File.Exists(bluetoothN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, bluetoothN + (Path.GetFileName(name)));// change from name to path
                        }
                    }
                    
                    num2 = 0;
                }
                if (num3 > 0)
                {

                    foreach (string name in remain3)
                    {
                        if (!(File.Exists(SSN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, SSN + (Path.GetFileName(name)));// change from name to path
                        }
                    }

                    num3 = 0;
                }
                if (num4 > 0)
                {

                    foreach (string name in remain4)
                    {
                        if (!(File.Exists(instaN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, instaN + (Path.GetFileName(name)));// change from name to path
                        }
                    }

                    num4 = 0;
                }
                if (num5 > 0)
                {

                    foreach (string name in remain5)
                    {
                        if (!(File.Exists(instaLYN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, instaLYN + (Path.GetFileName(name)));// change from name to path
                        }
                    }

                    num5 = 0;
                }
                if (num6 > 0)
                {

                    foreach (string name in remain6)
                    {
                        if (!(File.Exists(fbN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, fbN + (Path.GetFileName(name)));// change from name to path
                        }
                    }

                    num6 = 0;
                }
                if (num7 > 0)
                {

                    foreach (string name in remain7)
                    {
                        if (!(File.Exists(fbMN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, fbMN + (Path.GetFileName(name)));// change from name to path
                        }
                    }

                    num7 = 0;
                }
                if (num8 > 0)
                {

                    foreach (string name in remain8)
                    {
                        if (!(File.Exists(whatsN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, whatsN + (Path.GetFileName(name)));// change from name to path
                        }
                    }

                    num8 = 0;
                }
                if (num9 > 0)
                {

                    foreach (string name in remain9)
                    {
                        if (!(File.Exists(snapN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, snapN + (Path.GetFileName(name)));// change from name to path
                        }
                    }

                    num9 = 0;
                }
                if (num10 > 0)
                {

                    foreach (string name in remain10)
                    {
                        if (!(File.Exists(LRN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, LRN + (Path.GetFileName(name)));// change from name to path
                        }
                    }

                    num10 = 0;
                }
                if (num11 > 0)
                {

                    foreach (string name in remain11)
                    {
                        if (!(File.Exists(PSEXN + Path.GetFileName(name))))             
                        {
                            System.IO.File.Copy(name, PSEXN + (Path.GetFileName(name)));// change from name to path
                        }
                    }

                    num11 = 0;
                }
                if (num12 > 0)
                {

                    foreach (string name in remain12)
                    {
                        if (!(File.Exists(PSMIXN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, PSMIXN + (Path.GetFileName(name)));// change from name to path
                        }
                    }

                    num12 = 0;
                }
                if (num13 > 0)

                {

                    foreach (string name in remain13)
                    {
                        if (!(File.Exists(PSFIXN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, PSFIXN + (Path.GetFileName(name)));// change from name to path
                        }
                    }

                    num13 = 0;
                }
                if (num14 > 0)
                {

                    foreach (string name in remain14)
                    {
                        if (!(File.Exists(CCN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, CCN + (Path.GetFileName(name)));// change from name to path
                        }
                    }

                    num14 = 0;
                }
                if (num15 > 0)
                {

                    foreach (string name in remain15)
                    {
                        if (!(File.Exists(YCN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, YCN + (Path.GetFileName(name)));// change from name to path
                        }
                    }

                    num15 = 0;
                }
                if (num16 > 0)
                {

                    foreach (string name in remain16)
                    {
                        System.IO.File.Copy(name, B612N + (Path.GetFileName(name)));// change from name to path
                    }

                    num16 = 0;
                }
                if (num17 > 0)
                {

                    foreach (string name in remain17)
                    {
                        if (!(File.Exists(PAN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, PAN + (Path.GetFileName(name)));// change from name to path
                        }
                    }

                    num17 = 0;
                }
                if (num18 > 0)
                {

                    foreach (string name in remain18)
                    {
                        if (!(File.Exists(PLN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, PLN + (Path.GetFileName(name)));// change from name to path
                        }
                    }

                    num18 = 0;
                }
                if (num19 > 0)
                {

                    foreach (string name in remain19)
                    {
                        if (!(File.Exists(PolishN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, PolishN + (Path.GetFileName(name)));// change from name to path
                        }
                    }

                    num19 = 0;
                }
                if (num20 > 0)
                {

                    foreach (string name in remain20)
                    {
                        if (!(File.Exists(instaSQN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, instaSQN + (Path.GetFileName(name)));// change from name to path
                        }
                    }

                    num20 = 0;
                }
                if (num21 > 0)
                {

                    foreach (string name in remain21)
                    {
                        if (!(File.Exists(retricaN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, retricaN + (Path.GetFileName(name)));// change from name to path
                        }
                    }

                    num21 = 0;
                }
                if (num22 > 0)
                {

                    foreach (string name in remain22)
                    {
                        if (!(File.Exists(SSeedN + Path.GetFileName(name))))
                        {
                            System.IO.File.Copy(name, SSeedN + (Path.GetFileName(name)));// change from name to path
                        }
                    }

                    num22 = 0;
                }
                MessageBox.Show("      Succesfully Uploaded    ");
              //  Directory.Delete(drive + @"\BUCKET",true);                        //bucket not emoty
            }

        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
                                                                                       // FROM HERE WE MERGING THE SECOND APP
        

        private void LocationLoading()
        {
            LoadImagesFromFolder();
            //yaha function call karna hai

            ImageList images = new ImageList();
            images.ImageSize = new Size(80, 80);
            images.ColorDepth = ColorDepth.Depth32Bit;
                                                                                                           //in thees loops we have to sort
            foreach (var image in loadedImages)
            { 
                images.Images.Add(image);
            }

            imageList.LargeImageList = images;


            for (int itemIndex = 1; itemIndex <= loadedImages.Count; itemIndex++)
            {
                imageList.Items.Add(new ListViewItem("", itemIndex - 1));
            }
        }

        private void LoadImagesFromFolder()
        {
            allnamesCO = Directory.GetFiles(optlink, "*.jpg");
            countCO = Directory.GetFiles(optlink, "*.jpg"/*, SearchOption.AllDirectories*/).Length;
            loadedImages = new List<Image>();
            //here is the change done
            foreach (string name in allnamesCO)//while (index < 5)
            {
                String templocation = name;
                var tempimage = Image.FromFile(templocation);
                loadedImages.Add(tempimage);

            }
            backgroundWorker1.RunWorkerAsync();
            progress.Show();
        }

        private void imageList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (imageList.SelectedIndices.Count > 0)
            {
                var selectedindex = imageList.SelectedIndices[0];
                Image selectedimg = loadedImages[selectedindex];
                selectedImage.Image = selectedimg;
            }
        }
        private void navnext_Click_1(object sender, EventArgs e)
        {
            if (optlink != "0")
                {
                if (selectedimageindex < (loadedImages.Count - 1))
                {
                    selectedimageindex += 1;
                    Image selectedimg = loadedImages[selectedimageindex];
                    selectedImage.Image = selectedimg;
                    SelectTheClickedItem(imageList, selectedimageindex);
                }
            }
        }
        private void navback_Click_1(object sender, EventArgs e)
        {
            if (selectedimageindex > 0)
            {
                selectedimageindex -= 1;
                Image selectedimg = loadedImages[selectedimageindex];
                selectedImage.Image = selectedimg;
                SelectTheClickedItem(imageList, selectedimageindex);
            }
        }

        private void SelectTheClickedItem(ListView list, int index)
        {
            for (int item = 0; item < list.Items.Count; item++)
            {
                if (item == index)
                {
                    list.Items[item].Selected = true;
                }
                else
                {
                    list.Items[item].Selected = false;
                }
            }
        }

        private void camera_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();

            if (Directory.Exists(cameraN))                                             // call by folder
            {
                optlink = cameraN;

                LocationLoading();
            }
        }
        private void bluetooth_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(bluetoothN))                                             // call by folder
            {
                optlink = bluetoothN;

                LocationLoading();
            }
        }

        private void SS_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(SSN))
            {
                optlink = SSN;

                LocationLoading();
            }
 
        }

        private void insta_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(instaN))
            {
                optlink = instaN;

                LocationLoading();
            }
 
        }

        private void snap_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(snapN))
            {
                optlink = snapN;

                LocationLoading();
            }
 
        }

        private void instaLY_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(instaLYN))
            {
                optlink = instaLYN;

                LocationLoading();
            }
 
        }

        private void fb_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(fbN))
            {
                optlink = fbN;

                LocationLoading();
            }
 
        }

        private void whats_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(whatsN))
            {
                optlink = whatsN;

                LocationLoading();
            }
 
        }
        private void psx_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(PSEXN))
            {
                optlink = PSEXN;

                LocationLoading();
            }
 
        }
        

        private void LR_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(LRN))
            {
                optlink = LRN;

                LocationLoading();
            }
 
        }

        private void psfix_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(PSFIXN))
            {
                optlink = PSFIXN;

                LocationLoading();
            }
 
        }

        private void psmix_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(PSMIXN))
            {
                optlink = PSMIXN;

                LocationLoading();
            }
 
        }

        private void CC_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(CCN))
            {
                optlink = CCN;

                LocationLoading();
            }
 
        }

        private void YC_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(YCN))
            {
                optlink = YCN;

                LocationLoading();
            }
 
        }

        private void B612_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(B612N))
            {
                optlink = B612N;

                LocationLoading();
            }
 
        }

        private void PA_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(PAN))
            {
                optlink = PAN;

                LocationLoading();
            }
 
        }

        private void PL_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(PLN))
            {
                optlink = PLN;

                LocationLoading();
            }
 
        }

        private void Polish_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(PolishN))
            {
                optlink = PolishN;

                LocationLoading();
            }
 
        }
        private void SSeed_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(SSeedN))
            {
                optlink = SSeedN;

                LocationLoading();
            }
 
        }

        private void instaSQ_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(instaSQN))
            {
                optlink = instaSQN;

                LocationLoading();
            }
 
        }
        private void retrica_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(retricaN))
            {
                optlink = retricaN;

                LocationLoading();
            }
 
        }

        private void fbM_Click(object sender, EventArgs e)
        {
            gre.Visible = true;

            imageList.Items.Clear();
            if (Directory.Exists(fbMN))
            {
                optlink = fbMN;

                LocationLoading();
            }
 
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void selectedImage_Click(object sender, EventArgs e)
        {
            
        }

        private void imageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(10);
                backgroundWorker1.WorkerReportsProgress = true;
                backgroundWorker1.ReportProgress(i);
            }     
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progress.Value = e.ProgressPercentage;
        }
    }
}