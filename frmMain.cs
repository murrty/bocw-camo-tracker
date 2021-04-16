using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColdWarCamo {
    public partial class frmMain : Form {
        private readonly string DefaultCamo =  "00000000000000000000000000000000000";
        private readonly string CompleteCamo = "11111111111111111111111111111111111";

        private WeaponClass SelectedClass = WeaponClass.None;
        private int SelectedWeapon = -1;

        private bool WeaponModified = false;
        private bool ControlsHidden = true;
        private bool LoadingCamos = false;
        private bool SwitchingClass = false;

        public frmMain() {
            InitializeComponent();
            lvMultiplayerCamo.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvZombieCamo.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        [System.Diagnostics.DebuggerStepThrough]
        private void SetLocations() {
            radioButton2.Location = new Point(radioButton1.Location.X + radioButton1.Size.Width + 4, 48);
            radioButton3.Location = new Point(radioButton2.Location.X + radioButton2.Size.Width + 4, 48);
            radioButton4.Location = new Point(radioButton3.Location.X + radioButton3.Size.Width + 4, 48);
            radioButton5.Location = new Point(radioButton4.Location.X + radioButton4.Size.Width + 4, 48);
            radioButton6.Location = new Point(radioButton5.Location.X + radioButton5.Size.Width + 4, 48);
            radioButton7.Location = new Point(radioButton6.Location.X + radioButton6.Size.Width + 4, 48);
        }
        [System.Diagnostics.DebuggerStepThrough]
        private void SetCamoLevels(int Type) {
            switch (Type) {
                default:
                    lvMultiplayerCamo.Groups[4].Header = "Geometric (Lv. 20)";
                    lvMultiplayerCamo.Groups[5].Header = "Flora (Lv. 30)";
                    lvMultiplayerCamo.Groups[6].Header = "Science (Lv. 40)";
                    lvMultiplayerCamo.Groups[7].Header = "Psychedelic (Lv. 50)";
                    lvZombieCamo.Groups[4].Header = "Vintage (Lv. 20)";
                    lvZombieCamo.Groups[5].Header = "Fauna (Lv. 30)";
                    lvZombieCamo.Groups[6].Header = "Topography (Lv. 40)";
                    lvZombieCamo.Groups[7].Header = "Infection (Lv. 50)";

                    lbTier3MP.Text = "Geometric (Lv. 20)";
                    lbTier4MP.Text = "Flora (Lv. 30)";
                    lbTier5MP.Text = "Science (Lv. 40)";
                    lbTier6MP.Text = "Psychedelic (Lv. 50)";
                    lbTier3ZM.Text = "Vintage (Lv. 20)";
                    lbTier4ZM.Text = "Fauna (Lv. 30)";
                    lbTier5ZM.Text = "Topography (Lv. 40)";
                    lbTier6ZM.Text = "Infection (Lv. 50)";
                    break;
                case 1:
                    lvMultiplayerCamo.Groups[4].Header = "Geometric (Lv. 15)";
                    lvMultiplayerCamo.Groups[5].Header = "Flora (Lv. 20)";
                    lvMultiplayerCamo.Groups[6].Header = "Science (Lv. 25)";
                    lvMultiplayerCamo.Groups[7].Header = "Psychedelic (Lv. 30)";
                    lvZombieCamo.Groups[4].Header = "Vintage (Lv. 15)";
                    lvZombieCamo.Groups[5].Header = "Fauna (Lv. 20)";
                    lvZombieCamo.Groups[6].Header = "Topography (Lv. 25)";
                    lvZombieCamo.Groups[7].Header = "Infection (Lv. 30)";

                    lbTier3MP.Text = "Geometric (Lv. 15)";
                    lbTier4MP.Text = "Flora (Lv. 20)";
                    lbTier5MP.Text = "Science (Lv. 25)";
                    lbTier6MP.Text = "Psychedelic (Lv. 30)";
                    lbTier3ZM.Text = "Vintage (Lv. 15)";
                    lbTier4ZM.Text = "Fauna (Lv. 20)";
                    lbTier5ZM.Text = "Topography (Lv. 25)";
                    lbTier6ZM.Text = "Infection (Lv. 30)";
                    break;
            }
        }
        [System.Diagnostics.DebuggerStepThrough]
        private void CheckPreviousCamos(ListView lv, int ItemIndex) {
            if (!LoadingCamos && !SwitchingClass) {
                switch (ItemIndex) {
                    case 1:
                        lv.Items[0].Checked = true;
                        break;
                    case 2:
                        lv.Items[1].Checked = true;
                        break;
                    case 3:
                        lv.Items[2].Checked = true;
                        break;
                    case 4:
                        lv.Items[3].Checked = true;
                        break;

                    case 6:
                        lv.Items[5].Checked = true;
                        break;
                    case 7:
                        lv.Items[6].Checked = true;
                        break;
                    case 8:
                        lv.Items[7].Checked = true;
                        break;
                    case 9:
                        lv.Items[8].Checked = true;
                        break;

                    case 11:
                        lv.Items[10].Checked = true;
                        break;
                    case 12:
                        lv.Items[11].Checked = true;
                        break;
                    case 13:
                        lv.Items[12].Checked = true;
                        break;
                    case 14:
                        lv.Items[13].Checked = true;
                        break;

                    case 16:
                        lv.Items[15].Checked = true;
                        break;
                    case 17:
                        lv.Items[16].Checked = true;
                        break;
                    case 18:
                        lv.Items[17].Checked = true;
                        break;
                    case 19:
                        lv.Items[18].Checked = true;
                        break;

                    case 21:
                        lv.Items[20].Checked = true;
                        break;
                    case 22:
                        lv.Items[21].Checked = true;
                        break;
                    case 23:
                        lv.Items[22].Checked = true;
                        break;
                    case 24:
                        lv.Items[23].Checked = true;
                        break;

                    case 26:
                        lv.Items[25].Checked = true;
                        break;
                    case 27:
                        lv.Items[26].Checked = true;
                        break;
                    case 28:
                        lv.Items[27].Checked = true;
                        break;
                    case 29:
                        lv.Items[28].Checked = true;
                        break;

                    case 31:
                        lv.Items[30].Checked = true;
                        break;
                    case 32:
                        lv.Items[31].Checked = true;
                        break;
                    case 33:
                        lv.Items[32].Checked = true;
                        break;
                    case 34:
                        lv.Items[33].Checked = true;
                        break;

                    //case 36:
                    //    lv.Items[35].Checked = true;
                    //    break;
                    //case 37:
                    //    lv.Items[36].Checked = true;
                    //    break;
                }
            }
        }
        [System.Diagnostics.DebuggerStepThrough]
        private void UncheckPostCamos(ListView lv, int ItemIndex) {
            if (!LoadingCamos && !SwitchingClass) {
                switch (ItemIndex) {
                    case 0:
                        lv.Items[1].Checked = false;
                        break;
                    case 1:
                        lv.Items[2].Checked = false;
                        break;
                    case 2:
                        lv.Items[3].Checked = false;
                        break;
                    case 3:
                        lv.Items[4].Checked = false;
                        break;

                    case 5:
                        lv.Items[6].Checked = false;
                        break;
                    case 6:
                        lv.Items[7].Checked = false;
                        break;
                    case 7:
                        lv.Items[8].Checked = false;
                        break;
                    case 8:
                        lv.Items[9].Checked = false;
                        break;

                    case 10:
                        lv.Items[11].Checked = false;
                        break;
                    case 11:
                        lv.Items[12].Checked = false;
                        break;
                    case 12:
                        lv.Items[13].Checked = false;
                        break;
                    case 13:
                        lv.Items[14].Checked = false;
                        break;

                    case 15:
                        lv.Items[16].Checked = false;
                        break;
                    case 16:
                        lv.Items[17].Checked = false;
                        break;
                    case 17:
                        lv.Items[18].Checked = false;
                        break;
                    case 18:
                        lv.Items[19].Checked = false;
                        break;

                    case 20:
                        lv.Items[21].Checked = false;
                        break;
                    case 21:
                        lv.Items[22].Checked = false;
                        break;
                    case 22:
                        lv.Items[23].Checked = false;
                        break;
                    case 23:
                        lv.Items[24].Checked = false;
                        break;

                    case 25:
                        lv.Items[26].Checked = false;
                        break;
                    case 26:
                        lv.Items[27].Checked = false;
                        break;
                    case 27:
                        lv.Items[28].Checked = false;
                        break;
                    case 28:
                        lv.Items[29].Checked = false;
                        break;

                    case 30:
                        lv.Items[31].Checked = false;
                        break;
                    case 31:
                        lv.Items[32].Checked = false;
                        break;
                    case 32:
                        lv.Items[33].Checked = false;
                        break;
                    case 33:
                        lv.Items[34].Checked = false;
                        break;

                    //case 35:
                    //    lv.Items[36].Checked = false;
                    //    break;
                    //case 36:
                    //    lv.Items[37].Checked = false;
                    //    break;
                }
            }
        }
        [System.Diagnostics.DebuggerStepThrough]
        private void SetControlsVisibility(bool Visible) {
            lbIsGold.Visible = Visible;
            lbIsGoldenViper.Visible = Visible;
            lbHowToUnlock.Visible = Visible;
            gbMP.Visible = Visible;
            gbZM.Visible = Visible;

            lbTier0MP.Visible = Visible;
            txtTier0MP.Visible = Visible;
            lbTier1MP.Visible = Visible;
            txtTier1MP.Visible = Visible;
            lbTier2MP.Visible = Visible;
            txtTier2MP.Visible = Visible;
            lbTier3MP.Visible = Visible;
            txtTier3MP.Visible = Visible;
            lbTier4MP.Visible = Visible;
            txtTier4MP.Visible = Visible;
            lbTier5MP.Visible = Visible;
            txtTier5MP.Visible = Visible;
            lbTier6MP.Visible = Visible;
            txtTier6MP.Visible = Visible;

            lbTier0ZM.Visible = Visible;
            txtTier0ZM.Visible = Visible;
            lbTier1ZM.Visible = Visible;
            txtTier1ZM.Visible = Visible;
            lbTier2ZM.Visible = Visible;
            txtTier2ZM.Visible = Visible;
            lbTier3ZM.Visible = Visible;
            txtTier3ZM.Visible = Visible;
            lbTier4ZM.Visible = Visible;
            txtTier4ZM.Visible = Visible;
            lbTier5ZM.Visible = Visible;
            txtTier5ZM.Visible = Visible;
            lbTier6ZM.Visible = Visible;
            txtTier6ZM.Visible = Visible;

            lbWeaponLevel.Visible = Visible;
            txtWeaponLevel.Visible = Visible;
            
            ControlsHidden = !Visible;
        }
        [System.Diagnostics.DebuggerStepThrough]
        private string GetHint(int Camo, int Type) {
            #region Zombies
            if (Type == 1) {
                if (Camo > 29) {
                    switch (Camo) {
                        case 30:
                            return "Get 20 or more kills without getting hit 2 times";
                        case 31:
                            return "Get 20 or more kills without getting hit 4 times";
                        case 32:
                            return "Get 20 or more kills without getting hit 6 times";
                        case 33:
                            return "Get 20 or more kills without getting hit 8 times";
                        case 34:
                            return "Get 20 or more kills without getting hit 10 times";
                        case 35:
                            return "Obtain all camos for a gun";
                        case 36:
                            return "Obtain all Golden Viper camos for a weapon type";
                        case 37:
                            return "Obtain all Plague Diamond camos for all weapons";
                    }
                }

                if (rbAR.Checked || rbSMG.Checked || rbTR.Checked || rbLMG.Checked || rbSR.Checked || rbPS.Checked || rbSG.Checked) {
                    switch (Camo) {
                        case 0:
                            return "Get 50 kills";
                        case 1:
                            return "Get 250 kills";
                        case 2:
                            return "Get 750 kills";
                        case 3:
                            return "Get 1,500 kills";
                        case 4:
                            return "Get 2,500 kills";
                        case 5:
                            return "Get 50 critical kills";
                        case 6:
                            return "Get 250 critical kills";
                        case 7:
                            return "Get 750 critical kills";
                        case 8:
                            return "Get 1,500 critical kills";
                        case 9:
                            return "Get 2,500 critical kills";
                        case 10:
                            return "Get 50 kills while Pack-a-Punched";
                        case 11:
                            return "Get 250 kills while Pack-a-Punched";
                        case 12:
                            return "Get 750 kills while Pack-a-Punched";
                        case 13:
                            return "Get 1,500 kills while Pack-a-Punched";
                        case 14:
                            return "Get 2,500 kills while Pack-a-Punched";
                        case 15:
                            return "Get 3 elite eliminations";
                        case 16:
                            return "Get 6 elite eliminations";
                        case 17:
                            return "Get 9 elite eliminations";
                        case 18:
                            return "Get 12 elite eliminations";
                        case 19:
                            return "Get 15 elite eliminations";
                        case 20:
                            return "Get 10 kills rapidly 2 times";
                        case 21:
                            return "Get 10 kills rapidly 4 times";
                        case 22:
                            return "Get 10 kills rapidly 6 times";
                        case 23:
                            return "Get 10 kills rapidly 8 times";
                        case 24:
                            return "Get 10 kills rapidly 10 times";
                        case 25:
                            return "Get 3 critical kills rapidly 5 times";
                        case 26:
                            return "Get 3 critical kills rapidly 10 times";
                        case 27:
                            return "Get 3 critical kills rapidly 15 times";
                        case 28:
                            return "Get 3 critical kills rapidly 20 times";
                        case 29:
                            return "Get 3 critical kills rapidly 25 times";
                    }
                }
                else if (rbRL.Checked || rbSP.Checked && radioButton2.Checked) {
                    switch (Camo) {
                        case 0:
                            return "Get 50 kills";
                        case 1:
                            return "Get 250 kills";
                        case 2:
                            return "Get 500 kills";
                        case 3:
                            return "Get 1,000 kills";
                        case 4:
                            return "Get 1,500 kills";
                        case 5:
                            return "Get 2 rapid kills 10 times";
                        case 6:
                            return "Get 2 rapid kills 20 times";
                        case 7:
                            return "Get 2 rapid kills 30 times";
                        case 8:
                            return "Get 2 rapid kills 40 times";
                        case 9:
                            return "Get 2 rapid kills 50 times";
                        case 10:
                            return "Get 5 or more kills with a single shot 10 times";
                        case 11:
                            return "Get 5 or more kills with a single shot 20 times";
                        case 12:
                            return "Get 5 or more kills with a single shot 30 times";
                        case 13:
                            return "Get 5 or more kills with a single shot 40 times";
                        case 14:
                            return "Get 5 or more kills with a single shot 50 times";
                        case 15:
                            return "Get 50 kills while Pack-a-Punched";
                        case 16:
                            return "Get 250 kills while Pack-a-Punched";
                        case 17:
                            return "Get 500 kills while Pack-a-Punched";
                        case 18:
                            return "Get 1,000 kills while Pack-a-Punched";
                        case 19:
                            return "Get 1,500 kills while Pack-a-Punched";
                        case 20:
                            return "Get 2 elite eliminations";
                        case 21:
                            return "Get 4 elite eliminations";
                        case 22:
                            return "Get 6 elite eliminations";
                        case 23:
                            return "Get 8 elite eliminations";
                        case 24:
                            return "Get 10 elite eliminations";
                        case 25:
                            return "Get 10 kills rapidly 2 times";
                        case 26:
                            return "Get 10 kills rapidly 4 times";
                        case 27:
                            return "Get 10 kills rapidly 6 times";
                        case 28:
                            return "Get 10 kills rapidly 8 times";
                        case 29:
                            return "Get 10 kills rapidly 10 times";
                    }
                }
                else if (rbSP.Checked && radioButton1.Checked || radioButton4.Checked) {
                    switch (Camo) {
                        case 0:
                            return "Get 50 kills";
                        case 1:
                            return "Get 125 kills";
                        case 2:
                            return "Get 250 kills";
                        case 3:
                            return "Get 500 kills";
                        case 4:
                            return "Get 750 kills";
                        case 5:
                            return "Get 10 kills against enemies stunned by Stun Grenades, Monkey Bombs, or Decoys";
                        case 6:
                            return "Get 20 kills against enemies stunned by Stun Grenades, Monkey Bombs, or Decoys";
                        case 7:
                            return "Get 30 kills against enemies stunned by Stun Grenades, Monkey Bombs, or Decoys";
                        case 8:
                            return "Get 40 kills against enemies stunned by Stun Grenades, Monkey Bombs, or Decoys";
                        case 9:
                            return "Get 50 kills against enemies stunned by Stun Grenades, Monkey Bombs, or Decoys";
                        case 10:
                            return "Get 50 kills while Pack-a-Punched";
                        case 11:
                            return "Get 125 kills while Pack-a-Punched";
                        case 12:
                            return "Get 250 kills while Pack-a-Punched";
                        case 13:
                            return "Get 500 kills while Pack-a-Punched";
                        case 14:
                            return "Get 750 kills while Pack-a-Punched";
                        case 15:
                            return "Get 3 kills against enemies affected by Frost Blast, Ring of Fire, or while hidden with Aether Shroud";
                        case 16:
                            return "Get 6 kills against enemies affected by Frost Blast, Ring of Fire, or while hidden with Aether Shroud";
                        case 17:
                            return "Get 9 kills against enemies affected by Frost Blast, Ring of Fire, or while hidden with Aether Shroud";
                        case 18:
                            return "Get 12 kills against enemies affected by Frost Blast, Ring of Fire, or while hidden with Aether Shroud";
                        case 19:
                            return "Get 15 kills against enemies affected by Frost Blast, Ring of Fire, or while hidden with Aether Shroud";
                        case 20:
                            return "Get 2 elite eliminations";
                        case 21:
                            return "Get 4 elite eliminations";
                        case 22:
                            return "Get 6 elite eliminations";
                        case 23:
                            return "Get 8 elite eliminations";
                        case 24:
                            return "Get 10 elite eliminations";
                        case 25:
                            return "Get 10 kills rapidly 2 times";
                        case 26:
                            return "Get 10 kills rapidly 4 times";
                        case 27:
                            return "Get 10 kills rapidly 6 times";
                        case 28:
                            return "Get 10 kills rapidly 8 times";
                        case 29:
                            return "Get 10 kills rapidly 10 times";
                    }
                }
            }
            #endregion
            #region Multiplayer
            else {
                if (Camo > 29) {
                    switch (Camo) {
                        case 30:
                            return "Kill 2 or more enemies rapidly 5 times";
                        case 31:
                            return "Kill 2 or more enemies rapidly 10 times";
                        case 32:
                            return "Kill 2 or more enemies rapidly 15 times";
                        case 33:
                            return "Kill 2 or more enemies rapidly 20 times";
                        case 34:
                            return "Kill 2 or more enemies rapidly 25 times";
                        case 35:
                            return "Obtain all camos for a gun";
                        case 36:
                            return "Obtain all Gold camos for a weapon type";
                        case 37:
                            return "Obtain all Diamond camos for all weapons";
                    }
                }

                if (rbAR.Checked || rbTR.Checked || rbLMG.Checked) {
                    switch (Camo) {
                        case 0:
                            return "Get 25 kills";
                        case 1:
                            return "Get 50 kills";
                        case 2:
                            return "Get 100 kills";
                        case 3:
                            return "Get 200 kills";
                        case 4:
                            return "Get 300 kills";
                        case 5:
                            return "Get 10 headshot medals";
                        case 6:
                            return "Get 25 headshot medals";
                        case 7:
                            return "Get 50 headshot medals";
                        case 8:
                            return "Get 75 headshot medals";
                        case 9:
                            return "Get 100 headshot medals";
                        case 10:
                            return "Get 5 kills without dying 3 times";
                        case 11:
                            return "Get 5 kills without dying 5 times";
                        case 12:
                            return "Get 5 kills without dying 10 times";
                        case 13:
                            return "Get 5 kills without dying 15 times";
                        case 14:
                            return "Get 5 kills without dying 20 times";
                        case 15:
                            return "Get longshot medals 5 times";
                        case 16:
                            return "Get longshot medals 10 times";
                        case 17:
                            return "Get longshot medals 15 times";
                        case 18:
                            return "Get longshot medals 25 times";
                        case 19:
                            return "Get longshot medals 50 times";
                        case 20:
                            return "Get 5 kills against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 21:
                            return "Get 15 kills against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 22:
                            return "Get 30 kills against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 23:
                            return "Get 50 kills against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 24:
                            return "Get 75 kills against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 25:
                            return "Kill 5 enemies taking cover from you";
                        case 26:
                            return "Kill 10 enemies taking cover from you";
                        case 27:
                            return "Kill 15 enemies taking cover from you";
                        case 28:
                            return "Kill 25 enemies taking cover from you";
                        case 29:
                            return "Kill 50 enemies taking cover from you";
                    }
                }
                else if (rbSMG.Checked) {
                    switch (Camo) {
                        case 0:
                            return "Get 25 kills";
                        case 1:
                            return "Get 50 kills";
                        case 2:
                            return "Get 100 kills";
                        case 3:
                            return "Get 200 kills";
                        case 4:
                            return "Get 300 kills";
                        case 5:
                            return "Get 10 headshot medals";
                        case 6:
                            return "Get 20 headshot medals";
                        case 7:
                            return "Get 30 headshot medals";
                        case 8:
                            return "Get 50 headshot medals";
                        case 9:
                            return "Get 75 headshot medals";
                        case 10:
                            return "Get 5 kills without dying 3 times";
                        case 11:
                            return "Get 5 kills without dying 5 times";
                        case 12:
                            return "Get 5 kills without dying 10 times";
                        case 13:
                            return "Get 5 kills without dying 15 times";
                        case 14:
                            return "Get 5 kills without dying 20 times";
                        case 15:
                            return "Get longshot medals 5 times";
                        case 16:
                            return "Get longshot medals 10 times";
                        case 17:
                            return "Get longshot medals 15 times";
                        case 18:
                            return "Get longshot medals 25 times";
                        case 19:
                            return "Get longshot medals 20 times";
                        case 20:
                            return "5 against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 21:
                            return "15 against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 22:
                            return "30 against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 23:
                            return "50 against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 24:
                            return "75 against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 25:
                            return "Kill 10 enemies point blank";
                        case 26:
                            return "Kill 15 enemies point blank";
                        case 27:
                            return "Kill 30 enemies point blank";
                        case 28:
                            return "Kill 50 enemies point blank";
                        case 29:
                            return "Kill 75 enemies point blank";
                    }
                }
                else if (rbSR.Checked) {
                    switch (Camo) {
                        case 0:
                            return "Get 25 kills";
                        case 1:
                            return "Get 50 kills";
                        case 2:
                            return "Get 75 kills";
                        case 3:
                            return "Get 125 kills";
                        case 4:
                            return "Get 200 kills";
                        case 5:
                            return "Get 5 headshot medals";
                        case 6:
                            return "Get 10 headshot medals";
                        case 7:
                            return "Get 15 headshot medals";
                        case 8:
                            return "Get 25 headshot medals";
                        case 9:
                            return "Get 50 headshot medals";
                        case 10:
                            return "Get 5 kills without dying 3 times";
                        case 11:
                            return "Get 5 kills without dying 5 times";
                        case 12:
                            return "Get 5 kills without dying 10 times";
                        case 13:
                            return "Get 5 kills without dying 15 times";
                        case 14:
                            return "Get 5 kills without dying 20 times";
                        case 15:
                            return "Get longshot medals 5 times";
                        case 16:
                            return "Get longshot medals 10 times";
                        case 17:
                            return "Get longshot medals 15 times";
                        case 18:
                            return "Get longshot medals 25 times";
                        case 19:
                            return "Get longshot medals 50 times";
                        case 20:
                            return "5 while holding your breath";
                        case 21:
                            return "10 while holding your breath";
                        case 22:
                            return "15 while holding your breath";
                        case 23:
                            return "25 while holding your breath";
                        case 24:
                            return "50 while holding your breath";
                        case 25:
                            return "Get 5 one shot one kill medals";
                        case 26:
                            return "Get 10 one shot one kill medals";
                        case 27:
                            return "Get 15 one shot one kill medals";
                        case 28:
                            return "Get 25 one shot one kill medals";
                        case 29:
                            return "Get 50 one shot one kill medals";
                    }
                }
                else if (rbPS.Checked) {
                    switch (Camo) {
                        case 0:
                            return "Get 25 kills";
                        case 1:
                            return "Get 50 kills";
                        case 2:
                            return "Get 75 kills";
                        case 3:
                            return "Get 100 kills";
                        case 4:
                            return "Get 150 kills";
                        case 5:
                            return "Get 5 headshot medals";
                        case 6:
                            return "Get 10 headshot medals";
                        case 7:
                            return "Get 15 headshot medals";
                        case 8:
                            return "Get 25 headshot medals";
                        case 9:
                            return "Get 50 headshot medals";
                        case 10:
                            return "Get 5 kills without dying 3 times";
                        case 11:
                            return "Get 5 kills without dying 5 times";
                        case 12:
                            return "Get 5 kills without dying 10 times";
                        case 13:
                            return "Get 5 kills without dying 15 times";
                        case 14:
                            return "Get 5 kills without dying 20 times";
                        case 15:
                            return "Get longshot medals 5 times";
                        case 16:
                            return "Get longshot medals 10 times";
                        case 17:
                            return "Get longshot medals 15 times";
                        case 18:
                            return "Get longshot medals 20 times";
                        case 19:
                            return "Get longshot medals 25 times";
                        case 20:
                            return "Get 5 kills against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 21:
                            return "Get 10 kills against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 22:
                            return "Get 15 kills against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 23:
                            return "Get 25 kills against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 24:
                            return "Get 50 kills against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 25:
                            return "Kill 5 enemies taking cover from you";
                        case 26:
                            return "Kill 10 enemies taking cover from you";
                        case 27:
                            return "Kill 15 enemies taking cover from you";
                        case 28:
                            return "Kill 20 enemies taking cover from you";
                        case 29:
                            return "Kill 25 enemies taking cover from you";
                    }
                }
                else if (rbSG.Checked) {
                    switch (Camo) {
                        case 0:
                            return "Get 25 kills";
                        case 1:
                            return "Get 50 kills";
                        case 2:
                            return "Get 75 kills";
                        case 3:
                            return "Get 125 kills";
                        case 4:
                            return "Get 200 kills";
                        case 5:
                            return "Get 5 headshot medals";
                        case 6:
                            return "Get 10 headshot medals";
                        case 7:
                            return "Get 15 headshot medals";
                        case 8:
                            return "Get 25 headshot medals";
                        case 9:
                            return "Get 50 headshot medals";
                        case 10:
                            return "Get 5 kills without dying 3 times";
                        case 11:
                            return "Get 5 kills without dying 5 times";
                        case 12:
                            return "Get 5 kills without dying 10 times";
                        case 13:
                            return "Get 5 kills without dying 15 times";
                        case 14:
                            return "Get 5 kills without dying 20 times";
                        case 15:
                            return "Get longshot medals 5 times";
                        case 16:
                            return "Get longshot medals 10 times";
                        case 17:
                            return "Get longshot medals 15 times";
                        case 18:
                            return "Get longshot medals 25 times";
                        case 19:
                            return "Get longshot medals 50 times";
                        case 20:
                            return "Get 5 kills against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 21:
                            return "Get 15 kills against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 22:
                            return "Get 30 kills against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 23:
                            return "Get 50 kills against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 24:
                            return "Get 75 kills against enemies stunned or blinded by your scorestreaks, equipment, or field upgrades";
                        case 25:
                            return "Kill 5 enemies point blank";
                        case 26:
                            return "Kill 15 enemies point blank";
                        case 27:
                            return "Kill 30 enemies point blank";
                        case 28:
                            return "Kill 50 enemies point blank";
                        case 29:
                            return "Kill 75 enemies point blank";
                    }
                }
                else if (rbRL.Checked) {
                    switch (Camo) {
                        case 0:
                            return "Get 5 kills";
                        case 1:
                            return "Get 10 kills";
                        case 2:
                            return "Get 15 kills";
                        case 3:
                            return "Get 25 kills";
                        case 4:
                            return "Get 50 kills";
                        case 5:
                            return "Destroy 5 equipment, scorestreaks, or vehicles";
                        case 6:
                            return "Destroy 10 equipment, scorestreaks, or vehicles";
                        case 7:
                            return "Destroy 15 equipment, scorestreaks, or vehicles";
                        case 8:
                            return "Destroy 25 equipment, scorestreaks, or vehicles";
                        case 9:
                            return "Destroy 50 equipment, scorestreaks, or vehicles";
                        case 10:
                            return "Get 2 kills without dying 3 times only from the weapon";
                        case 11:
                            return "Get 2 kills without dying 5 times only from the weapon";
                        case 12:
                            return "Get 2 kills without dying 10 times only from the weapon";
                        case 13:
                            return "Get 2 kills without dying 15 times only from the weapon";
                        case 14:
                            return "Get 2 kills without dying 20 times only from the weapon";
                        case 15:
                            return "Destroy 5 ground-based scorestreaks or vehicles";
                        case 16:
                            return "Destroy 10 ground-based scorestreaks or vehicles";
                        case 17:
                            return "Destroy 15 ground-based scorestreaks or vehicles";
                        case 18:
                            return "Destroy 25 ground-based scorestreaks or vehicles";
                        case 19:
                            return "Destroy 50 ground-based scorestreaks or vehicles";
                        case 20:
                            return "Destroy 5 aerial scorestreaks or vehicles";
                        case 21:
                            return "Destroy 10 aerial scorestreaks or vehicles";
                        case 22:
                            return "Destroy 15 aerial scorestreaks or vehicles";
                        case 23:
                            return "Destroy 25 aerial scorestreaks or vehicles";
                        case 24:
                            return "Destroy 50 aerial scorestreaks or vehicles";
                        case 25:
                            return "Destroy 3 scorestreaks or vehicles in a single game 1 times";
                        case 26:
                            return "Destroy 3 scorestreaks or vehicles in a single game 2 times";
                        case 27:
                            return "Destroy 3 scorestreaks or vehicles in a single game 4 times";
                        case 28:
                            return "Destroy 3 scorestreaks or vehicles in a single game 5 times";
                        case 29:
                            return "Destroy 3 scorestreaks or vehicles in a single game 10 times";
                    }
                }
                else if (rbSP.Checked) {
                    if (radioButton1.Checked || radioButton4.Checked) {
                        switch (Camo) {
                            case 0:
                                return "Get 5 kills";
                            case 1:
                                return "Get 10 kills";
                            case 2:
                                return "Get 25 kills";
                            case 3:
                                return "Get 50 kills";
                            case 4:
                                return "Get 75 kills";
                            case 5:
                                return "Get 5 backstabber medals (kills from behind)";
                            case 6:
                                return "Get 10 backstabber medals (kills from behind)";
                            case 7:
                                return "Get 15 backstabber medals (kills from behind)";
                            case 8:
                                return "Get 20 backstabber medals (kills from behind)";
                            case 9:
                                return "Get 25 backstabber medals (kills from behind)";
                            case 10:
                                return "Execute 5 finishing moves";
                            case 11:
                                return "Execute 10 finishing moves";
                            case 12:
                                return "Execute 15 finishing moves";
                            case 13:
                                return "Execute 20 finishing moves";
                            case 14:
                                return "Execute 25 finishing moves";
                            case 15:
                                return "Get 5 kills while injured";
                            case 16:
                                return "Get 10 kills while injured";
                            case 17:
                                return "Get 15 kills while injured";
                            case 18:
                                return "Get 25 kills while injured";
                            case 19:
                                return "Get 50 kills while injured";
                            case 20:
                                return "Get 5 kills while sliding";
                            case 21:
                                return "Get 10 kills while sliding";
                            case 22:
                                return "Get 15 kills while sliding";
                            case 23:
                                return "Get 25 kills while sliding";
                            case 24:
                                return "Get 50 kills while sliding";
                            case 25:
                                return "Get 5 kills against enemies disoriented by smoke, flash, or stun grenades";
                            case 26:
                                return "Get 10 kills against enemies disoriented by smoke, flash, or stun grenades";
                            case 27:
                                return "Get 15 kills against enemies disoriented by smoke, flash, or stun grenades";
                            case 28:
                                return "Get 25 kills against enemies disoriented by smoke, flash, or stun grenades";
                            case 29:
                                return "Get 50 kills against enemies disoriented by smoke, flash, or stun grenades";
                        }
                    }
                    else if (radioButton2.Checked) {
                        switch (Camo) {
                            case 0:
                                return "Get 5 kills";
                            case 1:
                                return "Get 10 kills";
                            case 2:
                                return "Get 15 kills";
                            case 3:
                                return "Get 25 kills";
                            case 4:
                                return "Get 30 kills";
                            case 5:
                                return "Get 5 longshot medals";
                            case 6:
                                return "Get 10 longshot medals";
                            case 7:
                                return "Get 15 longshot medals";
                            case 8:
                                return "Get 25 longshot medals";
                            case 9:
                                return "Get 50 longshot medals";
                            case 10:
                                return "Get 2 kills without dying 3 times only from the weapon";
                            case 11:
                                return "Get 2 kills without dying 5 times only from the weapon";
                            case 12:
                                return "Get 2 kills without dying 10 times only from the weapon";
                            case 13:
                                return "Get 2 kills without dying 15 times only from the weapon";
                            case 14:
                                return "Get 2 kills without dying 20 times only from the weapon";
                            case 15:
                                return "Destroy 5 equipment, scorestreaks, or vehicles";
                            case 16:
                                return "Destroy 10 equipment, scorestreaks, or vehicles";
                            case 17:
                                return "Destroy 15 equipment, scorestreaks, or vehicles";
                            case 18:
                                return "Destroy 25 equipment, scorestreaks, or vehicles";
                            case 19:
                                return "Destroy 50 equipment, scorestreaks, or vehicles";
                            case 20:
                                return "Kill 5 enemies taking cover from you";
                            case 21:
                                return "Kill 10 enemies taking cover from you";
                            case 22:
                                return "Kill 15 enemies taking cover from you";
                            case 23:
                                return "Kill 25 enemies taking cover from you";
                            case 24:
                                return "Kill 50 enemies taking cover from you";
                            case 25:
                                return "Destroy 3 scorestreaks or vehicles in a single game 1 times";
                            case 26:
                                return "Destroy 3 scorestreaks or vehicles in a single game 2 times";
                            case 27:
                                return "Destroy 3 scorestreaks or vehicles in a single game 4 times";
                            case 28:
                                return "Destroy 3 scorestreaks or vehicles in a single game 5 times";
                            case 29:
                                return "Destroy 3 scorestreaks or vehicles in a single game 10 times";
                        }
                    }
                }
            }
            #endregion
            return null;
        }
        [System.Diagnostics.DebuggerStepThrough]
        private bool CheckCamos() {
            return true;
        }

        private void SwitchClass(WeaponClass NewClass) {
            SwitchingClass = true;

            if (SelectedWeapon != -1) {
                switch (SelectedClass) {
                    case WeaponClass.AssaultRifle:
                        if (AssaultRifles.Default.Last != SelectedWeapon) {
                            Console.WriteLine("Saving AssaultRifles");
                            AssaultRifles.Default.Last = SelectedWeapon;
                            AssaultRifles.Default.Save();
                        }
                        break;
                    case WeaponClass.SubmachineGun:
                        if (SubmachineGuns.Default.Last != SelectedWeapon) {
                            Console.WriteLine("Saving SubmachineGuns");
                            SubmachineGuns.Default.Last = SelectedWeapon;
                            SubmachineGuns.Default.Save();
                        }
                        break;
                    case WeaponClass.TacticalRifle:
                        if (TacticalRifles.Default.Last != SelectedWeapon) {
                            Console.WriteLine("Saving TacticalRifles");
                            TacticalRifles.Default.Last = SelectedWeapon;
                            TacticalRifles.Default.Save();
                        }
                        break;
                    case WeaponClass.LightMachineGun:
                        if (LightMachineGuns.Default.Last != SelectedWeapon) {
                            Console.WriteLine("Saving LightMachineGuns");
                            LightMachineGuns.Default.Last = SelectedWeapon;
                            LightMachineGuns.Default.Save();
                        }
                        break;
                    case WeaponClass.SniperRifle:
                        if (SniperRifles.Default.Last != SelectedWeapon) {
                            Console.WriteLine("Saving SniperRifles");
                            SniperRifles.Default.Last = SelectedWeapon;
                            SniperRifles.Default.Save();
                        }
                        break;
                    case WeaponClass.Pistol:
                        if (Pistols.Default.Last != SelectedWeapon) {
                            Console.WriteLine("Saving Pistols");
                            Pistols.Default.Last = SelectedWeapon;
                            Pistols.Default.Save();
                        }
                        break;
                    case WeaponClass.Shotgun:
                        if (Shotguns.Default.Last != SelectedWeapon) {
                            Console.WriteLine("Saving Shotguns");
                            Shotguns.Default.Last = SelectedWeapon;
                            Shotguns.Default.Save();
                        }
                        break;
                    case WeaponClass.RocketLauncher:
                        if (RocketLaunchers.Default.Last != SelectedWeapon) {
                            Console.WriteLine("Saving RocketLaunchers");
                            RocketLaunchers.Default.Last = SelectedWeapon;
                            RocketLaunchers.Default.Save();
                        }
                        break;
                    case WeaponClass.Special:
                        if (Specials.Default.Last != SelectedWeapon) {
                            Console.WriteLine("Saving Specials");
                            Specials.Default.Last = SelectedWeapon;
                            Specials.Default.Save();
                        }
                        break;
                }
            }

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;

            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;

            radioButton1.Text = "Unused";
            radioButton2.Text = "Unused";
            radioButton3.Text = "Unused";
            radioButton4.Text = "Unused";
            radioButton5.Text = "Unused";
            radioButton6.Text = "Unused";

            lbWeaponLevel.Text = "Level";

            SelectedWeapon = -1;
            int GoldCount_MP = 0;
            int GoldCount_ZM = 0;

            switch (NewClass) {
                #region Assault Rifles
                case WeaponClass.AssaultRifle:
                    Console.WriteLine("Loading AssaultRifles");
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    radioButton5.Visible = true;
                    radioButton6.Visible = true;
                    radioButton7.Visible = true;
                    radioButton1.Text = "XM4";
                    radioButton2.Text = "AK-47";
                    radioButton3.Text = "Krig 6";
                    radioButton4.Text = "QBZ-83";
                    radioButton5.Text = "FFAR 1";
                    radioButton6.Text = "Groza";
                    radioButton7.Text = "FARA 83";

                    lbWeaponLevel.Text += " (Max 55)";

                    if (AssaultRifles.Default.XM4_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (AssaultRifles.Default.AK47_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (AssaultRifles.Default.KRIG6_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (AssaultRifles.Default.QBZ83_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (AssaultRifles.Default.FFAR1_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (AssaultRifles.Default.GROZA_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (AssaultRifles.Default.FARA83_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }

                    if ( GoldCount_MP < 5) {
                        lbDiamondUnlocked.Visible = false;
                    }
                    else {
                        lbDiamondUnlocked.Visible = true;
                    }

                    if (AssaultRifles.Default.XM4_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (AssaultRifles.Default.AK47_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (AssaultRifles.Default.KRIG6_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (AssaultRifles.Default.QBZ83_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (AssaultRifles.Default.FFAR1_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (AssaultRifles.Default.GROZA_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (AssaultRifles.Default.FARA83_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }

                    if ( GoldCount_ZM < 5) {
                        lbPlagueDiamondUnlocked.Visible = false;
                    }
                    else {
                        lbPlagueDiamondUnlocked.Visible = true;
                    }

                    if (AssaultRifles.Default.Last != -1) {
                        SelectedWeapon = AssaultRifles.Default.Last;
                    }

                    SetCamoLevels(0);
                    break;
                #endregion
                #region Submachine Guns
                case WeaponClass.SubmachineGun:
                    Console.WriteLine("Loading SubmachineGuns");
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    radioButton5.Visible = true;
                    radioButton6.Visible = true;
                    radioButton7.Visible = true;
                    radioButton1.Text = "MP5";
                    radioButton2.Text = "Milano 821";
                    radioButton3.Text = "AK-74u";
                    radioButton4.Text = "KSP 45";
                    radioButton5.Text = "Bullfrog";
                    radioButton6.Text = "MAC-10";
                    radioButton7.Text = "LC10";

                    lbWeaponLevel.Text += " (Max 55)";

                    if (SubmachineGuns.Default.MP5_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (SubmachineGuns.Default.MILANO821_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (SubmachineGuns.Default.AK74U_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (SubmachineGuns.Default.KSP45_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (SubmachineGuns.Default.BULLFROG_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (SubmachineGuns.Default.MAC10_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (SubmachineGuns.Default.LC10_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }

                    if ( GoldCount_MP < 5) {
                        lbDiamondUnlocked.Visible = false;
                    }
                    else {
                        lbDiamondUnlocked.Visible = true;
                    }

                    if (SubmachineGuns.Default.MP5_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (SubmachineGuns.Default.MILANO821_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (SubmachineGuns.Default.AK74U_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (SubmachineGuns.Default.KSP45_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (SubmachineGuns.Default.BULLFROG_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (SubmachineGuns.Default.MAC10_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (SubmachineGuns.Default.LC10_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }

                    if ( GoldCount_ZM < 5) {
                        lbPlagueDiamondUnlocked.Visible = false;
                    }
                    else {
                        lbPlagueDiamondUnlocked.Visible = true;
                    }

                    if (SubmachineGuns.Default.Last != -1) {
                        SelectedWeapon = SubmachineGuns.Default.Last;
                    }

                    SetCamoLevels(0);
                    break;
                #endregion
                #region Tactical Rifles
                case WeaponClass.TacticalRifle:
                    Console.WriteLine("Loading TacticalRifles");
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    radioButton1.Text = "Type 63";
                    radioButton2.Text = "M16";
                    radioButton3.Text = "AUG";
                    radioButton4.Text = "DMR-14";

                    lbWeaponLevel.Text += " (Max 55)";

                    if (TacticalRifles.Default.TYPE63_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (TacticalRifles.Default.M16_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (TacticalRifles.Default.AUG_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (TacticalRifles.Default.DMR14_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }

                    if ( GoldCount_MP < 4) {
                        lbDiamondUnlocked.Visible = false;
                    }
                    else {
                        lbDiamondUnlocked.Visible = true;
                    }

                    if (TacticalRifles.Default.TYPE63_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (TacticalRifles.Default.M16_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (TacticalRifles.Default.AUG_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (TacticalRifles.Default.DMR14_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }

                    if ( GoldCount_ZM < 4) {
                        lbPlagueDiamondUnlocked.Visible = false;
                    }
                    else {
                        lbPlagueDiamondUnlocked.Visible = true;
                    }

                    if (TacticalRifles.Default.Last != -1) {
                        SelectedWeapon = TacticalRifles.Default.Last;
                    }

                    SetCamoLevels(0);
                    break;
                #endregion
                #region Light Machine Guns
                case WeaponClass.LightMachineGun:
                    Console.WriteLine("Loading LightMachineGuns");
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton1.Text = "Stoner-63";
                    radioButton2.Text = "RPD";
                    radioButton3.Text = "M60";

                    lbWeaponLevel.Text += " (Max 55)";

                    if (LightMachineGuns.Default.STONER63_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (LightMachineGuns.Default.RPD_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (LightMachineGuns.Default.M60_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }

                    if ( GoldCount_MP < 3) {
                        lbDiamondUnlocked.Visible = false;
                    }
                    else {
                        lbDiamondUnlocked.Visible = true;
                    }

                    if (LightMachineGuns.Default.STONER63_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (LightMachineGuns.Default.RPD_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (LightMachineGuns.Default.M60_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }

                    if ( GoldCount_ZM < 3) {
                        lbPlagueDiamondUnlocked.Visible = false;
                    }
                    else {
                        lbPlagueDiamondUnlocked.Visible = true;
                    }

                    if (LightMachineGuns.Default.Last != -1) {
                        SelectedWeapon = LightMachineGuns.Default.Last;
                    }

                    SetCamoLevels(0);
                    break;
                #endregion
                #region Sniper Rifles
                case WeaponClass.SniperRifle:
                    Console.WriteLine("Loading SniperRifles");
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    radioButton1.Text = "Pelington 703";
                    radioButton2.Text = "LW3 - Tundra";
                    radioButton3.Text = "M82";
                    radioButton4.Text = "ZRG 20mm";

                    lbWeaponLevel.Text += " (Max 55)";

                    if (SniperRifles.Default.PELINGTON703_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (SniperRifles.Default.LW3TUNDRA_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (SniperRifles.Default.M82_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (SniperRifles.Default.ZRG20MM_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }

                    if ( GoldCount_MP < 3) {
                        lbDiamondUnlocked.Visible = false;
                    }
                    else {
                        lbDiamondUnlocked.Visible = true;
                    }

                    if (SniperRifles.Default.PELINGTON703_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (SniperRifles.Default.LW3TUNDRA_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (SniperRifles.Default.M82_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (SniperRifles.Default.ZRG20MM_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }

                    if ( GoldCount_ZM < 3) {
                        lbPlagueDiamondUnlocked.Visible = false;
                    }
                    else {
                        lbPlagueDiamondUnlocked.Visible = true;
                    }

                    if (SniperRifles.Default.Last != -1) {
                        SelectedWeapon = SniperRifles.Default.Last;
                    }

                    SetCamoLevels(0);
                    break;
                #endregion
                #region Pistols
                case WeaponClass.Pistol:
                    Console.WriteLine("Loading Pistols");
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton1.Text = "1911";
                    radioButton2.Text = "Magnum";
                    radioButton3.Text = "Diamatti";

                    lbWeaponLevel.Text += " (Max 35)";

                    if (Pistols.Default.M1911_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (Pistols.Default.MAGNUM_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (Pistols.Default.DIAMATTI_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }

                    if ( GoldCount_MP < 3) {
                        lbDiamondUnlocked.Visible = false;
                    }
                    else {
                        lbDiamondUnlocked.Visible = true;
                    }

                    if (Pistols.Default.M1911_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (Pistols.Default.MAGNUM_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (Pistols.Default.DIAMATTI_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }

                    if ( GoldCount_ZM < 3) {
                        lbPlagueDiamondUnlocked.Visible = false;
                    }
                    else {
                        lbPlagueDiamondUnlocked.Visible = true;
                    }

                    if (Pistols.Default.Last != -1) {
                        SelectedWeapon = Pistols.Default.Last;
                    }

                    SetCamoLevels(1);
                    break;
                #endregion
                #region Shotguns
                case WeaponClass.Shotgun:
                    Console.WriteLine("Loading Shotguns");
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton1.Text = "Hauer 77";
                    radioButton2.Text = "Gallo SA12";
                    radioButton3.Text = "Streetsweeper";

                    lbWeaponLevel.Text += " (Max 36)";

                    if (Shotguns.Default.HAUER77_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (Shotguns.Default.GALLOSA12_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (Shotguns.Default.STREETSWEEPER_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }

                    if ( GoldCount_MP < 2) {
                        lbDiamondUnlocked.Visible = false;
                    }
                    else {
                        lbDiamondUnlocked.Visible = true;
                    }

                    if (Shotguns.Default.HAUER77_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (Shotguns.Default.GALLOSA12_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (Shotguns.Default.STREETSWEEPER_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }

                    if ( GoldCount_ZM < 2) {
                        lbPlagueDiamondUnlocked.Visible = false;
                    }
                    else {
                        lbPlagueDiamondUnlocked.Visible = true;
                    }

                    if (Shotguns.Default.Last != -1) {
                        SelectedWeapon = Shotguns.Default.Last;
                    }

                    SetCamoLevels(1);
                    break;
                #endregion
                #region Rocket Launchers
                case WeaponClass.RocketLauncher:
                    Console.WriteLine("Loading RocketLaunchers");
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton1.Text = "Cigma 2";
                    radioButton2.Text = "RPG-7";

                    lbWeaponLevel.Text += " (Max 35)";

                    if (RocketLaunchers.Default.CIGMA2_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (RocketLaunchers.Default.RPG7_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }

                    if ( GoldCount_MP < 2) {
                        lbDiamondUnlocked.Visible = false;
                    }
                    else {
                        lbDiamondUnlocked.Visible = true;
                    }

                    if (RocketLaunchers.Default.CIGMA2_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (RocketLaunchers.Default.RPG7_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }

                    if ( GoldCount_ZM < 2) {
                        lbPlagueDiamondUnlocked.Visible = false;
                    }
                    else {
                        lbPlagueDiamondUnlocked.Visible = true;
                    }

                    if (RocketLaunchers.Default.Last != -1) {
                        SelectedWeapon = RocketLaunchers.Default.Last;
                    }

                    SetCamoLevels(1);
                    break;
                #endregion
                #region Specials
                case WeaponClass.Special:
                    Console.WriteLine("Loading Specials");
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    radioButton5.Visible = true;
                    radioButton6.Visible = true;
                    radioButton7.Visible = true;
                    radioButton1.Text = "Knife";
                    radioButton2.Text = "M79";
                    radioButton3.Text = "Sledgehammer";
                    radioButton4.Text = "Wakizashi";
                    radioButton5.Text = "Machete";
                    radioButton6.Text = "E-Tool";
                    radioButton7.Text = "R1 Shadowhunter";

                    lbWeaponLevel.Text += " (Max 35)";

                    if (Specials.Default.KNIFE_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (Specials.Default.M79_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (Specials.Default.SLEDGEHAMMER_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (Specials.Default.WAKIZASHI_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (Specials.Default.MACHETE_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (Specials.Default.ETOOL_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }
                    if (Specials.Default.R1SHADOWHUNTER_CAMO_MP.StartsWith(CompleteCamo)) {
                        GoldCount_MP++;
                    }

                    if ( GoldCount_MP < 2) {
                        lbDiamondUnlocked.Visible = false;
                    }
                    else {
                        lbDiamondUnlocked.Visible = true;
                    }

                    if (Specials.Default.KNIFE_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (Specials.Default.M79_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (Specials.Default.SLEDGEHAMMER_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (Specials.Default.WAKIZASHI_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (Specials.Default.MACHETE_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (Specials.Default.ETOOL_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }
                    if (Specials.Default.R1SHADOWHUNTER_CAMO_ZM.StartsWith(CompleteCamo)) {
                        GoldCount_ZM++;
                    }

                    if ( GoldCount_ZM < 2) {
                        lbPlagueDiamondUnlocked.Visible = false;
                    }
                    else {
                        lbPlagueDiamondUnlocked.Visible = true;
                    }

                    if (Specials.Default.Last != -1) {
                        SelectedWeapon = Specials.Default.Last;
                    }

                    SetCamoLevels(1);
                    break;
                #endregion
            }

            lbIsGold.Text = "";
            lbIsGoldenViper.Text = "";
            lbHowToUnlock.Text = "HEY! Select a camo to learn how to complete it";

            SetControlsVisibility(false);

            SetLocations();

            SelectedClass = NewClass;
            switch (SelectedWeapon) {
                case 0:
                    radioButton1.Checked = true;
                    break;
                case 1:
                    radioButton2.Checked = true;
                    break;
                case 2:
                    radioButton3.Checked = true;
                    break;
                case 3:
                    radioButton4.Checked = true;
                    break;
                case 4:
                    radioButton5.Checked = true;
                    break;
                case 5:
                    radioButton6.Checked = true;
                    break;
                case 6:
                    radioButton7.Checked = true;
                    break;
            }

            SwitchingClass = false;
        }

        private void SelectedWeaponSkeleton() {
            switch (SelectedClass) {
                #region AssaultRifles
                case WeaponClass.AssaultRifle:
                    switch (SelectedWeapon) {
                        case 0:
                            // XM4

                            break;
                        case 1:
                            // AK47

                            break;
                        case 2:
                            // KRIG6

                            break;
                        case 3:
                            // QBZ83

                            break;
                        case 4:
                            // FFAR1

                            break;
                        case 5:
                            // GROZA

                            break;
                        case 6:
                            // FARA83

                            break;
                    }
                    break;
                #endregion
                #region SubmachineGuns
                case WeaponClass.SubmachineGun:
                    switch (SelectedWeapon) {
                        case 0:
                            // MP5

                            break;
                        case 1:
                            // MILANO821
                            break;
                        case 2:
                            // AK74U
                            break;
                        case 3:
                            // KSP45

                            break;
                        case 4:
                            // BULLFROG

                            break;
                        case 5:
                            // MAC10

                            break;
                        case 6:
                            // LC10

                            break;
                    }
                    break;
                #endregion
                #region TacticalRifles
                case WeaponClass.TacticalRifle:
                    switch (SelectedWeapon) {
                        case 0:
                            // TYPE63

                            break;
                        case 1:
                            // M16

                            break;
                        case 2:
                            // AUG

                            break;
                        case 3:
                            // DMR14

                            break;
                    }
                    break;
                #endregion
                #region LightMachineGuns
                case WeaponClass.LightMachineGun:
                    switch (SelectedWeapon) {
                        case 0:
                            // STONER63

                            break;
                        case 1:
                            // RPD

                            break;
                        case 2:
                            // M60

                            break;
                    }
                    break;
                #endregion
                #region Snipers
                case WeaponClass.SniperRifle:
                    switch (SelectedWeapon) {
                        case 0:
                            // PELINGTON703

                            break;
                        case 1:
                            // LW3TUNDRA

                            break;
                        case 2:
                            // M82

                            break;
                        case 3:
                            // ZRG20MM

                            break;
                    }
                    break;
                #endregion
                #region Pistols
                case WeaponClass.Pistol:
                    switch (SelectedWeapon) {
                        case 0:
                            // M1911

                            break;
                        case 1:
                            // MAGNUM

                            break;
                        case 2:
                            // DIAMATTI

                            break;
                    }
                    break;
                #endregion
                #region Shotguns
                case WeaponClass.Shotgun:
                    switch (SelectedWeapon) {
                        case 0:
                            // HAUER77

                            break;
                        case 1:
                            // GALLOSA12

                            break;
                        case 2:
                            // STREETSWEEPER

                            break;
                    }
                    break;
                #endregion
                #region RocketLaunchers
                case WeaponClass.RocketLauncher:
                    switch (SelectedWeapon) {
                        case 0:
                            // CIGMA2

                            break;
                        case 1:
                            // RPG7

                            break;
                    }
                    break;
                #endregion
                #region Specials
                case WeaponClass.Special:
                    switch (SelectedWeapon) {
                        case 0:
                            // KNIFE

                            break;
                        case 1:
                            // M79

                            break;
                        case 2:
                            // SLEDGEHAMMER

                            break;
                        case 3:
                            // WAKIZASHI

                            break;
                        case 4:
                            // MACHETE

                            break;
                        case 5:
                            // ETOOL

                            break;
                        case 6:
                            // R1SHADOWHUNTER

                            break;
                    }
                    break;
                #endregion
            }
        }

        private void SaveWeapon() {
            #region Don't save if...
            if (SelectedClass == WeaponClass.None || SelectedWeapon == -1 || !WeaponModified || SwitchingClass) {
                return;
            }
            #endregion

            #region Check textboxes
            if (string.IsNullOrEmpty(txtTier0MP.Text)) {
                txtTier0MP.Text = "0";
            }
            if (string.IsNullOrEmpty(txtTier1MP.Text)) {
                txtTier1MP.Text = "0";
            }
            if (string.IsNullOrEmpty(txtTier2MP.Text)) {
                txtTier2MP.Text = "0";
            }
            if (string.IsNullOrEmpty(txtTier3MP.Text)) {
                txtTier3MP.Text = "0";
            }
            if (string.IsNullOrEmpty(txtTier4MP.Text)) {
                txtTier4MP.Text = "0";
            }
            if (string.IsNullOrEmpty(txtTier5MP.Text)) {
                txtTier5MP.Text = "0";
            }
            if (string.IsNullOrEmpty(txtTier6MP.Text)) {
                txtTier6MP.Text = "0";
            }

            if (string.IsNullOrEmpty(txtTier0ZM.Text)) {
                txtTier0ZM.Text = "0";
            }
            if (string.IsNullOrEmpty(txtTier1ZM.Text)) {
                txtTier1ZM.Text = "0";
            }
            if (string.IsNullOrEmpty(txtTier2ZM.Text)) {
                txtTier2ZM.Text = "0";
            }
            if (string.IsNullOrEmpty(txtTier3ZM.Text)) {
                txtTier3ZM.Text = "0";
            }
            if (string.IsNullOrEmpty(txtTier4ZM.Text)) {
                txtTier4ZM.Text = "0";
            }
            if (string.IsNullOrEmpty(txtTier5ZM.Text)) {
                txtTier5ZM.Text = "0";
            }
            if (string.IsNullOrEmpty(txtTier6ZM.Text)) {
                txtTier6ZM.Text = "0";
            }

            if (string.IsNullOrEmpty(txtWeaponLevel.Text)) {
                txtWeaponLevel.Text = "1";
            }
            #endregion

            string SettingBufferCamoMP = string.Empty;
            string SettingBufferCamoZM = string.Empty;
            string SettingBufferStatsMP = txtTier0MP.Text + "," + txtTier1MP.Text + "," + txtTier2MP.Text + "," + txtTier3MP.Text + "," + txtTier4MP.Text + "," + txtTier5MP.Text + "," + txtTier6MP.Text;
            string SettingBufferStatsZM = txtTier0ZM.Text + "," + txtTier1ZM.Text + "," + txtTier2ZM.Text + "," + txtTier3ZM.Text + "," + txtTier4ZM.Text + "," + txtTier5ZM.Text + "," + txtTier6ZM.Text;

            for (int i = 0; i < lvMultiplayerCamo.Items.Count; i++) {
                if (lvMultiplayerCamo.Items[i].Checked) {
                    SettingBufferCamoMP += "1";
                }
                else {
                    SettingBufferCamoMP += "0";
                }

                if (lvZombieCamo.Items[i].Checked) {
                    SettingBufferCamoZM += "1";
                }
                else {
                    SettingBufferCamoZM += "0";
                }
            }

            switch (SelectedClass) {
                #region Assault Rifles
                case WeaponClass.AssaultRifle:
                    switch (SelectedWeapon) {
                        case 0:
                            // XM4
                            System.Diagnostics.Debug.Print("Saving XM4");
                            if (AssaultRifles.Default.XM4_LEVEL != txtWeaponLevel.Text) {
                                AssaultRifles.Default.XM4_LEVEL = txtWeaponLevel.Text;
                            }
                            if (AssaultRifles.Default.XM4_CAMO_MP != SettingBufferCamoMP) {
                                AssaultRifles.Default.XM4_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (AssaultRifles.Default.XM4_CAMO_ZM != SettingBufferCamoZM) {
                                AssaultRifles.Default.XM4_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (AssaultRifles.Default.XM4_STATS_MP != SettingBufferStatsMP) {
                                AssaultRifles.Default.XM4_STATS_MP = SettingBufferStatsMP;
                            }
                            if (AssaultRifles.Default.XM4_STATS_ZM != SettingBufferStatsZM) {
                                AssaultRifles.Default.XM4_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 1:
                            // AK47
                            System.Diagnostics.Debug.Print("Saving AK47");
                            if (AssaultRifles.Default.AK47_LEVEL != txtWeaponLevel.Text) {
                                AssaultRifles.Default.AK47_LEVEL = txtWeaponLevel.Text;
                            }
                            if (AssaultRifles.Default.AK47_CAMO_MP != SettingBufferCamoMP) {
                                AssaultRifles.Default.AK47_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (AssaultRifles.Default.AK47_CAMO_ZM != SettingBufferCamoZM) {
                                AssaultRifles.Default.AK47_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (AssaultRifles.Default.AK47_STATS_MP != SettingBufferStatsMP) {
                                AssaultRifles.Default.AK47_STATS_MP = SettingBufferStatsMP;
                            }
                            if (AssaultRifles.Default.AK47_STATS_ZM != SettingBufferStatsZM) {
                                AssaultRifles.Default.AK47_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 2:
                            // KRIG6
                            System.Diagnostics.Debug.Print("Saving KRIG6");
                            if (AssaultRifles.Default.KRIG6_LEVEL != txtWeaponLevel.Text) {
                                AssaultRifles.Default.KRIG6_LEVEL = txtWeaponLevel.Text;
                            }
                            if (AssaultRifles.Default.KRIG6_CAMO_MP != SettingBufferCamoMP) {
                                AssaultRifles.Default.KRIG6_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (AssaultRifles.Default.KRIG6_CAMO_ZM != SettingBufferCamoZM) {
                                AssaultRifles.Default.KRIG6_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (AssaultRifles.Default.KRIG6_STATS_MP != SettingBufferStatsMP) {
                                AssaultRifles.Default.KRIG6_STATS_MP = SettingBufferStatsMP;
                            }
                            if (AssaultRifles.Default.KRIG6_STATS_ZM != SettingBufferStatsZM) {
                                AssaultRifles.Default.KRIG6_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 3:
                            // QBZ83
                            System.Diagnostics.Debug.Print("Saving QBZ83");
                            if (AssaultRifles.Default.QBZ83_LEVEL != txtWeaponLevel.Text) {
                                AssaultRifles.Default.QBZ83_LEVEL = txtWeaponLevel.Text;
                            }
                            if (AssaultRifles.Default.QBZ83_CAMO_MP != SettingBufferCamoMP) {
                                AssaultRifles.Default.QBZ83_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (AssaultRifles.Default.QBZ83_CAMO_ZM != SettingBufferCamoZM) {
                                AssaultRifles.Default.QBZ83_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (AssaultRifles.Default.QBZ83_STATS_MP != SettingBufferStatsMP) {
                                AssaultRifles.Default.QBZ83_STATS_MP = SettingBufferStatsMP;
                            }
                            if (AssaultRifles.Default.QBZ83_STATS_ZM != SettingBufferStatsZM) {
                                AssaultRifles.Default.QBZ83_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 4:
                            // FFAR1
                            System.Diagnostics.Debug.Print("Saving FFAR1");
                            if (AssaultRifles.Default.FFAR1_LEVEL != txtWeaponLevel.Text) {
                                AssaultRifles.Default.FFAR1_LEVEL = txtWeaponLevel.Text;
                            }
                            if (AssaultRifles.Default.FFAR1_CAMO_MP != SettingBufferCamoMP) {
                                AssaultRifles.Default.FFAR1_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (AssaultRifles.Default.FFAR1_CAMO_ZM != SettingBufferCamoZM) {
                                AssaultRifles.Default.FFAR1_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (AssaultRifles.Default.FFAR1_STATS_MP != SettingBufferStatsMP) {
                                AssaultRifles.Default.FFAR1_STATS_MP = SettingBufferStatsMP;
                            }
                            if (AssaultRifles.Default.FFAR1_STATS_ZM != SettingBufferStatsZM) {
                                AssaultRifles.Default.FFAR1_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 5:
                            // Groza
                            System.Diagnostics.Debug.Print("Saving GROZA");
                            if (AssaultRifles.Default.GROZA_LEVEL != txtWeaponLevel.Text) {
                                AssaultRifles.Default.GROZA_LEVEL = txtWeaponLevel.Text;
                            }
                            if (AssaultRifles.Default.GROZA_CAMO_MP != SettingBufferCamoMP) {
                                AssaultRifles.Default.GROZA_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (AssaultRifles.Default.GROZA_CAMO_ZM != SettingBufferCamoZM) {
                                AssaultRifles.Default.GROZA_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (AssaultRifles.Default.GROZA_STATS_MP != SettingBufferStatsMP) {
                                AssaultRifles.Default.GROZA_STATS_MP = SettingBufferStatsMP;
                            }
                            if (AssaultRifles.Default.GROZA_STATS_ZM != SettingBufferStatsZM) {
                                AssaultRifles.Default.GROZA_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 6:
                            // FARA 83
                            System.Diagnostics.Debug.Print("Saving FARA83");
                            if (AssaultRifles.Default.FARA83_LEVEL != txtWeaponLevel.Text) {
                                AssaultRifles.Default.FARA83_LEVEL = txtWeaponLevel.Text;
                            }
                            if (AssaultRifles.Default.FARA83_CAMO_MP != SettingBufferCamoMP) {
                                AssaultRifles.Default.FARA83_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (AssaultRifles.Default.FARA83_CAMO_ZM != SettingBufferCamoZM) {
                                AssaultRifles.Default.FARA83_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (AssaultRifles.Default.FARA83_STATS_MP != SettingBufferStatsMP) {
                                AssaultRifles.Default.FARA83_STATS_MP = SettingBufferStatsMP;
                            }
                            if (AssaultRifles.Default.FARA83_STATS_ZM != SettingBufferStatsZM) {
                                AssaultRifles.Default.FARA83_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                    }
                    AssaultRifles.Default.Save();
                    break;
                #endregion
                #region Submachine Guns
                case WeaponClass.SubmachineGun:
                    switch (SelectedWeapon) {
                        case 0:
                            // MP5
                            System.Diagnostics.Debug.Print("Saving MP5");
                            if (SubmachineGuns.Default.MP5_LEVEL != txtWeaponLevel.Text) {
                                SubmachineGuns.Default.MP5_LEVEL = txtWeaponLevel.Text;
                            }
                            if (SubmachineGuns.Default.MP5_CAMO_MP != SettingBufferCamoMP) {
                                SubmachineGuns.Default.MP5_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (SubmachineGuns.Default.MP5_CAMO_ZM != SettingBufferCamoZM) {
                                SubmachineGuns.Default.MP5_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (SubmachineGuns.Default.MP5_STATS_MP != SettingBufferStatsMP) {
                                SubmachineGuns.Default.MP5_STATS_MP = SettingBufferStatsMP;
                            }
                            if (SubmachineGuns.Default.MP5_STATS_ZM != SettingBufferStatsZM) {
                                SubmachineGuns.Default.MP5_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 1:
                            // MILANO821
                            System.Diagnostics.Debug.Print("Saving MILANO821");
                            if (SubmachineGuns.Default.MILANO821_LEVEL != txtWeaponLevel.Text) {
                                SubmachineGuns.Default.MILANO821_LEVEL = txtWeaponLevel.Text;
                            }
                            if (SubmachineGuns.Default.MILANO821_CAMO_MP != SettingBufferCamoMP) {
                                SubmachineGuns.Default.MILANO821_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (SubmachineGuns.Default.MILANO821_CAMO_ZM != SettingBufferCamoZM) {
                                SubmachineGuns.Default.MILANO821_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (SubmachineGuns.Default.MILANO821_STATS_MP != SettingBufferStatsMP) {
                                SubmachineGuns.Default.MILANO821_STATS_MP = SettingBufferStatsMP;
                            }
                            if (SubmachineGuns.Default.MILANO821_STATS_ZM != SettingBufferStatsZM) {
                                SubmachineGuns.Default.MILANO821_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 2:
                            // AK74U
                            System.Diagnostics.Debug.Print("Saving AK74U");
                            if (SubmachineGuns.Default.AK74U_LEVEL != txtWeaponLevel.Text) {
                                SubmachineGuns.Default.AK74U_LEVEL = txtWeaponLevel.Text;
                            }
                            if (SubmachineGuns.Default.AK74U_CAMO_MP != SettingBufferCamoMP) {
                                SubmachineGuns.Default.AK74U_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (SubmachineGuns.Default.AK74U_CAMO_ZM != SettingBufferCamoZM) {
                                SubmachineGuns.Default.AK74U_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (SubmachineGuns.Default.AK74U_STATS_MP != SettingBufferStatsMP) {
                                SubmachineGuns.Default.AK74U_STATS_MP = SettingBufferStatsMP;
                            }
                            if (SubmachineGuns.Default.AK74U_STATS_ZM != SettingBufferStatsZM) {
                                SubmachineGuns.Default.AK74U_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 3:
                            // KSP45
                            System.Diagnostics.Debug.Print("Saving KSP45");
                            if (SubmachineGuns.Default.KSP45_LEVEL != txtWeaponLevel.Text) {
                                SubmachineGuns.Default.KSP45_LEVEL = txtWeaponLevel.Text;
                            }
                            if (SubmachineGuns.Default.KSP45_CAMO_MP != SettingBufferCamoMP) {
                                SubmachineGuns.Default.KSP45_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (SubmachineGuns.Default.KSP45_CAMO_ZM != SettingBufferCamoZM) {
                                SubmachineGuns.Default.KSP45_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (SubmachineGuns.Default.KSP45_STATS_MP != SettingBufferStatsMP) {
                                SubmachineGuns.Default.KSP45_STATS_MP = SettingBufferStatsMP;
                            }
                            if (SubmachineGuns.Default.KSP45_STATS_ZM != SettingBufferStatsZM) {
                                SubmachineGuns.Default.KSP45_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 4:
                            // BULLFROG
                            System.Diagnostics.Debug.Print("Saving BULLFROG");
                            if (SubmachineGuns.Default.BULLFROG_LEVEL != txtWeaponLevel.Text) {
                                SubmachineGuns.Default.BULLFROG_LEVEL = txtWeaponLevel.Text;
                            }
                            if (SubmachineGuns.Default.BULLFROG_CAMO_MP != SettingBufferCamoMP) {
                                SubmachineGuns.Default.BULLFROG_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (SubmachineGuns.Default.BULLFROG_CAMO_ZM != SettingBufferCamoZM) {
                                SubmachineGuns.Default.BULLFROG_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (SubmachineGuns.Default.BULLFROG_STATS_MP != SettingBufferStatsMP) {
                                SubmachineGuns.Default.BULLFROG_STATS_MP = SettingBufferStatsMP;
                            }
                            if (SubmachineGuns.Default.BULLFROG_STATS_ZM != SettingBufferStatsZM) {
                                SubmachineGuns.Default.BULLFROG_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 5:
                            // MAC-10
                            System.Diagnostics.Debug.Print("Saving MAC10");
                            if (SubmachineGuns.Default.MAC10_LEVEL != txtWeaponLevel.Text) {
                                SubmachineGuns.Default.MAC10_LEVEL = txtWeaponLevel.Text;
                            }
                            if (SubmachineGuns.Default.MAC10_CAMO_MP != SettingBufferCamoMP) {
                                SubmachineGuns.Default.MAC10_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (SubmachineGuns.Default.MAC10_CAMO_ZM != SettingBufferCamoZM) {
                                SubmachineGuns.Default.MAC10_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (SubmachineGuns.Default.MAC10_STATS_MP != SettingBufferStatsMP) {
                                SubmachineGuns.Default.MAC10_STATS_MP = SettingBufferStatsMP;
                            }
                            if (SubmachineGuns.Default.MAC10_STATS_ZM != SettingBufferStatsZM) {
                                SubmachineGuns.Default.MAC10_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 6:
                            // LC10
                            System.Diagnostics.Debug.Print("Saving LC10");
                            if (SubmachineGuns.Default.LC10_LEVEL != txtWeaponLevel.Text) {
                                SubmachineGuns.Default.LC10_LEVEL = txtWeaponLevel.Text;
                            }
                            if (SubmachineGuns.Default.LC10_CAMO_MP != SettingBufferCamoMP) {
                                SubmachineGuns.Default.LC10_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (SubmachineGuns.Default.LC10_CAMO_ZM != SettingBufferCamoZM) {
                                SubmachineGuns.Default.LC10_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (SubmachineGuns.Default.LC10_STATS_MP != SettingBufferStatsMP) {
                                SubmachineGuns.Default.LC10_STATS_MP = SettingBufferStatsMP;
                            }
                            if (SubmachineGuns.Default.LC10_STATS_ZM != SettingBufferStatsZM) {
                                SubmachineGuns.Default.LC10_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                    }
                    SubmachineGuns.Default.Save();
                    break;
                #endregion
                #region Tactical Rifles
                case WeaponClass.TacticalRifle:
                    switch (SelectedWeapon) {
                        case 0:
                            // TYP63
                            System.Diagnostics.Debug.Print("Saving TYPE63");
                            if (TacticalRifles.Default.TYPE63_LEVEL != txtWeaponLevel.Text) {
                                TacticalRifles.Default.TYPE63_LEVEL = txtWeaponLevel.Text;
                            }
                            if (TacticalRifles.Default.TYPE63_CAMO_MP != SettingBufferCamoMP) {
                                TacticalRifles.Default.TYPE63_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (TacticalRifles.Default.TYPE63_CAMO_ZM != SettingBufferCamoZM) {
                                TacticalRifles.Default.TYPE63_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (TacticalRifles.Default.TYPE63_STATS_MP != SettingBufferStatsMP) {
                                TacticalRifles.Default.TYPE63_STATS_MP = SettingBufferStatsMP;
                            }
                            if (TacticalRifles.Default.TYPE63_STATS_ZM != SettingBufferStatsZM) {
                                TacticalRifles.Default.TYPE63_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 1:
                            // M16
                            System.Diagnostics.Debug.Print("Saving M16");
                            if (TacticalRifles.Default.M16_LEVEL != txtWeaponLevel.Text) {
                                TacticalRifles.Default.M16_LEVEL = txtWeaponLevel.Text;
                            }
                            if (TacticalRifles.Default.M16_CAMO_MP != SettingBufferCamoMP) {
                                TacticalRifles.Default.M16_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (TacticalRifles.Default.M16_CAMO_ZM != SettingBufferCamoZM) {
                                TacticalRifles.Default.M16_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (TacticalRifles.Default.M16_STATS_MP != SettingBufferStatsMP) {
                                TacticalRifles.Default.M16_STATS_MP = SettingBufferStatsMP;
                            }
                            if (TacticalRifles.Default.M16_STATS_ZM != SettingBufferStatsZM) {
                                TacticalRifles.Default.M16_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 2:
                            // AUG
                            System.Diagnostics.Debug.Print("Saving AUG");
                            if (TacticalRifles.Default.AUG_LEVEL != txtWeaponLevel.Text) {
                                TacticalRifles.Default.AUG_LEVEL = txtWeaponLevel.Text;
                            }
                            if (TacticalRifles.Default.AUG_CAMO_MP != SettingBufferCamoMP) {
                                TacticalRifles.Default.AUG_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (TacticalRifles.Default.AUG_CAMO_ZM != SettingBufferCamoZM) {
                                TacticalRifles.Default.AUG_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (TacticalRifles.Default.AUG_STATS_MP != SettingBufferStatsMP) {
                                TacticalRifles.Default.AUG_STATS_MP = SettingBufferStatsMP;
                            }
                            if (TacticalRifles.Default.AUG_STATS_ZM != SettingBufferStatsZM) {
                                TacticalRifles.Default.AUG_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 3:
                            // DMR14
                            System.Diagnostics.Debug.Print("Saving DMR14");
                            if (TacticalRifles.Default.DMR14_LEVEL != txtWeaponLevel.Text) {
                                TacticalRifles.Default.DMR14_LEVEL = txtWeaponLevel.Text;
                            }
                            if (TacticalRifles.Default.DMR14_CAMO_MP != SettingBufferCamoMP) {
                                TacticalRifles.Default.DMR14_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (TacticalRifles.Default.DMR14_CAMO_ZM != SettingBufferCamoZM) {
                                TacticalRifles.Default.DMR14_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (TacticalRifles.Default.DMR14_STATS_MP != SettingBufferStatsMP) {
                                TacticalRifles.Default.DMR14_STATS_MP = SettingBufferStatsMP;
                            }
                            if (TacticalRifles.Default.DMR14_STATS_ZM != SettingBufferStatsZM) {
                                TacticalRifles.Default.DMR14_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                    }
                    TacticalRifles.Default.Save();
                    break;
                #endregion
                #region Light Machine Guns
                case WeaponClass.LightMachineGun:
                    switch (SelectedWeapon) {
                        case 0:
                            // STONER63
                            System.Diagnostics.Debug.Print("Saving STONER63");
                            if (LightMachineGuns.Default.STONER63_LEVEL != txtWeaponLevel.Text) {
                                LightMachineGuns.Default.STONER63_LEVEL = txtWeaponLevel.Text;
                            }
                            if (LightMachineGuns.Default.STONER63_CAMO_MP != SettingBufferCamoMP) {
                                LightMachineGuns.Default.STONER63_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (LightMachineGuns.Default.STONER63_CAMO_ZM != SettingBufferCamoZM) {
                                LightMachineGuns.Default.STONER63_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (LightMachineGuns.Default.STONER63_STATS_MP != SettingBufferStatsMP) {
                                LightMachineGuns.Default.STONER63_STATS_MP = SettingBufferStatsMP;
                            }
                            if (LightMachineGuns.Default.STONER63_STATS_ZM != SettingBufferStatsZM) {
                                LightMachineGuns.Default.STONER63_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 1:
                            // RPD
                            System.Diagnostics.Debug.Print("Saving RPD");
                            if (LightMachineGuns.Default.RPD_LEVEL != txtWeaponLevel.Text) {
                                LightMachineGuns.Default.RPD_LEVEL = txtWeaponLevel.Text;
                            }
                            if (LightMachineGuns.Default.RPD_CAMO_MP != SettingBufferCamoMP) {
                                LightMachineGuns.Default.RPD_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (LightMachineGuns.Default.RPD_CAMO_ZM != SettingBufferCamoZM) {
                                LightMachineGuns.Default.RPD_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (LightMachineGuns.Default.RPD_STATS_MP != SettingBufferStatsMP) {
                                LightMachineGuns.Default.RPD_STATS_MP = SettingBufferStatsMP;
                            }
                            if (LightMachineGuns.Default.RPD_STATS_ZM != SettingBufferStatsZM) {
                                LightMachineGuns.Default.RPD_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 2:
                            // M60
                            System.Diagnostics.Debug.Print("Saving M60");
                            if (LightMachineGuns.Default.M60_LEVEL != txtWeaponLevel.Text) {
                                LightMachineGuns.Default.M60_LEVEL = txtWeaponLevel.Text;
                            }
                            if (LightMachineGuns.Default.M60_CAMO_MP != SettingBufferCamoMP) {
                                LightMachineGuns.Default.M60_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (LightMachineGuns.Default.M60_CAMO_ZM != SettingBufferCamoZM) {
                                LightMachineGuns.Default.M60_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (LightMachineGuns.Default.M60_STATS_MP != SettingBufferStatsMP) {
                                LightMachineGuns.Default.M60_STATS_MP = SettingBufferStatsMP;
                            }
                            if (LightMachineGuns.Default.M60_STATS_ZM != SettingBufferStatsZM) {
                                LightMachineGuns.Default.M60_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                    }
                    LightMachineGuns.Default.Save();
                    break;
                #endregion
                #region Sniper Rifles
                case WeaponClass.SniperRifle:
                    switch (SelectedWeapon) {
                        case 0:
                            // PELINGTON703
                            System.Diagnostics.Debug.Print("Saving PELINGTON703");
                            if (SniperRifles.Default.PELINGTON703_LEVEL != txtWeaponLevel.Text) {
                                SniperRifles.Default.PELINGTON703_LEVEL = txtWeaponLevel.Text;
                            }
                            if (SniperRifles.Default.PELINGTON703_CAMO_MP != SettingBufferCamoMP) {
                                SniperRifles.Default.PELINGTON703_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (SniperRifles.Default.PELINGTON703_CAMO_ZM != SettingBufferCamoZM) {
                                SniperRifles.Default.PELINGTON703_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (SniperRifles.Default.PELINGTON703_STATS_MP != SettingBufferStatsMP) {
                                SniperRifles.Default.PELINGTON703_STATS_MP = SettingBufferStatsMP;
                            }
                            if (SniperRifles.Default.PELINGTON703_STATS_ZM != SettingBufferStatsZM) {
                                SniperRifles.Default.PELINGTON703_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 1:
                            // LW3TUNDRA
                            System.Diagnostics.Debug.Print("Saving LW3TUNDRA");
                            if (SniperRifles.Default.LW3TUNDRA_LEVEL != txtWeaponLevel.Text) {
                                SniperRifles.Default.LW3TUNDRA_LEVEL = txtWeaponLevel.Text;
                            }
                            if (SniperRifles.Default.LW3TUNDRA_CAMO_MP != SettingBufferCamoMP) {
                                SniperRifles.Default.LW3TUNDRA_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (SniperRifles.Default.LW3TUNDRA_CAMO_ZM != SettingBufferCamoZM) {
                                SniperRifles.Default.LW3TUNDRA_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (SniperRifles.Default.LW3TUNDRA_STATS_MP != SettingBufferStatsMP) {
                                SniperRifles.Default.LW3TUNDRA_STATS_MP = SettingBufferStatsMP;
                            }
                            if (SniperRifles.Default.LW3TUNDRA_STATS_ZM != SettingBufferStatsZM) {
                                SniperRifles.Default.LW3TUNDRA_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 2:
                            // M82
                            System.Diagnostics.Debug.Print("Saving M82");
                            if (SniperRifles.Default.M82_LEVEL != txtWeaponLevel.Text) {
                                SniperRifles.Default.M82_LEVEL = txtWeaponLevel.Text;
                            }
                            if (SniperRifles.Default.M82_CAMO_MP != SettingBufferCamoMP) {
                                SniperRifles.Default.M82_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (SniperRifles.Default.M82_CAMO_ZM != SettingBufferCamoZM) {
                                SniperRifles.Default.M82_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (SniperRifles.Default.M82_STATS_MP != SettingBufferStatsMP) {
                                SniperRifles.Default.M82_STATS_MP = SettingBufferStatsMP;
                            }
                            if (SniperRifles.Default.M82_STATS_ZM != SettingBufferStatsZM) {
                                SniperRifles.Default.M82_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 3:
                            // ZRG20MM
                            System.Diagnostics.Debug.Print("Saving ZRG20MM");
                            if (SniperRifles.Default.ZRG20MM_LEVEL != txtWeaponLevel.Text) {
                                SniperRifles.Default.ZRG20MM_LEVEL = txtWeaponLevel.Text;
                            }
                            if (SniperRifles.Default.ZRG20MM_CAMO_MP != SettingBufferCamoMP) {
                                SniperRifles.Default.ZRG20MM_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (SniperRifles.Default.ZRG20MM_CAMO_ZM != SettingBufferCamoZM) {
                                SniperRifles.Default.ZRG20MM_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (SniperRifles.Default.ZRG20MM_STATS_MP != SettingBufferStatsMP) {
                                SniperRifles.Default.ZRG20MM_STATS_MP = SettingBufferStatsMP;
                            }
                            if (SniperRifles.Default.ZRG20MM_STATS_ZM != SettingBufferStatsZM) {
                                SniperRifles.Default.ZRG20MM_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                    }
                    SniperRifles.Default.Save();
                    break;
                #endregion
                #region Pistols
                case WeaponClass.Pistol:
                    switch (SelectedWeapon) {
                        case 0:
                            // M1911
                            System.Diagnostics.Debug.Print("Saving M1911");
                            if (Pistols.Default.M1911_LEVEL != txtWeaponLevel.Text) {
                                Pistols.Default.M1911_LEVEL = txtWeaponLevel.Text;
                            }
                            if (Pistols.Default.M1911_CAMO_MP != SettingBufferCamoMP) {
                                Pistols.Default.M1911_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (Pistols.Default.M1911_CAMO_ZM != SettingBufferCamoZM) {
                                Pistols.Default.M1911_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (Pistols.Default.M1911_STATS_MP != SettingBufferStatsMP) {
                                Pistols.Default.M1911_STATS_MP = SettingBufferStatsMP;
                            }
                            if (Pistols.Default.M1911_STATS_ZM != SettingBufferStatsZM) {
                                Pistols.Default.M1911_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 1:
                            // MAGNUM
                            System.Diagnostics.Debug.Print("Saving MAGNUM");
                            if (Pistols.Default.MAGNUM_LEVEL != txtWeaponLevel.Text) {
                                Pistols.Default.MAGNUM_LEVEL = txtWeaponLevel.Text;
                            }
                            if (Pistols.Default.MAGNUM_CAMO_MP != SettingBufferCamoMP) {
                                Pistols.Default.MAGNUM_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (Pistols.Default.MAGNUM_CAMO_ZM != SettingBufferCamoZM) {
                                Pistols.Default.MAGNUM_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (Pistols.Default.MAGNUM_STATS_MP != SettingBufferStatsMP) {
                                Pistols.Default.MAGNUM_STATS_MP = SettingBufferStatsMP;
                            }
                            if (Pistols.Default.MAGNUM_STATS_ZM != SettingBufferStatsZM) {
                                Pistols.Default.MAGNUM_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 2:
                            // DIAMATTI
                            System.Diagnostics.Debug.Print("Saving DIAMATTI");
                            if (Pistols.Default.DIAMATTI_LEVEL != txtWeaponLevel.Text) {
                                Pistols.Default.DIAMATTI_LEVEL = txtWeaponLevel.Text;
                            }
                            if (Pistols.Default.DIAMATTI_CAMO_MP != SettingBufferCamoMP) {
                                Pistols.Default.DIAMATTI_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (Pistols.Default.DIAMATTI_CAMO_ZM != SettingBufferCamoZM) {
                                Pistols.Default.DIAMATTI_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (Pistols.Default.DIAMATTI_STATS_MP != SettingBufferStatsMP) {
                                Pistols.Default.DIAMATTI_STATS_MP = SettingBufferStatsMP;
                            }
                            if (Pistols.Default.DIAMATTI_STATS_ZM != SettingBufferStatsZM) {
                                Pistols.Default.DIAMATTI_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                    }
                    Pistols.Default.Save();
                    break;
                #endregion
                #region Shotguns
                case WeaponClass.Shotgun:
                    switch (SelectedWeapon) {
                        case 0:
                            // HAUER77
                            System.Diagnostics.Debug.Print("Saving HAUER77");
                            if (Shotguns.Default.HAUER77_LEVEL != txtWeaponLevel.Text) {
                                Shotguns.Default.HAUER77_LEVEL = txtWeaponLevel.Text;
                            }
                            if (Shotguns.Default.HAUER77_CAMO_MP != SettingBufferCamoMP) {
                                Shotguns.Default.HAUER77_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (Shotguns.Default.HAUER77_CAMO_ZM != SettingBufferCamoZM) {
                                Shotguns.Default.HAUER77_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (Shotguns.Default.HAUER77_STATS_MP != SettingBufferStatsMP) {
                                Shotguns.Default.HAUER77_STATS_MP = SettingBufferStatsMP;
                            }
                            if (Shotguns.Default.HAUER77_STATS_ZM != SettingBufferStatsZM) {
                                Shotguns.Default.HAUER77_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 1:
                            // GALLOSA12
                            System.Diagnostics.Debug.Print("Saving GALLOSA12");
                            if (Shotguns.Default.GALLOSA12_LEVEL != txtWeaponLevel.Text) {
                                Shotguns.Default.GALLOSA12_LEVEL = txtWeaponLevel.Text;
                            }
                            if (Shotguns.Default.GALLOSA12_CAMO_MP != SettingBufferCamoMP) {
                                Shotguns.Default.GALLOSA12_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (Shotguns.Default.GALLOSA12_CAMO_ZM != SettingBufferCamoZM) {
                                Shotguns.Default.GALLOSA12_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (Shotguns.Default.GALLOSA12_STATS_MP != SettingBufferStatsMP) {
                                Shotguns.Default.GALLOSA12_STATS_MP = SettingBufferStatsMP;
                            }
                            if (Shotguns.Default.GALLOSA12_STATS_ZM != SettingBufferStatsZM) {
                                Shotguns.Default.GALLOSA12_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 2:
                            // STREETSWEEPER
                            System.Diagnostics.Debug.Print("Saving STREETSWEEPER");
                            if (Shotguns.Default.STREETSWEEPER_LEVEL != txtWeaponLevel.Text) {
                                Shotguns.Default.STREETSWEEPER_LEVEL = txtWeaponLevel.Text;
                            }
                            if (Shotguns.Default.STREETSWEEPER_CAMO_MP != SettingBufferCamoMP) {
                                Shotguns.Default.STREETSWEEPER_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (Shotguns.Default.STREETSWEEPER_CAMO_ZM != SettingBufferCamoZM) {
                                Shotguns.Default.STREETSWEEPER_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (Shotguns.Default.STREETSWEEPER_STATS_MP != SettingBufferStatsMP) {
                                Shotguns.Default.STREETSWEEPER_STATS_MP = SettingBufferStatsMP;
                            }
                            if (Shotguns.Default.STREETSWEEPER_STATS_ZM != SettingBufferStatsZM) {
                                Shotguns.Default.STREETSWEEPER_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                    }
                    Shotguns.Default.Save();
                    break;
                #endregion
                #region Rocket Launchers
                case WeaponClass.RocketLauncher:
                    switch (SelectedWeapon) {
                        case 0:
                            // CIGMA2
                            System.Diagnostics.Debug.Print("Saving CIGMA2");
                            if (RocketLaunchers.Default.CIGMA2_LEVEL != txtWeaponLevel.Text) {
                                RocketLaunchers.Default.CIGMA2_LEVEL = txtWeaponLevel.Text;
                            }
                            if (RocketLaunchers.Default.CIGMA2_CAMO_MP != SettingBufferCamoMP) {
                                RocketLaunchers.Default.CIGMA2_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (RocketLaunchers.Default.CIGMA2_CAMO_ZM != SettingBufferCamoZM) {
                                RocketLaunchers.Default.CIGMA2_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (RocketLaunchers.Default.CIGMA2_STATS_MP != SettingBufferStatsMP) {
                                RocketLaunchers.Default.CIGMA2_STATS_MP = SettingBufferStatsMP;
                            }
                            if (RocketLaunchers.Default.CIGMA2_STATS_ZM != SettingBufferStatsZM) {
                                RocketLaunchers.Default.CIGMA2_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 1:
                            // RPG7
                            System.Diagnostics.Debug.Print("Saving RPG7");
                            if (RocketLaunchers.Default.RPG7_LEVEL != txtWeaponLevel.Text) {
                                RocketLaunchers.Default.RPG7_LEVEL = txtWeaponLevel.Text;
                            }
                            if (RocketLaunchers.Default.RPG7_CAMO_MP != SettingBufferCamoMP) {
                                RocketLaunchers.Default.RPG7_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (RocketLaunchers.Default.RPG7_CAMO_ZM != SettingBufferCamoZM) {
                                RocketLaunchers.Default.RPG7_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (RocketLaunchers.Default.RPG7_STATS_MP != SettingBufferStatsMP) {
                                RocketLaunchers.Default.RPG7_STATS_MP = SettingBufferStatsMP;
                            }
                            if (RocketLaunchers.Default.RPG7_STATS_ZM != SettingBufferStatsZM) {
                                RocketLaunchers.Default.RPG7_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                    }
                    RocketLaunchers.Default.Save();
                    break;
                #endregion
                #region Specials
                case WeaponClass.Special:
                    switch (SelectedWeapon) {
                        case 0:
                            // KNIFE
                            System.Diagnostics.Debug.Print("Saving KNIFE");
                            if (Specials.Default.KNIFE_LEVEL != txtWeaponLevel.Text) {
                                Specials.Default.KNIFE_LEVEL = txtWeaponLevel.Text;
                            }
                            if (Specials.Default.KNIFE_CAMO_MP != SettingBufferCamoMP) {
                                Specials.Default.KNIFE_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (Specials.Default.KNIFE_CAMO_ZM != SettingBufferCamoZM) {
                                Specials.Default.KNIFE_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (Specials.Default.KNIFE_STATS_MP != SettingBufferStatsMP) {
                                Specials.Default.KNIFE_STATS_MP = SettingBufferStatsMP;
                            }
                            if (Specials.Default.KNIFE_STATS_ZM != SettingBufferStatsZM) {
                                Specials.Default.KNIFE_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 1:
                            // M79
                            System.Diagnostics.Debug.Print("Saving M79");
                            if (Specials.Default.M79_LEVEL != txtWeaponLevel.Text) {
                                Specials.Default.M79_LEVEL = txtWeaponLevel.Text;
                            }
                            if (Specials.Default.M79_CAMO_MP != SettingBufferCamoMP) {
                                Specials.Default.M79_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (Specials.Default.M79_CAMO_ZM != SettingBufferCamoZM) {
                                Specials.Default.M79_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (Specials.Default.M79_STATS_MP != SettingBufferStatsMP) {
                                Specials.Default.M79_STATS_MP = SettingBufferStatsMP;
                            }
                            if (Specials.Default.M79_STATS_ZM != SettingBufferStatsZM) {
                                Specials.Default.M79_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 2:
                            // SLEDGEHAMMER
                            System.Diagnostics.Debug.Print("Saving SLEDGEHAMMER");
                            if (Specials.Default.SLEDGEHAMMER_LEVEL != txtWeaponLevel.Text) {
                                Specials.Default.SLEDGEHAMMER_LEVEL = txtWeaponLevel.Text;
                            }
                            if (Specials.Default.SLEDGEHAMMER_CAMO_MP != SettingBufferCamoMP) {
                                Specials.Default.SLEDGEHAMMER_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (Specials.Default.SLEDGEHAMMER_CAMO_ZM != SettingBufferCamoZM) {
                                Specials.Default.SLEDGEHAMMER_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (Specials.Default.SLEDGEHAMMER_STATS_MP != SettingBufferStatsMP) {
                                Specials.Default.SLEDGEHAMMER_STATS_MP = SettingBufferStatsMP;
                            }
                            if (Specials.Default.SLEDGEHAMMER_STATS_ZM != SettingBufferStatsZM) {
                                Specials.Default.SLEDGEHAMMER_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 3:
                            // WAKIZASHI
                            System.Diagnostics.Debug.Print("Saving WAKIZASHI");
                            if (Specials.Default.WAKIZASHI_LEVEL != txtWeaponLevel.Text) {
                                Specials.Default.WAKIZASHI_LEVEL = txtWeaponLevel.Text;
                            }
                            if (Specials.Default.WAKIZASHI_CAMO_MP != SettingBufferCamoMP) {
                                Specials.Default.WAKIZASHI_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (Specials.Default.WAKIZASHI_CAMO_ZM != SettingBufferCamoZM) {
                                Specials.Default.WAKIZASHI_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (Specials.Default.WAKIZASHI_STATS_MP != SettingBufferStatsMP) {
                                Specials.Default.WAKIZASHI_STATS_MP = SettingBufferStatsMP;
                            }
                            if (Specials.Default.WAKIZASHI_STATS_ZM != SettingBufferStatsZM) {
                                Specials.Default.WAKIZASHI_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 4:
                            // MACHETE
                            System.Diagnostics.Debug.Print("Saving MACHETE");
                            if (Specials.Default.MACHETE_LEVEL != txtWeaponLevel.Text) {
                                Specials.Default.MACHETE_LEVEL = txtWeaponLevel.Text;
                            }
                            if (Specials.Default.MACHETE_CAMO_MP != SettingBufferCamoMP) {
                                Specials.Default.MACHETE_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (Specials.Default.MACHETE_CAMO_ZM != SettingBufferCamoZM) {
                                Specials.Default.MACHETE_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (Specials.Default.MACHETE_STATS_MP != SettingBufferStatsMP) {
                                Specials.Default.MACHETE_STATS_MP = SettingBufferStatsMP;
                            }
                            if (Specials.Default.MACHETE_STATS_ZM != SettingBufferStatsZM) {
                                Specials.Default.MACHETE_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 5:
                            // ETOOL
                            System.Diagnostics.Debug.Print("Saving ETOOL");
                            if (Specials.Default.ETOOL_LEVEL != txtWeaponLevel.Text) {
                                Specials.Default.ETOOL_LEVEL = txtWeaponLevel.Text;
                            }
                            if (Specials.Default.ETOOL_CAMO_MP != SettingBufferCamoMP) {
                                Specials.Default.ETOOL_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (Specials.Default.ETOOL_CAMO_ZM != SettingBufferCamoZM) {
                                Specials.Default.ETOOL_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (Specials.Default.ETOOL_STATS_MP != SettingBufferStatsMP) {
                                Specials.Default.ETOOL_STATS_MP = SettingBufferStatsMP;
                            }
                            if (Specials.Default.ETOOL_STATS_ZM != SettingBufferStatsZM) {
                                Specials.Default.ETOOL_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                        case 6:
                            // R1SHADOWHUNTER
                            System.Diagnostics.Debug.Print("Saving R1SHADOWHUNTER");
                            if (Specials.Default.R1SHADOWHUNTER_LEVEL != txtWeaponLevel.Text) {
                                Specials.Default.R1SHADOWHUNTER_LEVEL = txtWeaponLevel.Text;
                            }
                            if (Specials.Default.R1SHADOWHUNTER_CAMO_MP != SettingBufferCamoMP) {
                                Specials.Default.R1SHADOWHUNTER_CAMO_MP = SettingBufferCamoMP;
                            }
                            if (Specials.Default.R1SHADOWHUNTER_CAMO_ZM != SettingBufferCamoZM) {
                                Specials.Default.R1SHADOWHUNTER_CAMO_ZM = SettingBufferCamoZM;
                            }
                            if (Specials.Default.R1SHADOWHUNTER_STATS_MP != SettingBufferStatsMP) {
                                Specials.Default.R1SHADOWHUNTER_STATS_MP = SettingBufferStatsMP;
                            }
                            if (Specials.Default.R1SHADOWHUNTER_STATS_ZM != SettingBufferStatsZM) {
                                Specials.Default.R1SHADOWHUNTER_STATS_ZM = SettingBufferStatsZM;
                            }
                            break;
                    }
                    Specials.Default.Save();
                    break;
                #endregion
            }

            WeaponModified = false;
        }
        private void LoadWeapon() {
            #region Don't load if...
            if (SelectedClass == WeaponClass.None && SelectedWeapon == -1) {
                return;
            }
            #endregion

            for (int i = 0; i < lvMultiplayerCamo.Items.Count; i++) {
                lvMultiplayerCamo.Items[0].Checked = false;
                lvZombieCamo.Items[0].Checked = false;
            }

            txtWeaponLevel.Text = "1";
            txtTier0MP.Text = "0";
            txtTier1MP.Text = "0";
            txtTier2MP.Text = "0";
            txtTier3MP.Text = "0";
            txtTier4MP.Text = "0";
            txtTier5MP.Text = "0";
            txtTier6MP.Text = "0";
            txtTier0ZM.Text = "0";
            txtTier1ZM.Text = "0";
            txtTier2ZM.Text = "0";
            txtTier3ZM.Text = "0";
            txtTier4ZM.Text = "0";
            txtTier5ZM.Text = "0";
            txtTier6ZM.Text = "0";

            string ReadSettingCamoMP = string.Empty;
            string ReadSettingCamoZM = string.Empty;
            string[] ReadSettingStatsMP = { };
            string[] ReadSettingStatsZM = { };
            string ReadSettingLevel = string.Empty;

            string WeaponName = string.Empty;

            switch (SelectedClass) {
                #region AssaultRifles
                case WeaponClass.AssaultRifle:
                    switch (SelectedWeapon) {
                        case 0:
                            // XM4
                            System.Diagnostics.Debug.Print("Loading XM4");
                            ReadSettingCamoMP = AssaultRifles.Default.XM4_CAMO_MP;
                            ReadSettingCamoZM = AssaultRifles.Default.XM4_CAMO_ZM;
                            ReadSettingStatsMP = AssaultRifles.Default.XM4_STATS_MP.Split(',');
                            ReadSettingStatsZM = AssaultRifles.Default.XM4_STATS_ZM.Split(',');
                            ReadSettingLevel = AssaultRifles.Default.XM4_LEVEL;

                            WeaponName = "XM4";
                            break;
                        case 1:
                            // AK47
                            System.Diagnostics.Debug.Print("Loading AK47");
                            ReadSettingCamoMP = AssaultRifles.Default.AK47_CAMO_MP;
                            ReadSettingCamoZM = AssaultRifles.Default.AK47_CAMO_ZM;
                            ReadSettingStatsMP = AssaultRifles.Default.AK47_STATS_MP.Split(',');
                            ReadSettingStatsZM = AssaultRifles.Default.AK47_STATS_ZM.Split(',');
                            ReadSettingLevel = AssaultRifles.Default.AK47_LEVEL;

                            WeaponName = "AK-47";
                            break;
                        case 2:
                            // KRIG6
                            System.Diagnostics.Debug.Print("Loading KRIG6");
                            ReadSettingCamoMP = AssaultRifles.Default.KRIG6_CAMO_MP;
                            ReadSettingCamoZM = AssaultRifles.Default.KRIG6_CAMO_ZM;
                            ReadSettingStatsMP = AssaultRifles.Default.KRIG6_STATS_MP.Split(',');
                            ReadSettingStatsZM = AssaultRifles.Default.KRIG6_STATS_ZM.Split(',');
                            ReadSettingLevel = AssaultRifles.Default.KRIG6_LEVEL;

                            WeaponName = "Krig 6";
                            break;
                        case 3:
                            // QBZ83
                            System.Diagnostics.Debug.Print("Loading QBZ83");
                            ReadSettingCamoMP = AssaultRifles.Default.QBZ83_CAMO_MP;
                            ReadSettingCamoZM = AssaultRifles.Default.QBZ83_CAMO_ZM;
                            ReadSettingStatsMP = AssaultRifles.Default.QBZ83_STATS_MP.Split(',');
                            ReadSettingStatsZM = AssaultRifles.Default.QBZ83_STATS_ZM.Split(',');
                            ReadSettingLevel = AssaultRifles.Default.QBZ83_LEVEL;

                            WeaponName = "QBZ-83";
                            break;
                        case 4:
                            // FFAR1
                            System.Diagnostics.Debug.Print("Loading FFAR1");
                            ReadSettingCamoMP = AssaultRifles.Default.FFAR1_CAMO_MP;
                            ReadSettingCamoZM = AssaultRifles.Default.FFAR1_CAMO_ZM;
                            ReadSettingStatsMP = AssaultRifles.Default.FFAR1_STATS_MP.Split(',');
                            ReadSettingStatsZM = AssaultRifles.Default.FFAR1_STATS_ZM.Split(',');
                            ReadSettingLevel = AssaultRifles.Default.FFAR1_LEVEL;

                            WeaponName = "FFAR 1";
                            break;
                        case 5:
                            // GROZA
                            System.Diagnostics.Debug.Print("Loading GROZA");
                            ReadSettingCamoMP = AssaultRifles.Default.GROZA_CAMO_MP;
                            ReadSettingCamoZM = AssaultRifles.Default.GROZA_CAMO_ZM;
                            ReadSettingStatsMP = AssaultRifles.Default.GROZA_STATS_MP.Split(',');
                            ReadSettingStatsZM = AssaultRifles.Default.GROZA_STATS_ZM.Split(',');
                            ReadSettingLevel = AssaultRifles.Default.GROZA_LEVEL;

                            WeaponName = "Groza";
                            break;
                        case 6:
                            // FARA83
                            System.Diagnostics.Debug.Print("Loading FARA83");
                            ReadSettingCamoMP = AssaultRifles.Default.FARA83_CAMO_MP;
                            ReadSettingCamoZM = AssaultRifles.Default.FARA83_CAMO_ZM;
                            ReadSettingStatsMP = AssaultRifles.Default.FARA83_STATS_MP.Split(',');
                            ReadSettingStatsZM = AssaultRifles.Default.FARA83_STATS_ZM.Split(',');
                            ReadSettingLevel = AssaultRifles.Default.FARA83_LEVEL;

                            WeaponName = "FARA 83";
                            break;
                    }
                    break;
                #endregion
                #region SubmachineGuns
                case WeaponClass.SubmachineGun:
                    switch (SelectedWeapon) {
                        case 0:
                            // MP5
                            System.Diagnostics.Debug.Print("Loading MP5");
                            ReadSettingCamoMP = SubmachineGuns.Default.MP5_CAMO_MP;
                            ReadSettingCamoZM = SubmachineGuns.Default.MP5_CAMO_ZM;
                            ReadSettingStatsMP = SubmachineGuns.Default.MP5_STATS_MP.Split(',');
                            ReadSettingStatsZM = SubmachineGuns.Default.MP5_STATS_ZM.Split(',');
                            ReadSettingLevel = SubmachineGuns.Default.MP5_LEVEL;

                            WeaponName = "MP5";
                            break;
                        case 1:
                            // MILANO821
                            System.Diagnostics.Debug.Print("Loading MILANO821");
                            ReadSettingCamoMP = SubmachineGuns.Default.MILANO821_CAMO_MP;
                            ReadSettingCamoZM = SubmachineGuns.Default.MILANO821_CAMO_ZM;
                            ReadSettingStatsMP = SubmachineGuns.Default.MILANO821_STATS_MP.Split(',');
                            ReadSettingStatsZM = SubmachineGuns.Default.MILANO821_STATS_ZM.Split(',');
                            ReadSettingLevel = SubmachineGuns.Default.MILANO821_LEVEL;

                            WeaponName = "Milano 821";
                            break;
                        case 2:
                            // AK74U
                            System.Diagnostics.Debug.Print("Loading AK74U");
                            ReadSettingCamoMP = SubmachineGuns.Default.AK74U_CAMO_MP;
                            ReadSettingCamoZM = SubmachineGuns.Default.AK74U_CAMO_ZM;
                            ReadSettingStatsMP = SubmachineGuns.Default.AK74U_STATS_MP.Split(',');
                            ReadSettingStatsZM = SubmachineGuns.Default.AK74U_STATS_ZM.Split(',');
                            ReadSettingLevel = SubmachineGuns.Default.AK74U_LEVEL;

                            WeaponName = "AK-74u";
                            break;
                        case 3:
                            // KSP45
                            System.Diagnostics.Debug.Print("Loading KSP45");
                            ReadSettingCamoMP = SubmachineGuns.Default.KSP45_CAMO_MP;
                            ReadSettingCamoZM = SubmachineGuns.Default.KSP45_CAMO_ZM;
                            ReadSettingStatsMP = SubmachineGuns.Default.KSP45_STATS_MP.Split(',');
                            ReadSettingStatsZM = SubmachineGuns.Default.KSP45_STATS_ZM.Split(',');
                            ReadSettingLevel = SubmachineGuns.Default.KSP45_LEVEL;

                            WeaponName = "KSP 45";
                            break;
                        case 4:
                            // BULLFROG
                            System.Diagnostics.Debug.Print("Loading BULLFROG");
                            ReadSettingCamoMP = SubmachineGuns.Default.BULLFROG_CAMO_MP;
                            ReadSettingCamoZM = SubmachineGuns.Default.BULLFROG_CAMO_ZM;
                            ReadSettingStatsMP = SubmachineGuns.Default.BULLFROG_STATS_MP.Split(',');
                            ReadSettingStatsZM = SubmachineGuns.Default.BULLFROG_STATS_ZM.Split(',');
                            ReadSettingLevel = SubmachineGuns.Default.BULLFROG_LEVEL;

                            WeaponName = "Bullfrog";
                            break;
                        case 5:
                            // MAC10
                            System.Diagnostics.Debug.Print("Loading MAC10");
                            ReadSettingCamoMP = SubmachineGuns.Default.MAC10_CAMO_MP;
                            ReadSettingCamoZM = SubmachineGuns.Default.MAC10_CAMO_ZM;
                            ReadSettingStatsMP = SubmachineGuns.Default.MAC10_STATS_MP.Split(',');
                            ReadSettingStatsZM = SubmachineGuns.Default.MAC10_STATS_ZM.Split(',');
                            ReadSettingLevel = SubmachineGuns.Default.MAC10_LEVEL;

                            WeaponName = "MAC-10";
                            break;
                        case 6:
                            // LC10
                            System.Diagnostics.Debug.Print("Loading LC10");
                            ReadSettingCamoMP = SubmachineGuns.Default.LC10_CAMO_MP;
                            ReadSettingCamoZM = SubmachineGuns.Default.LC10_CAMO_ZM;
                            ReadSettingStatsMP = SubmachineGuns.Default.LC10_STATS_MP.Split(',');
                            ReadSettingStatsZM = SubmachineGuns.Default.LC10_STATS_ZM.Split(',');
                            ReadSettingLevel = SubmachineGuns.Default.LC10_LEVEL;

                            WeaponName = "LC10";
                            break;
                    }
                    break;
                #endregion
                #region TacticalRifles
                case WeaponClass.TacticalRifle:
                    switch (SelectedWeapon) {
                        case 0:
                            // TYPE63
                            System.Diagnostics.Debug.Print("Loading TYPE63");
                            ReadSettingCamoMP = TacticalRifles.Default.TYPE63_CAMO_MP;
                            ReadSettingCamoZM = TacticalRifles.Default.TYPE63_CAMO_ZM;
                            ReadSettingStatsMP = TacticalRifles.Default.TYPE63_STATS_MP.Split(',');
                            ReadSettingStatsZM = TacticalRifles.Default.TYPE63_STATS_ZM.Split(',');
                            ReadSettingLevel = TacticalRifles.Default.TYPE63_LEVEL;

                            WeaponName = "Type 63";
                            break;
                        case 1:
                            // M16
                            System.Diagnostics.Debug.Print("Loading M16");
                            ReadSettingCamoMP = TacticalRifles.Default.M16_CAMO_MP;
                            ReadSettingCamoZM = TacticalRifles.Default.M16_CAMO_ZM;
                            ReadSettingStatsMP = TacticalRifles.Default.M16_STATS_MP.Split(',');
                            ReadSettingStatsZM = TacticalRifles.Default.M16_STATS_ZM.Split(',');
                            ReadSettingLevel = TacticalRifles.Default.M16_LEVEL;

                            WeaponName = "M16";
                            break;
                        case 2:
                            // AUG
                            System.Diagnostics.Debug.Print("Loading AUG");
                            ReadSettingCamoMP = TacticalRifles.Default.AUG_CAMO_MP;
                            ReadSettingCamoZM = TacticalRifles.Default.AUG_CAMO_ZM;
                            ReadSettingStatsMP = TacticalRifles.Default.AUG_STATS_MP.Split(',');
                            ReadSettingStatsZM = TacticalRifles.Default.AUG_STATS_ZM.Split(',');
                            ReadSettingLevel = TacticalRifles.Default.AUG_LEVEL;

                            WeaponName = "AUG";
                            break;
                        case 3:
                            // DMR14
                            System.Diagnostics.Debug.Print("Loading DMR14");
                            ReadSettingCamoMP = TacticalRifles.Default.DMR14_CAMO_MP;
                            ReadSettingCamoZM = TacticalRifles.Default.DMR14_CAMO_ZM;
                            ReadSettingStatsMP = TacticalRifles.Default.DMR14_STATS_MP.Split(',');
                            ReadSettingStatsZM = TacticalRifles.Default.DMR14_STATS_ZM.Split(',');
                            ReadSettingLevel = TacticalRifles.Default.DMR14_LEVEL;

                            WeaponName = "DMR-14";
                            break;
                    }
                    break;
                #endregion
                #region LightMachineGuns
                case WeaponClass.LightMachineGun:
                    switch (SelectedWeapon) {
                        case 0:
                            // STONER63
                            System.Diagnostics.Debug.Print("Loading STONER63");
                            ReadSettingCamoMP = LightMachineGuns.Default.STONER63_CAMO_MP;
                            ReadSettingCamoZM = LightMachineGuns.Default.STONER63_CAMO_ZM;
                            ReadSettingStatsMP = LightMachineGuns.Default.STONER63_STATS_MP.Split(',');
                            ReadSettingStatsZM = LightMachineGuns.Default.STONER63_STATS_ZM.Split(',');
                            ReadSettingLevel = LightMachineGuns.Default.STONER63_LEVEL;

                            WeaponName = "Stoner63";
                            break;
                        case 1:
                            // RPD
                            System.Diagnostics.Debug.Print("Loading RPD");
                            ReadSettingCamoMP = LightMachineGuns.Default.RPD_CAMO_MP;
                            ReadSettingCamoZM = LightMachineGuns.Default.RPD_CAMO_ZM;
                            ReadSettingStatsMP = LightMachineGuns.Default.RPD_STATS_MP.Split(',');
                            ReadSettingStatsZM = LightMachineGuns.Default.RPD_STATS_ZM.Split(',');
                            ReadSettingLevel = LightMachineGuns.Default.RPD_LEVEL;

                            WeaponName = "RPD";
                            break;
                        case 2:
                            // M60
                            System.Diagnostics.Debug.Print("Loading M60");
                            ReadSettingCamoMP = LightMachineGuns.Default.M60_CAMO_MP;
                            ReadSettingCamoZM = LightMachineGuns.Default.M60_CAMO_ZM;
                            ReadSettingStatsMP = LightMachineGuns.Default.M60_STATS_MP.Split(',');
                            ReadSettingStatsZM = LightMachineGuns.Default.M60_STATS_ZM.Split(',');
                            ReadSettingLevel = LightMachineGuns.Default.M60_LEVEL;

                            WeaponName = "M60";
                            break;
                    }
                    break;
                #endregion
                #region SniperRifles
                case WeaponClass.SniperRifle:
                    switch (SelectedWeapon) {
                        case 0:
                            // PELINGTON703
                            System.Diagnostics.Debug.Print("Loading PELINGTON703");
                            ReadSettingCamoMP = SniperRifles.Default.PELINGTON703_CAMO_MP;
                            ReadSettingCamoZM = SniperRifles.Default.PELINGTON703_CAMO_ZM;
                            ReadSettingStatsMP = SniperRifles.Default.PELINGTON703_STATS_MP.Split(',');
                            ReadSettingStatsZM = SniperRifles.Default.PELINGTON703_STATS_ZM.Split(',');
                            ReadSettingLevel = SniperRifles.Default.PELINGTON703_LEVEL;

                            WeaponName = "Pelington 703";
                            break;
                        case 1:
                            // LW3TUNDRA
                            System.Diagnostics.Debug.Print("Loading LW3TUNDRA");
                            ReadSettingCamoMP = SniperRifles.Default.LW3TUNDRA_CAMO_MP;
                            ReadSettingCamoZM = SniperRifles.Default.LW3TUNDRA_CAMO_ZM;
                            ReadSettingStatsMP = SniperRifles.Default.LW3TUNDRA_STATS_MP.Split(',');
                            ReadSettingStatsZM = SniperRifles.Default.LW3TUNDRA_STATS_ZM.Split(',');
                            ReadSettingLevel = SniperRifles.Default.LW3TUNDRA_LEVEL;

                            WeaponName = "LW3 - Tundra";
                            break;
                        case 2:
                            // M82
                            System.Diagnostics.Debug.Print("Loading M82");
                            ReadSettingCamoMP = SniperRifles.Default.M82_CAMO_MP;
                            ReadSettingCamoZM = SniperRifles.Default.M82_CAMO_ZM;
                            ReadSettingStatsMP = SniperRifles.Default.M82_STATS_MP.Split(',');
                            ReadSettingStatsZM = SniperRifles.Default.M82_STATS_ZM.Split(',');
                            ReadSettingLevel = SniperRifles.Default.M82_LEVEL;

                            WeaponName = "M82";
                            break;
                        case 3:
                            // ZRG20MM
                            System.Diagnostics.Debug.Print("Loading ZRG20MM");
                            ReadSettingCamoMP = SniperRifles.Default.ZRG20MM_CAMO_MP;
                            ReadSettingCamoZM = SniperRifles.Default.ZRG20MM_CAMO_ZM;
                            ReadSettingStatsMP = SniperRifles.Default.ZRG20MM_STATS_MP.Split(',');
                            ReadSettingStatsZM = SniperRifles.Default.ZRG20MM_STATS_ZM.Split(',');
                            ReadSettingLevel = SniperRifles.Default.ZRG20MM_LEVEL;

                            WeaponName = "ZRG 20mm";
                            break;
                    }
                    break;
                #endregion
                #region Pistols
                case WeaponClass.Pistol:
                    switch (SelectedWeapon) {
                        case 0:
                            // M1911
                            System.Diagnostics.Debug.Print("Loading M1911");
                            ReadSettingCamoMP = Pistols.Default.M1911_CAMO_MP;
                            ReadSettingCamoZM = Pistols.Default.M1911_CAMO_ZM;
                            ReadSettingStatsMP = Pistols.Default.M1911_STATS_MP.Split(',');
                            ReadSettingStatsZM = Pistols.Default.M1911_STATS_ZM.Split(',');
                            ReadSettingLevel = Pistols.Default.M1911_LEVEL;

                            WeaponName = "1911";
                            break;
                        case 1:
                            // MAGNUM
                            System.Diagnostics.Debug.Print("Loading MAGNUM");
                            ReadSettingCamoMP = Pistols.Default.MAGNUM_CAMO_MP;
                            ReadSettingCamoZM = Pistols.Default.MAGNUM_CAMO_ZM;
                            ReadSettingStatsMP = Pistols.Default.MAGNUM_STATS_MP.Split(',');
                            ReadSettingStatsZM = Pistols.Default.MAGNUM_STATS_ZM.Split(',');
                            ReadSettingLevel = Pistols.Default.MAGNUM_LEVEL;

                            WeaponName = "Magnum";
                            break;
                        case 2:
                            // DIAMATTI
                            System.Diagnostics.Debug.Print("Loading DIAMATTI");
                            ReadSettingCamoMP = Pistols.Default.DIAMATTI_CAMO_MP;
                            ReadSettingCamoZM = Pistols.Default.DIAMATTI_CAMO_ZM;
                            ReadSettingStatsMP = Pistols.Default.DIAMATTI_STATS_MP.Split(',');
                            ReadSettingStatsZM = Pistols.Default.DIAMATTI_STATS_ZM.Split(',');
                            ReadSettingLevel = Pistols.Default.DIAMATTI_LEVEL;

                            WeaponName = "Diamatti";
                            break;
                    }
                    break;
                #endregion
                #region Shotguns
                case WeaponClass.Shotgun:
                    switch (SelectedWeapon) {
                        case 0:
                            // HAUER77
                            System.Diagnostics.Debug.Print("Loading HAUER77");
                            ReadSettingCamoMP = Shotguns.Default.HAUER77_CAMO_MP;
                            ReadSettingCamoZM = Shotguns.Default.HAUER77_CAMO_ZM;
                            ReadSettingStatsMP = Shotguns.Default.HAUER77_STATS_MP.Split(',');
                            ReadSettingStatsZM = Shotguns.Default.HAUER77_STATS_ZM.Split(',');
                            ReadSettingLevel = Shotguns.Default.HAUER77_LEVEL;

                            WeaponName = "Hauer 77";
                            break;
                        case 1:
                            // GALLOSA12
                            System.Diagnostics.Debug.Print("Loading GALLOSA12");
                            ReadSettingCamoMP = Shotguns.Default.GALLOSA12_CAMO_MP;
                            ReadSettingCamoZM = Shotguns.Default.GALLOSA12_CAMO_ZM;
                            ReadSettingStatsMP = Shotguns.Default.GALLOSA12_STATS_MP.Split(',');
                            ReadSettingStatsZM = Shotguns.Default.GALLOSA12_STATS_ZM.Split(',');
                            ReadSettingLevel = Shotguns.Default.GALLOSA12_LEVEL;

                            WeaponName = "Gallo SA12";
                            break;
                        case 2:
                            // STREETSWEEPER
                            System.Diagnostics.Debug.Print("Loading STREETSWEEPER");
                            ReadSettingCamoMP = Shotguns.Default.STREETSWEEPER_CAMO_MP;
                            ReadSettingCamoZM = Shotguns.Default.STREETSWEEPER_CAMO_ZM;
                            ReadSettingStatsMP = Shotguns.Default.STREETSWEEPER_STATS_MP.Split(',');
                            ReadSettingStatsZM = Shotguns.Default.STREETSWEEPER_STATS_ZM.Split(',');
                            ReadSettingLevel = Shotguns.Default.STREETSWEEPER_LEVEL;

                            WeaponName = "Streetsweeper";
                            break;
                    }
                    break;
                #endregion
                #region RocketLaunchers
                case WeaponClass.RocketLauncher:
                    switch (SelectedWeapon) {
                        case 0:
                            // CIGMA2
                            System.Diagnostics.Debug.Print("Loading CIGMA2");
                            ReadSettingCamoMP = RocketLaunchers.Default.CIGMA2_CAMO_MP;
                            ReadSettingCamoZM = RocketLaunchers.Default.CIGMA2_CAMO_ZM;
                            ReadSettingStatsMP = RocketLaunchers.Default.CIGMA2_STATS_MP.Split(',');
                            ReadSettingStatsZM = RocketLaunchers.Default.CIGMA2_STATS_ZM.Split(',');
                            ReadSettingLevel = RocketLaunchers.Default.CIGMA2_LEVEL;

                            WeaponName = "Cigma 2";
                            break;
                        case 1:
                            // RPG7
                            System.Diagnostics.Debug.Print("Loading RPG7");
                            ReadSettingCamoMP = RocketLaunchers.Default.RPG7_CAMO_MP;
                            ReadSettingCamoZM = RocketLaunchers.Default.RPG7_CAMO_ZM;
                            ReadSettingStatsMP = RocketLaunchers.Default.RPG7_STATS_MP.Split(',');
                            ReadSettingStatsZM = RocketLaunchers.Default.RPG7_STATS_ZM.Split(',');
                            ReadSettingLevel = RocketLaunchers.Default.RPG7_LEVEL;

                            WeaponName = "RPG-7";
                            break;
                    }
                    break;
                #endregion
                #region Specials
                case WeaponClass.Special:
                    switch (SelectedWeapon) {
                        case 0:
                            // KNIFE
                            System.Diagnostics.Debug.Print("Loading KNIFE");
                            ReadSettingCamoMP = Specials.Default.KNIFE_CAMO_MP;
                            ReadSettingCamoZM = Specials.Default.KNIFE_CAMO_ZM;
                            ReadSettingStatsMP = Specials.Default.KNIFE_STATS_MP.Split(',');
                            ReadSettingStatsZM = Specials.Default.KNIFE_STATS_ZM.Split(',');
                            ReadSettingLevel = Specials.Default.KNIFE_LEVEL;

                            WeaponName = "Knife";
                            break;
                        case 1:
                            // M79
                            System.Diagnostics.Debug.Print("Loading M79");
                            ReadSettingCamoMP = Specials.Default.M79_CAMO_MP;
                            ReadSettingCamoZM = Specials.Default.M79_CAMO_ZM;
                            ReadSettingStatsMP = Specials.Default.M79_STATS_MP.Split(',');
                            ReadSettingStatsZM = Specials.Default.M79_STATS_ZM.Split(',');
                            ReadSettingLevel = Specials.Default.M79_LEVEL;

                            WeaponName = "M79";
                            break;
                        case 2:
                            // SLEDGEHAMMER
                            System.Diagnostics.Debug.Print("Loading SLEDGEHAMMER");
                            ReadSettingCamoMP = Specials.Default.SLEDGEHAMMER_CAMO_MP;
                            ReadSettingCamoZM = Specials.Default.SLEDGEHAMMER_CAMO_ZM;
                            ReadSettingStatsMP = Specials.Default.SLEDGEHAMMER_STATS_MP.Split(',');
                            ReadSettingStatsZM = Specials.Default.SLEDGEHAMMER_STATS_ZM.Split(',');
                            ReadSettingLevel = Specials.Default.SLEDGEHAMMER_LEVEL;

                            WeaponName = "Sledgehammer";
                            break;
                        case 3:
                            // WAKIZASHI
                            System.Diagnostics.Debug.Print("Loading WAKIZASHI");
                            ReadSettingCamoMP = Specials.Default.WAKIZASHI_CAMO_MP;
                            ReadSettingCamoZM = Specials.Default.WAKIZASHI_CAMO_ZM;
                            ReadSettingStatsMP = Specials.Default.WAKIZASHI_STATS_MP.Split(',');
                            ReadSettingStatsZM = Specials.Default.WAKIZASHI_STATS_ZM.Split(',');
                            ReadSettingLevel = Specials.Default.WAKIZASHI_LEVEL;

                            WeaponName = "Wakizashi";
                            break;
                        case 4:
                            // MACHETE
                            System.Diagnostics.Debug.Print("Loading MACHETE");
                            ReadSettingCamoMP = Specials.Default.MACHETE_CAMO_MP;
                            ReadSettingCamoZM = Specials.Default.MACHETE_CAMO_ZM;
                            ReadSettingStatsMP = Specials.Default.MACHETE_STATS_MP.Split(',');
                            ReadSettingStatsZM = Specials.Default.MACHETE_STATS_ZM.Split(',');
                            ReadSettingLevel = Specials.Default.MACHETE_LEVEL;

                            WeaponName = "Machete";
                            break;
                        case 5:
                            // ETOOL
                            System.Diagnostics.Debug.Print("Loading ETOOL");
                            ReadSettingCamoMP = Specials.Default.ETOOL_CAMO_MP;
                            ReadSettingCamoZM = Specials.Default.ETOOL_CAMO_ZM;
                            ReadSettingStatsMP = Specials.Default.ETOOL_STATS_MP.Split(',');
                            ReadSettingStatsZM = Specials.Default.ETOOL_STATS_ZM.Split(',');
                            ReadSettingLevel = Specials.Default.ETOOL_LEVEL;

                            WeaponName = "E-Tool";
                            break;
                        case 6:
                            // R1SHADOWHUNTER
                            System.Diagnostics.Debug.Print("Loading R1SHADOWHUNTER");
                            ReadSettingCamoMP = Specials.Default.R1SHADOWHUNTER_CAMO_MP;
                            ReadSettingCamoZM = Specials.Default.R1SHADOWHUNTER_CAMO_ZM;
                            ReadSettingStatsMP = Specials.Default.R1SHADOWHUNTER_STATS_MP.Split(',');
                            ReadSettingStatsZM = Specials.Default.R1SHADOWHUNTER_STATS_ZM.Split(',');
                            ReadSettingLevel = Specials.Default.R1SHADOWHUNTER_LEVEL;

                            WeaponName = "R1 Shadowhunter";
                            break;
                    }
                    break;
                #endregion
            }

            LoadingCamos = true;

            if (ReadSettingCamoMP.StartsWith(DefaultCamo) && ReadSettingCamoZM.StartsWith(DefaultCamo)) {
                lbIsGold.Text = WeaponName + " is Not Gold";
                lbIsGoldenViper.Text = WeaponName + " is Not Golden Viper";
                return;
            }

            if (ReadSettingCamoMP.StartsWith(CompleteCamo)) {
                lbIsGold.Text = WeaponName + " is Gold";
            }
            else {
                lbIsGold.Text = WeaponName + " is Not Gold";
            }
            if (ReadSettingCamoZM.StartsWith(CompleteCamo)) {
                lbIsGoldenViper.Text = WeaponName + " is Golden Viper";
            }
            else {
                lbIsGoldenViper.Text = WeaponName + " is Not Golden Viper";
            }

            for (int i = 0; i < ReadSettingCamoMP.Length; i++) {
                if (ReadSettingCamoMP[i] == '1') {
                    lvMultiplayerCamo.Items[i].Checked = true;
                }
                else {
                    lvMultiplayerCamo.Items[i].Checked = false;
                }

                if (ReadSettingCamoZM[i] == '1') {
                    lvZombieCamo.Items[i].Checked = true;
                }
                else {
                    lvZombieCamo.Items[i].Checked = false;
                }
            }

            if (ReadSettingStatsMP.Length == 7) {
                txtTier0MP.Text = ReadSettingStatsMP[0];
                txtTier1MP.Text = ReadSettingStatsMP[1];
                txtTier2MP.Text = ReadSettingStatsMP[2];
                txtTier3MP.Text = ReadSettingStatsMP[3];
                txtTier4MP.Text = ReadSettingStatsMP[4];
                txtTier5MP.Text = ReadSettingStatsMP[5];
                txtTier6MP.Text = ReadSettingStatsMP[6];
            }
            if (ReadSettingStatsZM.Length == 7) {
                txtTier0ZM.Text = ReadSettingStatsZM[0];
                txtTier1ZM.Text = ReadSettingStatsZM[1];
                txtTier2ZM.Text = ReadSettingStatsZM[2];
                txtTier3ZM.Text = ReadSettingStatsZM[3];
                txtTier4ZM.Text = ReadSettingStatsZM[4];
                txtTier5ZM.Text = ReadSettingStatsZM[5];
                txtTier6ZM.Text = ReadSettingStatsZM[6];
            }

            txtWeaponLevel.Text = ReadSettingLevel;

            LoadingCamos = false;
            WeaponModified = false;
        }

        private void rbAR_CheckedChanged(object sender, EventArgs e) {
            if (rbAR.Checked) {
                SaveWeapon();
                SwitchClass(WeaponClass.AssaultRifle);
            }
        }

        private void rbSMG_CheckedChanged(object sender, EventArgs e) {
            if (rbSMG.Checked) {
                SaveWeapon();
                SwitchClass(WeaponClass.SubmachineGun);
            }
        }

        private void rbTR_CheckedChanged(object sender, EventArgs e) {
            if (rbTR.Checked) {
                SaveWeapon();
                SwitchClass(WeaponClass.TacticalRifle);
            }
        }

        private void rbLMG_CheckedChanged(object sender, EventArgs e) {
            if (rbLMG.Checked) {
                SaveWeapon();
                SwitchClass(WeaponClass.LightMachineGun);
            }
        }

        private void rbSR_CheckedChanged(object sender, EventArgs e) {
            if (rbSR.Checked) {
                SaveWeapon();
                SwitchClass(WeaponClass.SniperRifle);
            }
        }

        private void rbPS_CheckedChanged(object sender, EventArgs e) {
            if (rbPS.Checked) {
                SaveWeapon();
                SwitchClass(WeaponClass.Pistol);
            }
        }

        private void rbSG_CheckedChanged(object sender, EventArgs e) {
            if (rbSG.Checked) {
                SaveWeapon();
                SwitchClass(WeaponClass.Shotgun);
            }
        }

        private void rbRL_CheckedChanged(object sender, EventArgs e) {
            if (rbRL.Checked) {
                SaveWeapon();
                SwitchClass(WeaponClass.RocketLauncher);
            }
        }

        private void rbSP_CheckedChanged(object sender, EventArgs e) {
            if (rbSP.Checked) {
                SaveWeapon();
                SwitchClass(WeaponClass.Special);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            SaveWeapon();
            WeaponModified = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                SaveWeapon();
                SelectedWeapon = 0;
                if (ControlsHidden) {
                    SetControlsVisibility(true);
                }
                LoadWeapon();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            if (radioButton2.Checked) {
                SaveWeapon();
                SelectedWeapon = 1;
                if (ControlsHidden) {
                    SetControlsVisibility(true);
                }
                LoadWeapon();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
            if (radioButton3.Checked) {
                SaveWeapon();
                SelectedWeapon = 2;
                if (ControlsHidden) {
                    SetControlsVisibility(true);
                }
                LoadWeapon();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) {
            if (radioButton4.Checked) {
                SaveWeapon();
                SelectedWeapon = 3;
                if (ControlsHidden) {
                    SetControlsVisibility(true);
                }
                LoadWeapon();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e) {
            if (radioButton5.Checked) {
                SaveWeapon();
                SelectedWeapon = 4;
                if (ControlsHidden) {
                    SetControlsVisibility(true);
                }
                LoadWeapon();
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e) {
            if (radioButton6.Checked) {
                SaveWeapon();
                SelectedWeapon = 5;
                if (ControlsHidden) {
                    SetControlsVisibility(true);
                }
                LoadWeapon();
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e) {
            if (radioButton7.Checked) {
                SaveWeapon();
                SelectedWeapon = 6;
                if (ControlsHidden) {
                    SetControlsVisibility(true);
                }
                LoadWeapon();
            }
        }

        [System.Diagnostics.DebuggerStepThrough]
        private void lvMultiplayerCamo_ItemChecked(object sender, ItemCheckedEventArgs e) {
            WeaponModified = true;
            if (e.Item.Checked) {
                CheckPreviousCamos(lvMultiplayerCamo, e.Item.Index);
            }
            else {
                UncheckPostCamos(lvMultiplayerCamo, e.Item.Index);
            }
        }
        [System.Diagnostics.DebuggerStepThrough]
        private void lvZombieCamo_ItemChecked(object sender, ItemCheckedEventArgs e) {
            WeaponModified = true;
            if (e.Item.Checked) {
                CheckPreviousCamos(lvZombieCamo, e.Item.Index);
            }
            else {
                UncheckPostCamos(lvZombieCamo, e.Item.Index);
            }
        }

        [System.Diagnostics.DebuggerStepThrough]
        private void lvMultiplayerCamo_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            if (lvMultiplayerCamo.SelectedItems.Count > 0) {
                lbHowToUnlock.Text = GetHint(lvMultiplayerCamo.Items.IndexOf(lvMultiplayerCamo.SelectedItems[0]), 0);
            }
        }

        [System.Diagnostics.DebuggerStepThrough]
        private void lvZombieCamo_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            if (lvZombieCamo.SelectedItems.Count > 0) {
                lbHowToUnlock.Text = GetHint(lvZombieCamo.Items.IndexOf(lvZombieCamo.SelectedItems[0]), 1);
            }
        }

        private void txtTier_KeyPress(object sender, KeyPressEventArgs e) {
            switch (e.KeyChar) {
                case '1': case '2': case '3':
                case '4': case '5': case '6':
                case '7': case '8': case '9':
                case '0': case (char)8:
                    WeaponModified = true;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            SaveWeapon();
        }

        private void btnReticles_Click(object sender, EventArgs e) {
            frmReticles ShowReticles = new frmReticles();
            ShowReticles.Show();
        }
    }
}
