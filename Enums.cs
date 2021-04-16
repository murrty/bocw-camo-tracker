using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColdWarCamo {
    public enum Weapon : int {
        None = -1,

        XM4 = 10,
        AK47 = 11,
        KRIG6 = 12,
        QBZ83 = 13,
        FFAR1 = 14,
        GROZA = 15,
        FARA83 = 16,

        MP5 = 20,
        MILANO821 = 21,
        AK74U = 22,
        KSP45 = 23,
        BULLFROG = 24,
        MAC10 = 25,
        LC10 = 26,

        TYPE63 = 30,
        M16 = 31,
        AUG = 32,
        DMR14 = 33,

        STONER63 = 40,
        RPD = 41,
        M60 = 42,

        PELINGTON703 = 50,
        LW3TUNDRA = 51,
        M82 = 52,
        ZRG20MM = 53,

        M1911 = 60,
        MAGNUM = 61,
        DIAMATTI = 62,

        HAUER77 = 70,
        GALLOSA12 = 71,
        STREETSWEEPER = 72,

        CIGMA2 = 80,
        RPG7 = 81,

        KNIFE = 90,
        M79 = 91,
        SLEDGEHAMMER = 92,
        WAKIZASHI = 93,
        MACHETE = 94,
        ETOOL = 95,
        R1SHADOWHUNTER = 96
    }
    public enum WeaponClass : int {
        None = -1,

        AssaultRifle = 0,
        SubmachineGun = 1,
        TacticalRifle = 2,
        LightMachineGun = 3,
        SniperRifle = 4,
        Pistol = 5,
        Shotgun = 6,
        RocketLauncher = 7,
        Special = 8
    }
}
