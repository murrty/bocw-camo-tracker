using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdWarCamo {
    public partial class frmReticles : Form {
        int SelectedReticle = -1;
        int SelectedReticleGroup = -1; // 0 = red dots, 1 = zoom
        bool ReticleModified = false;
        bool LoadingReticle = false;
        bool SwitchingGroup = false;
        bool ChangingSelection = false;

        public frmReticles() {
            InitializeComponent();
        }

        private void SaveReticle(int ReticleID) {
            if (ReticleModified) {
                string SaveDataBufferMP = string.Empty;
                string SaveDataBufferZM = string.Empty;

                switch (SelectedReticleGroup) {
                    case 0:
                        for (int i = 0; i < lvMultiplayerReticlesGroup1.Items.Count; i++) {
                            if (lvMultiplayerReticlesGroup1.Items[i].Checked) {
                                SaveDataBufferMP += "1";
                            }
                            else {
                                SaveDataBufferMP += "0";
                            }
                        }
                        for (int i = 0; i < lvZombieReticlesGroup1.Items.Count; i++) {
                            if (lvZombieReticlesGroup1.Items[i].Checked) {
                                SaveDataBufferZM += "1";
                            }
                            else {
                                SaveDataBufferZM += "0";
                            }
                        }
                        break;
                    case 1:
                        for (int i = 0; i < lvMultiplayerReticlesGroup2.Items.Count; i++) {
                            if (lvMultiplayerReticlesGroup2.Items[i].Checked) {
                                SaveDataBufferMP += "1";
                            }
                            else {
                                SaveDataBufferMP += "0";
                            }
                        }
                        for (int i = 0; i < lvZombieReticlesGroup2.Items.Count; i++) {
                            if (lvZombieReticlesGroup2.Items[i].Checked) {
                                SaveDataBufferZM += "1";
                            }
                            else {
                                SaveDataBufferZM += "0";
                            }
                        }
                        break;
                    default:
                        return;
                }

                SaveDataBufferMP = txtADSKillsMP.Text + "|" + SaveDataBufferMP;
                SaveDataBufferZM = txtADSKillsZM.Text + "|" + SaveDataBufferZM;

                switch (ReticleID) {
                    case 0: // Millstop Reflex
                        System.Diagnostics.Debug.Print("Saving MILLSTOPREFLEX");
                        Reticles.Default.MILLSTOPREFLEX_MP = SaveDataBufferMP;
                        Reticles.Default.MILLSTOPREFLEX_ZM = SaveDataBufferZM;
                        break;
                    case 1: // Visiontech 2x
                        System.Diagnostics.Debug.Print("Saving VISIONTECH2X");
                        Reticles.Default.VISIONTECH2X_MP = SaveDataBufferMP;
                        Reticles.Default.VISIONTECH2X_ZM = SaveDataBufferZM;
                        break;
                    case 2: // Kobra Red Dot
                        System.Diagnostics.Debug.Print("Saving KOBRAREDDOT");
                        Reticles.Default.KOBRAREDDOT_MP = SaveDataBufferMP;
                        Reticles.Default.KOBRAREDDOT_ZM = SaveDataBufferZM;
                        break;
                    case 3: // Quickdot LED
                        System.Diagnostics.Debug.Print("Saving QUICKDOTLED");
                        Reticles.Default.QUICKDOTLED_MP = SaveDataBufferMP;
                        Reticles.Default.QUICKDOTLED_ZM = SaveDataBufferZM;
                        break;
                    case 4: // Axial Arms 3x
                        System.Diagnostics.Debug.Print("Saving AXIALARMS3X");
                        Reticles.Default.AXIALARMS3X_MP = SaveDataBufferMP;
                        Reticles.Default.AXIALARMS3X_ZM = SaveDataBufferZM;
                        break;
                    case 5: // Sillix Holoscout
                        System.Diagnostics.Debug.Print("Saving SILLIXHOLOSCOUT");
                        Reticles.Default.SILLIXHOLOSCOUT_MP = SaveDataBufferMP;
                        Reticles.Default.SILLIXHOLOSCOUT_ZM = SaveDataBufferZM;
                        break;
                    case 6: // Microflex LED
                        System.Diagnostics.Debug.Print("Saving MICROFLEXLED");
                        Reticles.Default.MICROFLEXLED_MP = SaveDataBufferMP;
                        Reticles.Default.MICROFLEXLED_ZM = SaveDataBufferZM;
                        break;
                    case 7: // Hawksmoor
                        System.Diagnostics.Debug.Print("Saving HAWKSMOOR");
                        Reticles.Default.HAWKSMOOR_MP = SaveDataBufferMP;
                        Reticles.Default.HAWKSMOOR_ZM = SaveDataBufferZM;
                        break;
                    case 8: // Royal & Kross 4x
                        System.Diagnostics.Debug.Print("Saving ROYALKROSS4X");
                        Reticles.Default.ROYALKROSS4X_MP = SaveDataBufferMP;
                        Reticles.Default.ROYALKROSS4X_ZM = SaveDataBufferZM;
                        break;
                    case 9: // Susat Multizoom
                        System.Diagnostics.Debug.Print("Saving SUSATMULTIZOOM");
                        Reticles.Default.SUSATMULTIZOOM_MP = SaveDataBufferMP;
                        Reticles.Default.SUSATMULTIZOOM_ZM = SaveDataBufferZM;
                        break;
                    case 10: // Diamondback Reflex
                        System.Diagnostics.Debug.Print("Saving DIAMONDBACKREFLEX");
                        Reticles.Default.DIAMONDBACKREFLEX_MP = SaveDataBufferMP;
                        Reticles.Default.DIAMONDBACKREFLEX_ZM = SaveDataBufferZM;
                        break;
                    case 11: // SnapPoint
                        System.Diagnostics.Debug.Print("Saving SNAPPOINT");
                        Reticles.Default.SNAPPOINT_MP = SaveDataBufferMP;
                        Reticles.Default.SNAPPOINT_ZM = SaveDataBufferZM;
                        break;
                    case 12: // Fastpoint Reflex
                        System.Diagnostics.Debug.Print("Saving FASTPOINTREFLEX");
                        Reticles.Default.FASTPOINTREFLEX_MP = SaveDataBufferMP;
                        Reticles.Default.FASTPOINTREFLEX_ZM = SaveDataBufferZM;
                        break;
                    case 13: // Otero Mini Reflex
                        System.Diagnostics.Debug.Print("Saving OTEROMINIREFLEX");
                        Reticles.Default.OTEROMINIREFLEX_MP = SaveDataBufferMP;
                        Reticles.Default.OTEROMINIREFLEX_ZM = SaveDataBufferZM;
                        break;
                    default:
                        return;
                }
                Reticles.Default.Save();
            }

            ReticleModified = false;
        }
        private void LoadReticle(int ReticleID) {
            LoadingReticle = true;
            string ReticleBufferMP;
            string ReticleBufferZM;
            if (SelectedReticle > -1 && ReticleModified) {
                SaveReticle(SelectedReticle);
            }

            switch (ReticleID) {
                case 0: // Millstop Reflex
                    System.Diagnostics.Debug.Print("Loading MILLSTOPREFLEX");
                    LoadReticleGroup(0);
                    ReticleBufferMP = Reticles.Default.MILLSTOPREFLEX_MP;
                    ReticleBufferZM = Reticles.Default.MILLSTOPREFLEX_ZM;
                    break;
                case 1: // Visiontech 2x
                    System.Diagnostics.Debug.Print("Loading VISIONTECH2X");
                    LoadReticleGroup(1);
                    ReticleBufferMP = Reticles.Default.VISIONTECH2X_MP;
                    ReticleBufferZM = Reticles.Default.VISIONTECH2X_ZM;
                    break;
                case 2: // Kobra Red Dot
                    System.Diagnostics.Debug.Print("Loading KOBRAREDDOT");
                    LoadReticleGroup(0);
                    ReticleBufferMP = Reticles.Default.KOBRAREDDOT_MP;
                    ReticleBufferZM = Reticles.Default.KOBRAREDDOT_ZM;
                    break;
                case 3: // Quickdot LED
                    System.Diagnostics.Debug.Print("Loading QUICKDOTLED");
                    LoadReticleGroup(0);
                    ReticleBufferMP = Reticles.Default.QUICKDOTLED_MP;
                    ReticleBufferZM = Reticles.Default.QUICKDOTLED_ZM;
                    break;
                case 4: // Axial Arms 3x
                    System.Diagnostics.Debug.Print("Loading AXIALARMS3X");
                    LoadReticleGroup(1);
                    ReticleBufferMP = Reticles.Default.AXIALARMS3X_MP;
                    ReticleBufferZM = Reticles.Default.AXIALARMS3X_ZM;
                    break;
                case 5: // Sillix Holoscout
                    System.Diagnostics.Debug.Print("Loading SILLIXHOLOSCOUT");
                    LoadReticleGroup(0);
                    ReticleBufferMP = Reticles.Default.SILLIXHOLOSCOUT_MP;
                    ReticleBufferZM = Reticles.Default.SILLIXHOLOSCOUT_ZM;
                    break;
                case 6: // Microflex LED
                    System.Diagnostics.Debug.Print("Loading MICROFLEXLED");
                    LoadReticleGroup(0);
                    ReticleBufferMP = Reticles.Default.MICROFLEXLED_MP;
                    ReticleBufferZM = Reticles.Default.MICROFLEXLED_ZM;
                    break;
                case 7: // Hawksmoor
                    System.Diagnostics.Debug.Print("Loading HAWKSMOOR");
                    LoadReticleGroup(0);
                    ReticleBufferMP = Reticles.Default.HAWKSMOOR_MP;
                    ReticleBufferZM = Reticles.Default.HAWKSMOOR_ZM;
                    break;
                case 8: // Royal & Kross 4x
                    System.Diagnostics.Debug.Print("Loading ROYALKROSS4X");
                    LoadReticleGroup(1);
                    ReticleBufferMP = Reticles.Default.ROYALKROSS4X_MP;
                    ReticleBufferZM = Reticles.Default.ROYALKROSS4X_ZM;
                    break;
                case 9: // Susat Multizoom
                    System.Diagnostics.Debug.Print("Loading SUSATMULTIZOOM");
                    LoadReticleGroup(1);
                    ReticleBufferMP = Reticles.Default.SUSATMULTIZOOM_MP;
                    ReticleBufferZM = Reticles.Default.SUSATMULTIZOOM_ZM;
                    break;
                case 10: // Diamondback Reflex
                    System.Diagnostics.Debug.Print("Loading DIAMONDBACKREFLEX");
                    LoadReticleGroup(0);
                    ReticleBufferMP = Reticles.Default.DIAMONDBACKREFLEX_MP;
                    ReticleBufferZM = Reticles.Default.DIAMONDBACKREFLEX_ZM;
                    break;
                case 11: // SnapPoint
                    System.Diagnostics.Debug.Print("Loading SNAPPOINT");
                    LoadReticleGroup(0);
                    ReticleBufferMP = Reticles.Default.SNAPPOINT_MP;
                    ReticleBufferZM = Reticles.Default.SNAPPOINT_ZM;
                    break;
                case 12: // Fastpoint Reflex
                    System.Diagnostics.Debug.Print("Loading FASTPOINTREFLEX");
                    LoadReticleGroup(0);
                    ReticleBufferMP = Reticles.Default.FASTPOINTREFLEX_MP;
                    ReticleBufferZM = Reticles.Default.FASTPOINTREFLEX_ZM;
                    break;
                case 13: // Otero Mini Reflex
                    System.Diagnostics.Debug.Print("Loading OTEROMINIREFLEX");
                    LoadReticleGroup(0);
                    ReticleBufferMP = Reticles.Default.OTEROMINIREFLEX_MP;
                    ReticleBufferZM = Reticles.Default.OTEROMINIREFLEX_ZM;
                    break;
                default:
                    return;
            }

            string ReticleKillsMP = ReticleBufferMP.Split('|')[0];
            string ReticleKillsZM = ReticleBufferZM.Split('|')[0];
            string ReticlesUnlockedMP = ReticleBufferMP.Split('|')[1];
            string ReticlesUnlockedZM = ReticleBufferZM.Split('|')[1];

            txtADSKillsMP.Text = ReticleKillsMP;
            txtADSKillsZM.Text = ReticleKillsZM;

            if (SelectedReticleGroup == 0) {
                for (int i = 0; i < ReticlesUnlockedMP.Length; i++) {
                    if (ReticlesUnlockedMP[i] == '1') {
                        lvMultiplayerReticlesGroup1.Items[i].Checked = true;
                    }
                    else {
                        lvMultiplayerReticlesGroup1.Items[i].Checked = false;
                    }
                }
                for (int i = 0; i < ReticlesUnlockedZM.Length; i++) {
                    if (ReticlesUnlockedZM[i] == '1') {
                        lvZombieReticlesGroup1.Items[i].Checked = true;
                    }
                    else {
                        lvZombieReticlesGroup1.Items[i].Checked = false;
                    }
                }
            }
            else if (SelectedReticleGroup == 1) {
                for (int i = 0; i < ReticlesUnlockedMP.Length; i++) {
                    if (ReticlesUnlockedMP[i] == '1') {
                        lvMultiplayerReticlesGroup2.Items[i].Checked = true;
                    }
                    else {
                        lvMultiplayerReticlesGroup2.Items[i].Checked = false;
                    }
                }
                for (int i = 0; i < ReticlesUnlockedZM.Length; i++) {
                    if (ReticlesUnlockedZM[i] == '1') {
                        lvZombieReticlesGroup2.Items[i].Checked = true;
                    }
                    else {
                        lvZombieReticlesGroup2.Items[i].Checked = false;
                    }
                }
            }

            SelectedReticle = ReticleID;
            ReticleModified = false;
            LoadingReticle = false;
        }
        private void LoadReticleGroup(int ReticleGroup) {
            if (ReticleGroup != SelectedReticleGroup) {
                switch (ReticleGroup) {
                    case 0:
                        /*
                         MP
                           U-Dot
                           On Target
                           Delta
                           Missile
                           Crosshair Dot
                           Overseer
                           Plus
                           Target Drop
                           Too Bad, So Sad
                           The Steve
                         ZM
                           Glare
                           Murked
                           Apex
                           Luminary
                           Extinction
                           Pit Boss
                           Intersect
                           Teardrop
                           Nightwatch
                           Runed
                        */
                        gbReticleGroup1MP.Visible = true;
                        gbReticleGroup1ZM.Visible = true;
                        gbReticleGroup2MP.Visible = false;
                        gbReticleGroup2ZM.Visible = false;
                        break;
                    case 1:
                        /*
                         MP
                           Recon
                           Hunter
                           On Point
                           Precision
                           Cyclops
                           Killshot
                           Spectral
                           Clean Living
                           Shootout
                           Finger Guns
                         ZM
                           Surveillance
                           Stalker
                           Disrupter
                           Scalpal
                           Sinister
                           Vengeance
                           Resonance
                           Afterlife
                           Atom Smasher
                           Overlord
                         */
                        gbReticleGroup1MP.Visible = false;
                        gbReticleGroup1ZM.Visible = false;
                        gbReticleGroup2MP.Visible = true;
                        gbReticleGroup2ZM.Visible = true;
                        break;
                    default:
                        return;
                }
                ChangingSelection = true;
                ShowHint(-1, true);
                txtADSKillsMP.Visible = true;
                txtADSKillsZM.Visible = true;
                lbADSKillsMP.Visible = true;
                lbADSKillsZM.Visible = true;
                lbHowToUnlock.Visible = true;
                lvMultiplayerReticlesGroup1.SelectedIndices.Clear();
                lvZombieReticlesGroup1.SelectedIndices.Clear();
                lvMultiplayerReticlesGroup2.SelectedIndices.Clear();
                lvZombieReticlesGroup2.SelectedIndices.Clear();
                ChangingSelection = false;
                SelectedReticleGroup = ReticleGroup;
            }
        }
        [System.Diagnostics.DebuggerStepThrough]
        private void CheckPreviousReticles(ListView lv, int ItemIndex) {
            if (!LoadingReticle && !SwitchingGroup) {
                switch (ItemIndex) {
                    case 0:
                        if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                            txtADSKillsMP.Text = "50";
                        }
                        else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                            txtADSKillsZM.Text = "50";
                        }
                        break;
                    case 1:
                        if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                            txtADSKillsMP.Text = "100";
                        }
                        else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                            txtADSKillsZM.Text = "100";
                        }
                        lv.Items[0].Checked = true;
                        break;
                    case 2:
                        if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                            txtADSKillsMP.Text = "150";
                        }
                        else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                            txtADSKillsZM.Text = "250";
                        }
                        lv.Items[1].Checked = true;
                        break;
                    case 3:
                        if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                            txtADSKillsMP.Text = "200";
                        }
                        else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                            txtADSKillsZM.Text = "500";
                        }
                        lv.Items[2].Checked = true;
                        break;
                    case 4:
                        if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                            txtADSKillsMP.Text = "250";
                        }
                        else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                            txtADSKillsZM.Text = "750";
                        }
                        lv.Items[3].Checked = true;
                        break;
                    case 5:
                        if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                            txtADSKillsMP.Text = "300";
                        }
                        else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                            txtADSKillsZM.Text = "1000";
                        }
                        lv.Items[4].Checked = true;
                        break;
                    case 6:
                        if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                            txtADSKillsMP.Text = "350";
                        }
                        else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                            txtADSKillsZM.Text = "1250";
                        }
                        lv.Items[5].Checked = true;
                        break;
                    case 7:
                        if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                            txtADSKillsMP.Text = "400";
                        }
                        else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                            txtADSKillsZM.Text = "1500";
                        }
                        lv.Items[6].Checked = true;
                        break;
                    case 8:
                        if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                            txtADSKillsMP.Text = "450";
                        }
                        else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                            txtADSKillsZM.Text = "1750";
                        }
                        lv.Items[7].Checked = true;
                        break;
                    case 9:
                        if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                            txtADSKillsMP.Text = "500";
                        }
                        else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                            txtADSKillsZM.Text = "2000";
                        }
                        lv.Items[8].Checked = true;
                        break;
                }
                ReticleModified = true;
            }
        }
        [System.Diagnostics.DebuggerStepThrough]
        private void UncheckPostReticles(ListView lv, int ItemIndex) {
            if (!LoadingReticle && !SwitchingGroup) {
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
                    case 4:
                        lv.Items[5].Checked = false;
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
                }
                ReticleModified = true;
            }
        }
        private void SetKills(ListView lv, int ItemIndex) {
            switch (ItemIndex) {
                case 0:
                    if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                        txtADSKillsMP.Text = "50";
                    }
                    else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                        txtADSKillsZM.Text = "50";
                    }
                    break;
                case 1:
                    if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                        txtADSKillsMP.Text = "100";
                    }
                    else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                        txtADSKillsZM.Text = "100";
                    }
                    break;
                case 2:
                    if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                        txtADSKillsMP.Text = "150";
                    }
                    else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                        txtADSKillsZM.Text = "250";
                    }
                    break;
                case 3:
                    if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                        txtADSKillsMP.Text = "200";
                    }
                    else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                        txtADSKillsZM.Text = "500";
                    }
                    break;
                case 4:
                    if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                        txtADSKillsMP.Text = "250";
                    }
                    else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                        txtADSKillsZM.Text = "750";
                    }
                    break;
                case 5:
                    if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                        txtADSKillsMP.Text = "300";
                    }
                    else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                        txtADSKillsZM.Text = "1000";
                    }
                    break;
                case 6:
                    if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                        txtADSKillsMP.Text = "350";
                    }
                    else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                        txtADSKillsZM.Text = "1250";
                    }
                    break;
                case 7:
                    if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                        txtADSKillsMP.Text = "400";
                    }
                    else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                        txtADSKillsZM.Text = "1500";
                    }
                    break;
                case 8:
                    if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                        txtADSKillsMP.Text = "450";
                    }
                    else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                        txtADSKillsZM.Text = "1750";
                    }
                    break;
                case 9:
                    if (lv == lvMultiplayerReticlesGroup1 || lv == lvMultiplayerReticlesGroup2) {
                        txtADSKillsMP.Text = "500";
                    }
                    else if (lv == lvZombieReticlesGroup1 || lv == lvZombieReticlesGroup2) {
                        txtADSKillsZM.Text = "2000";
                    }
                    break;
            }
        }
        private void ShowHint(int Index, bool Multiplayer) {
            switch (Multiplayer) {
                case false:
                    switch (Index) {
                        case 0:
                            lbHowToUnlock.Text = "Get 50 kills while aiming down";
                            break;
                        case 1:
                            lbHowToUnlock.Text = "Get 100 kills while aiming down";
                            break;
                        case 2:
                            lbHowToUnlock.Text = "Get 250 kills while aiming down";
                            break;
                        case 3:
                            lbHowToUnlock.Text = "Get 500 kills while aiming down";
                            break;
                        case 4:
                            lbHowToUnlock.Text = "Get 750 kills while aiming down";
                            break;
                        case 5:
                            lbHowToUnlock.Text = "Get 1000 kills while aiming down";
                            break;
                        case 6:
                            lbHowToUnlock.Text = "Get 1250 kills while aiming down";
                            break;
                        case 7:
                            lbHowToUnlock.Text = "Get 1500 kills while aiming down";
                            break;
                        case 8:
                            lbHowToUnlock.Text = "Get 1750 kills while aiming down";
                            break;
                        case 9:
                            lbHowToUnlock.Text = "Get 2000 kills while aiming down";
                            break;
                        default:
                            lbHowToUnlock.Text = "HEY! Select a reticle to learn how to complete it";
                            break;
                    }
                    break;
                case true:
                    switch (Index) {
                        case 0:
                            lbHowToUnlock.Text = "Get 50 kills while aiming down";
                            break;
                        case 1:
                            lbHowToUnlock.Text = "Get 100 kills while aiming down";
                            break;
                        case 2:
                            lbHowToUnlock.Text = "Get 150 kills while aiming down";
                            break;
                        case 3:
                            lbHowToUnlock.Text = "Get 200 kills while aiming down";
                            break;
                        case 4:
                            lbHowToUnlock.Text = "Get 250 kills while aiming down";
                            break;
                        case 5:
                            lbHowToUnlock.Text = "Get 300 kills while aiming down";
                            break;
                        case 6:
                            lbHowToUnlock.Text = "Get 350 kills while aiming down";
                            break;
                        case 7:
                            lbHowToUnlock.Text = "Get 400 kills while aiming down";
                            break;
                        case 8:
                            lbHowToUnlock.Text = "Get 450 kills while aiming down";
                            break;
                        case 9:
                            lbHowToUnlock.Text = "Get 500 kills while aiming down";
                            break;
                        default:
                            lbHowToUnlock.Text = "HEY! Select a reticle to learn how to complete it";
                            break;
                    }
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                LoadReticle(0);
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            if (radioButton2.Checked) {
                LoadReticle(1);
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
            if (radioButton3.Checked) {
                LoadReticle(2);
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e) {
            if (radioButton4.Checked) {
                LoadReticle(3);
            }
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e) {
            if (radioButton5.Checked) {
                LoadReticle(4);
            }
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e) {
            if (radioButton6.Checked) {
                LoadReticle(5);
            }
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e) {
            if (radioButton7.Checked) {
                LoadReticle(6);
            }
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e) {
            if (radioButton8.Checked) {
                LoadReticle(7);
            }
        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e) {
            if (radioButton9.Checked) {
                LoadReticle(8);
            }
        }
        private void radioButton10_CheckedChanged(object sender, EventArgs e) {
            if (radioButton10.Checked) {
                LoadReticle(9);
            }
        }
        private void radioButton11_CheckedChanged(object sender, EventArgs e) {
            if (radioButton11.Checked) {
                LoadReticle(10);
            }
        }
        private void radioButton12_CheckedChanged(object sender, EventArgs e) {
            if (radioButton12.Checked) {
                LoadReticle(11);
            }
        }
        private void radioButton13_CheckedChanged(object sender, EventArgs e) {
            if (radioButton13.Checked) {
                LoadReticle(12);
            }
        }
        private void radioButton14_CheckedChanged(object sender, EventArgs e) {
            if (radioButton14.Checked) {
                LoadReticle(13);
            }
        }

        private void lvMultiplayerReticlesGroup1_ItemChecked(object sender, ItemCheckedEventArgs e) {
            ReticleModified = true;
            if (e.Item.Checked) {
                CheckPreviousReticles(lvMultiplayerReticlesGroup1, e.Item.Index);
            }
            else {
                UncheckPostReticles(lvMultiplayerReticlesGroup1, e.Item.Index);
            }
            SetKills(lvMultiplayerReticlesGroup1, e.Item.Index);
        }

        private void lvZombieReticlesGroup1_ItemChecked(object sender, ItemCheckedEventArgs e) {
            ReticleModified = true;
            if (e.Item.Checked) {
                CheckPreviousReticles(lvZombieReticlesGroup1, e.Item.Index);
            }
            else {
                UncheckPostReticles(lvZombieReticlesGroup1, e.Item.Index);
            }
            SetKills(lvZombieReticlesGroup1, e.Item.Index);
        }

        private void lvMultiplayerReticlesGroup2_ItemChecked(object sender, ItemCheckedEventArgs e) {
            ReticleModified = true;
            if (e.Item.Checked) {
                CheckPreviousReticles(lvMultiplayerReticlesGroup2, e.Item.Index);
            }
            else {
                UncheckPostReticles(lvMultiplayerReticlesGroup2, e.Item.Index);
            }
            SetKills(lvMultiplayerReticlesGroup2, e.Item.Index);
        }

        private void lvZombieReticlesGroup2_ItemChecked(object sender, ItemCheckedEventArgs e) {
            ReticleModified = true;
            if (e.Item.Checked) {
                CheckPreviousReticles(lvZombieReticlesGroup2, e.Item.Index);
            }
            else {
                UncheckPostReticles(lvZombieReticlesGroup2, e.Item.Index);
            }
            SetKills(lvZombieReticlesGroup2, e.Item.Index);
        }

        private void txtKills_KeyPress(object sender, KeyPressEventArgs e) {
            switch (e.KeyChar) {
                case '1': case '2': case '3':
                case '4': case '5': case '6':
                case '7': case '8': case '9':
                case '0': case (char)8:
                    ReticleModified = true;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void btnSaveReticle_Click(object sender, EventArgs e) {
            SaveReticle(SelectedReticle);
            ReticleModified = false;
        }

        private void lvMultiplayerReticlesGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            if (!ChangingSelection) {
                if (lvMultiplayerReticlesGroup1.SelectedIndices.Count > 0) {
                    ChangingSelection = true;
                    lvZombieReticlesGroup1.SelectedIndices.Clear();
                    ShowHint(lvMultiplayerReticlesGroup1.SelectedIndices[0], true);
                    ChangingSelection = false;
                }
                else {
                    ShowHint(-1, true);
                }
            }
        }

        private void lvZombieReticlesGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            if (!ChangingSelection) {
                if (lvZombieReticlesGroup1.SelectedIndices.Count > 0) {
                    ChangingSelection = true;
                    lvMultiplayerReticlesGroup1.SelectedIndices.Clear();
                    ShowHint(lvZombieReticlesGroup1.SelectedIndices[0], false);
                    ChangingSelection = false;
                }
                else {
                    ShowHint(-1, false);
                }
            }
        }

        private void lvMultiplayerReticlesGroup2_SelectedIndexChanged(object sender, EventArgs e) {
            if (!ChangingSelection) {
                if (lvMultiplayerReticlesGroup2.SelectedIndices.Count > 0) {
                    ChangingSelection = true;
                    lvZombieReticlesGroup2.SelectedIndices.Clear();
                    ShowHint(lvMultiplayerReticlesGroup2.SelectedIndices[0], true);
                    ChangingSelection = false;
                }
                else {
                    ShowHint(-1, true);
                }
            }
        }

        private void lvZombieReticlesGroup2_SelectedIndexChanged(object sender, EventArgs e) {
            if (!ChangingSelection) {
                if (lvZombieReticlesGroup2.SelectedIndices.Count > 0) {
                    ChangingSelection = true;
                    lvMultiplayerReticlesGroup2.SelectedIndices.Clear();
                    ShowHint(lvZombieReticlesGroup2.SelectedIndices[0], false);
                    ChangingSelection = false;
                }
                else {
                    ShowHint(-1, false);
                }
            }
        }
    }
}
